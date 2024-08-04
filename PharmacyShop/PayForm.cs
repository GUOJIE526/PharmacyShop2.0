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
    public partial class PayForm : Form
    {
        public PayForm()
        {
            InitializeComponent();
        }

        private void PayForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLinePay_Click(object sender, EventArgs e)
        {
            if (GlobalVar.listProductCollection.Count > 0) 
            {
                QRCode.Visible = true;
                lblselectpay.Text = "請掃QRCode";

                //傳遞資料庫
                SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString);
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    foreach (ArrayList item in GlobalVar.listProductCollection)
                    {//記錄優惠後的價格
                        string ProdName = (string)item[0];
                        int Prodqty = (int)item[1];
                        int ProdPrice = (int)item[2];
                        double sum = 0;
                        DateTime date = DateTime.Today;
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
                        SqlCommand cmdhistory = new SqlCommand(query, conn, trans);
                        cmdhistory.Parameters.AddWithValue("@ProdName", ProdName);
                        cmdhistory.Parameters.AddWithValue("@Prodqty", Prodqty);
                        cmdhistory.Parameters.AddWithValue("@ProdPrice", ProdPrice);
                        cmdhistory.Parameters.AddWithValue("@userid", userid);
                        cmdhistory.Parameters.AddWithValue("@date", date);
                        cmdhistory.ExecuteNonQuery();

                        //insert orditem
                        string strDB = "insert into orditem (name, price, qty, cust_id, order_date) values (@name, @price, @qty, @id, @date)";
                        SqlCommand cmdord = new SqlCommand(strDB, conn, trans);
                        cmdord.Parameters.AddWithValue("@id", userid);
                        cmdord.Parameters.AddWithValue("@name", ProdName);
                        cmdord.Parameters.AddWithValue("@price", ProdPrice);
                        cmdord.Parameters.AddWithValue("@qty", Prodqty);
                        cmdord.Parameters.AddWithValue("@date", date);
                        cmdord.ExecuteNonQuery();
                    }
                    trans.Commit();
                    conn.Close();
                    MessageBox.Show("訂購單結帳成功", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("資料庫連接失敗: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("請先購買商品", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pnlPay_Click(object sender, EventArgs e)
        {
            QRCode.Visible = false;
            lblselectpay.Text = "請選擇支付方式";
        }
    }
}
