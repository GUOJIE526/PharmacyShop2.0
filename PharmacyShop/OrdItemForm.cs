using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;

namespace PharmacyShop
{
    public partial class OrdItemForm : Form
    {
        ProductClass pd = new ProductClass();
        public OrdItemForm()
        {
            InitializeComponent();
        }

        private void OrdItemForm_Load(object sender, EventArgs e)
        {
            pd.ShowData("orditem", DGVOrdItem);
            pd.ShowData("finishitem", DGVFinishitem);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        void ShipProd(int id)
        {
            SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString);
            conn.Open();
            SqlTransaction trans = conn.BeginTransaction();
            DateTime date = DateTime.Today;
            try
            {
                string ship = "delete from orditem where id = @id";
                SqlCommand cmdhis = new SqlCommand(ship, conn, trans);
                cmdhis.Parameters.AddWithValue("@id", id);
                Console.WriteLine(id);
                cmdhis.ExecuteNonQuery();

                string finish = "insert into finishitem (name, price, qty, cust_id, order_date, finish_date) values (@name, @price, @qty, @cust_id, @orddate, @finidate)";
                SqlCommand cmdfinish = new SqlCommand(finish, conn, trans);
                cmdfinish.Parameters.AddWithValue("@name", txtProdName.Text.Trim());
                cmdfinish.Parameters.AddWithValue("@price", txtPrice.Text.Trim());
                cmdfinish.Parameters.AddWithValue("@qty", txtQty.Text.Trim());
                cmdfinish.Parameters.AddWithValue("@cust_id", txtid.Text.Trim());
                cmdfinish.Parameters.AddWithValue("@orddate", txtdate.Text.Trim());
                cmdfinish.Parameters.AddWithValue("@finidate", date);
                cmdfinish.ExecuteNonQuery();

                MessageBox.Show("出貨成功!!", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtClear();
                trans.Commit();
                conn.Close();
                pd.ShowData("orditem", DGVOrdItem);
                pd.ShowData("finishitem", DGVFinishitem);

            }
            catch (Exception ex)
            {
                MessageBox.Show("資料庫連接失敗: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void txtClear()
        {
            txtid.Clear();
            txtUser.Clear();
            txtphone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtLV.Clear();
            txtProdID.Clear();
            txtProdName.Clear();
            txtPrice.Clear();
            txtQty.Clear();
            txtdate.Clear();
        }

        private void btnShip_Click(object sender, EventArgs e)
        {
            int id = 0;
            Int32.TryParse(txtProdID.Text, out id);
            ShipProd(id);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "")
            {
                SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString);
                conn.Open();
                try
                {
                    string query = "delete from orditem where id = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", txtProdID.Text.Trim());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("刪除訂單成功", "刪除", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pd.ShowData("orditem", DGVOrdItem);
                    txtClear();
                    conn.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("資料庫連接失敗: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("欄位錯誤", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if ((txtProdName.Text != "") && (txtPrice.Text != "") && (txtQty.Text != "") && (txtdate.Text != ""))
            {
                SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString);
                conn.Open();
                try
                {
                    string query = "update orditem set name = @name, price = @price, qty = @qty where id = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtProdName.Text.Trim());
                    cmd.Parameters.AddWithValue("@price", txtPrice.Text.Trim());
                    cmd.Parameters.AddWithValue("@qty", txtQty.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", txtProdID.Text.Trim());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("修改訂單成功", "修改", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    pd.ShowData("orditem", DGVOrdItem);
                }
                catch( Exception ex )
                {
                    MessageBox.Show("資料庫連接失敗: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("欄位未填寫", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void displayCustomer(int custID)
        {
            SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString);
            conn.Open();
            try
            {
                string query = "select * from customer where id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", custID);
                SqlDataReader re = cmd.ExecuteReader();
                if (re.Read())
                {
                    txtid.Text = re["id"].ToString();
                    txtUser.Text = re["name"].ToString();
                    txtphone.Text = re["phone"].ToString();
                    txtEmail.Text = re["email"].ToString();
                    txtAddress.Text = re["address"].ToString();
                    txtLV.Text = re["lv"].ToString();
                }
                re.Close();
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("資料庫連接失敗: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void displayProd(int ID)
        {
            SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString);
            conn.Open();
            try
            {
                string query = "select * from orditem where id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", ID);
                SqlDataReader re = cmd.ExecuteReader();
                if (re.Read())
                {
                    txtProdID.Text = re["id"].ToString();
                    txtProdName.Text = re["name"].ToString();
                    txtdate.Text = Convert.ToDateTime(re["order_date"]).ToString("yyyy/MM/dd");
                    txtPrice.Text = re["price"].ToString();
                    txtQty.Text = re["qty"].ToString();
                }
                re.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("資料庫連接失敗: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGVOrdItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.RowIndex < DGVOrdItem.Rows.Count))
            {
                int custid = 0;
                Int32.TryParse(DGVOrdItem.Rows[e.RowIndex].Cells["cust_id"].Value.ToString(), out custid);
                displayCustomer(custid);
                int prodID = 0;
                Int32.TryParse(DGVOrdItem.Rows[e.RowIndex].Cells["id"].Value.ToString(), out prodID);
                displayProd(prodID);
            }
        }
    }
}
