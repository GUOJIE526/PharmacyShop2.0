using Guna.UI2.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PharmacyShop
{
    public partial class CartForm : Form
    {
        List<string> listOnSale = new List<string>();
        string OnSale = "";
        public CartForm(int id)
        {
            InitializeComponent();
            GlobalVar.id = id;
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            lblUser.Text = GlobalVar.User;
            listOnSale.Add("同商品第二件半價");
            listOnSale.Add("岡本買一送一");
            foreach (string item in listOnSale)
            {
                cbxOnSale.Items.Add(item);
            } 

            foreach (ArrayList item in GlobalVar.listProductCollection)
            {
                string ProdName = (string)item[0];
                int ProdQty = (int)item[1];
                int ProdPrice = (int)item[2];
                購物清單.Items.Add($"{ProdName}  {ProdQty}個  單價: ${ProdPrice}");
            }
            TotalPrice();
        }

        void TotalPrice()
        {
            int sum = 0;
            foreach (ArrayList item in GlobalVar.listProductCollection)
            {
                sum += (int)item[1] * (int)item[2];
            }
            lblTotalPay.Text = $"總價: ${sum}";
        }

        void OnSalePrice()
        {
            double sum = 0;
            foreach (ArrayList item in GlobalVar.listProductCollection)
            {
                int qty = (int)item[1];
                int price = (int)item[2];

                if (qty >= 2 && qty % 2 == 0)
                {
                    sum += price * qty * 0.75;
                }
                else if(qty >= 2 && qty % 2 == 1)
                {
                    sum += (price * (qty - 1) * 0.75) + price; 
                }
                else
                {
                    sum += price * qty;
                }
            }
            lblTotalPay.Text = $"總價: ${Math.Round(sum, MidpointRounding.AwayFromZero)}";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (lblTotalPay.Text != "$0")
            {
                PayForm payForm = new PayForm();
                payForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("尚未購買商品", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            GlobalVar.listProductCollection.Clear();
            購物清單.Items.Clear();
            OnSalePrice();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (購物清單.SelectedIndex >= 0)
            {
                int select = 購物清單.SelectedIndex;
                購物清單.Items.RemoveAt(select);
                GlobalVar.listProductCollection.RemoveAt(select);
                OnSalePrice();
            }
            else
            {
                MessageBox.Show("請選擇要刪除的商品", "選擇", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPrinter_Click(object sender, EventArgs e)
        {
            if (GlobalVar.listProductCollection.Count == 0)
            {
                MessageBox.Show("尚未購買商品", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string strSavePath = @"D:\資策會課程\Project\PharmacyShop\訂單明細";
                Random random = new Random();
                int randNum = random.Next(1000, 10000);
                string FileName = DateTime.Now.ToString("yyMMddHHmmss") + randNum + "訂購檔.txt";
                string FullSavePath = strSavePath + @"\" + FileName;

                //Console.WriteLine(FullSavePath);
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.InitialDirectory = strSavePath;
                sfd.FileName = FileName;
                sfd.Filter = "文字檔Text File|*.txt";
                DialogResult R = sfd.ShowDialog();

                if (R == DialogResult.OK)
                {
                    FullSavePath = sfd.FileName;
                }
                else
                {
                    return;
                }
                //輸出訂單


                List<string> list訂單輸出 = new List<string>();
                list訂單輸出.Add("************ PA PA Pharmacy訂購單 *************");
                list訂單輸出.Add("------------------------------------");
                list訂單輸出.Add($"訂購時間: {DateTime.Now}");
                list訂單輸出.Add($"訂購人: {GlobalVar.User}");
                list訂單輸出.Add("========== << 訂購明細 >> =========");
                foreach (ArrayList item in GlobalVar.listProductCollection)
                {
                    string ProdName = (string)item[0];
                    int Prodqty = (int)item[1];
                    int ProdPrice = (int)item[2];
                    if (ProdName == "【Okamoto岡本】 002 Hydro水感勁薄")
                    {
                        list訂單輸出.Add($"{ProdName}    {Prodqty}件    ${ProdPrice}");
                        list訂單輸出.Add("【Okamoto岡本】 002 Hydro水感勁薄    1件    $FREE");
                    }
                    else
                    {
                        list訂單輸出.Add($"{ProdName}  {Prodqty}件  單價: ${ProdPrice}");
                    }
                }
                list訂單輸出.Add("=====================================");
                list訂單輸出.Add("-------------------------------------");
                list訂單輸出.Add($"                總金額: {lblTotalPay.Text}");
                list訂單輸出.Add("===================================");
                list訂單輸出.Add("************ 謝謝光臨 **************");
                System.IO.File.WriteAllLines(FullSavePath, list訂單輸出, Encoding.UTF8);
                //輸出資料表
                SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString);
                try
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                        foreach (ArrayList item in GlobalVar.listProductCollection)
                        {//記錄優惠後的價格
                            string ProdName = (string)item[0];
                            int Prodqty = (int)item[1];
                            int ProdPrice = (int)item[2];
                            double sum = 0;
                            if (Prodqty >= 2 && Prodqty % 2 == 0)
                            {
                                ProdPrice = Convert.ToInt32(Math.Round(sum += ProdPrice * Prodqty * 0.75, MidpointRounding.AwayFromZero));
                            }
                            else if (Prodqty >= 2 && Prodqty % 2 == 1)
                            {
                                ProdPrice = Convert.ToInt32(Math.Round(sum += (ProdPrice * (Prodqty - 1) * 0.75) + ProdPrice, MidpointRounding.AwayFromZero));
                            }
                            else
                            {
                                sum += ProdPrice;
                            }

                            int userid = GlobalVar.id;
                            string query = $"insert into historycart (name, qty, price, cust_id, buydate) values (@ProdName, @Prodqty, @ProdPrice, @userid, @date)";
                            DateTime date = DateTime.Today;
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@ProdName", ProdName);
                            cmd.Parameters.AddWithValue("@Prodqty", Prodqty);
                            cmd.Parameters.AddWithValue("@ProdPrice", ProdPrice);
                            cmd.Parameters.AddWithValue("@userid", userid);
                            cmd.Parameters.AddWithValue("@date", date);
                            if (cmd.ExecuteNonQuery() > 0)
                            {

                            }
                            else
                            {
                                MessageBox.Show("訂購單儲存失敗", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        MessageBox.Show("訂購單傳送成功", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GlobalVar.listProductCollection.Clear();
                        購物清單.Items.Clear();
                        OnSalePrice();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("資料庫連接失敗: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { conn.Close(); }
            }
        }

        private void cbxOnSale_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnSale = listOnSale[cbxOnSale.SelectedIndex];
            foreach (ArrayList item in GlobalVar.listProductCollection)
            {
                string ProdName = (string)item[0];
                int ProdQty = (int)item[1];
                int ProdPrice = (int)item[2];
                
                if (cbxOnSale.SelectedIndex == 1 && ProdName == "【Okamoto岡本】 002 Hydro水感勁薄")
                {
                    string freeItem = "【Okamoto岡本】 002 Hydro水感勁薄    1個    $FREE";
                    if (!購物清單.Items.Contains(freeItem))
                    {
                        購物清單.Items.Add(freeItem);
                    }
                    else
                    {
                        MessageBox.Show("你用不到這麼多", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }
            if (cbxOnSale.SelectedIndex == 0)
            {
                OnSalePrice();
            }
        }

        private void CartForm_Activated(object sender, EventArgs e)
        {
            lblUser.Text = $"{GlobalVar.User}";
        }
    }
}
