using Guna.UI2.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PharmacyShop
{
    public partial class CartForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=pharmacy;Integrated Security=True;Encrypt=False");
        List<string> listOnSale = new List<string>();
        string OnSale = "";
        public CartForm()
        {
            InitializeComponent();
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            listOnSale.Add("第二件75折");
            listOnSale.Add("岡本買一送一");
            foreach (string item in listOnSale)
            {
                cbxOnSale.Items.Add(item);
            }

            cbxOnSale.SelectedIndex = 0;
            OnSale = listOnSale[cbxOnSale.SelectedIndex];
            foreach (ArrayList item in GlobalVar.listProductCollection)
            {
                //MessageBox.Show($"Item Structure: {item[0]}, {item[1]}, {item[2]}");
                string ProdName = (string)item[0];
                int ProdQty = (int)item[1];
                int ProdPrice = (int)item[2];
                購物清單.Items.Add($"{ProdName}      {ProdQty}個      ${ProdPrice}");
            }
            TotalPrice();
        }

        void TotalPrice()
        {
            int sum = 0;
            foreach (ArrayList item in GlobalVar.listProductCollection)
            {
                int price = (int)item[2];
                sum += price;
            }
            lblTotalPay.Text = $"${sum}";
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
            TotalPrice();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (購物清單.SelectedIndex >= 0)
            {
                int select = 購物清單.SelectedIndex;
                購物清單.Items.RemoveAt(select);
                GlobalVar.listProductCollection.RemoveAt(select);
                TotalPrice();
            }
            else
            {
                MessageBox.Show("請選擇要刪除的商品", "選擇", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPrinter_Click(object sender, EventArgs e)
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
            list訂單輸出.Add("************ 冷飲訂購單 *************");
            list訂單輸出.Add("------------------------------------");
            list訂單輸出.Add($"訂購時間: {DateTime.Now}");
            list訂單輸出.Add($"訂購人: {GlobalVar.User}");
            list訂單輸出.Add("========== << 訂購品項 >> =========");
            foreach (ArrayList item in GlobalVar.listProductCollection)
            {
                string ProdName = (string)item[0];
                int Prodqty = (int)item[1];
                int ProdPrice = (int)item[2];

                list訂單輸出.Add($"{ProdName}    {Prodqty}件    ${ProdPrice}");
            }
            list訂單輸出.Add("=====================================");
            list訂單輸出.Add("-------------------------------------");
            list訂單輸出.Add($"                總金額: {lblTotalPay.Text}");
            list訂單輸出.Add("===================================");
            list訂單輸出.Add("************ 謝謝光臨 **************");
            System.IO.File.WriteAllLines(FullSavePath, list訂單輸出, Encoding.UTF8);
            MessageBox.Show("訂購單儲存成功", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbxOnSale_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnSale = listOnSale[cbxOnSale.SelectedIndex];
            foreach (ArrayList item in GlobalVar.listProductCollection)
            {
                string ProdName = (string)item[0];
                if (cbxOnSale.SelectedIndex == 1 && ProdName == "【Okamoto岡本】 002 Hydro水感勁薄")
                {
                    string freeItem = "【Okamoto岡本】 002 Hydro水感勁薄      1個      $FREE";
                    if (!購物清單.Items.Contains(freeItem))
                    {
                        購物清單.Items.Add(freeItem);
                    }
                    else
                    {
                        MessageBox.Show("你不需要這麼多", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }
        }
    }
}
