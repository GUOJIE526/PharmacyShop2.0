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

namespace PharmacyShop
{
    public partial class CustCenter : Form
    {
        public CustCenter()
        {
            InitializeComponent();
        }

        private void CustCenter_Load(object sender, EventArgs e)
        {

        }

        void ShowDataSet()
        {
            SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString);
            conn.Open();
            string query = "Select name 商品名稱, qty 數量, price 價格, buydate 購買日期 from historycart where cust_id = @id";
            SqlCommand cmd = new SqlCommand(query, conn);
            
            cmd.Parameters.AddWithValue("@id", GlobalVar.id);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                DataHistory.DataSource = dt;
            }
            reader.Close();
            conn.Close();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            DataHistory.Visible = true;
            ShowDataSet();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCustInfo_Click(object sender, EventArgs e)
        {
            lblid.Visible = true;
            lbluser.Visible = true;
            lblpass.Visible = true;
            lblphone.Visible = true;
            lblemail.Visible = true;
            lbladdress.Visible = true;
            txtid.Visible = true;
            txtUser.Visible = true;
            txtPass.Visible = true;
            txtphone.Visible = true;
            txtEmail.Visible = true;
            txtAddress.Visible = true;
            ShowPass.Visible = true;
            btnUpdate.Visible = true;

            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            try
            {
                string strDB = "select * from customer where id = @id";
                SqlCommand cmd = new SqlCommand(strDB, con);
                cmd.Parameters.AddWithValue("@id", GlobalVar.id);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtid.Text = reader["id"].ToString();
                    txtUser.Text = reader["name"].ToString();
                    txtPass.Text = reader["password"].ToString();
                    txtphone.Text = reader["phone"].ToString();
                    txtEmail.Text = reader["email"].ToString();
                    txtAddress.Text = reader["address"].ToString();
                }
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("資料庫連接失敗: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtUser.ReadOnly = false;
            txtUser.BackColor = Color.White;
            txtPass.ReadOnly = false;
            txtPass.BackColor = Color.White;
            txtphone.ReadOnly = false;
            txtphone.BackColor = Color.White;
            txtEmail.ReadOnly = false;
            txtEmail.BackColor = Color.White;
            txtAddress.ReadOnly = false;
            txtAddress.BackColor = Color.White;
            btnConfirm.Visible = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            try
            {
                string strDB = "update customer set name = @name, password = @password, phone = @phone, email = @email, address = @address, updatetime = @date where id = @id;";
                DateTime date = DateTime.Today;
                SqlCommand cmd = new SqlCommand(strDB, con);
                cmd.Parameters.AddWithValue("@id", GlobalVar.id);
                cmd.Parameters.AddWithValue("@name", txtUser.Text.Trim());
                cmd.Parameters.AddWithValue("@password", txtPass.Text.Trim());
                cmd.Parameters.AddWithValue("@phone", txtphone.Text.Trim());
                cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@date", date);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("資料修改成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUser.ReadOnly = true;
                    txtUser.BackColor = Color.DarkGray;
                    txtPass.ReadOnly = true;
                    txtPass.BackColor = Color.DarkGray;
                    txtphone.ReadOnly = true;
                    txtphone.BackColor = Color.DarkGray;
                    txtEmail.ReadOnly = true;
                    txtEmail.BackColor = Color.DarkGray;
                    txtAddress.ReadOnly = true;
                    txtAddress.BackColor = Color.DarkGray;
                    btnConfirm.Visible = false;
                    GlobalVar.User = txtUser.Text;
                    //Console.WriteLine(GlobalVar.User);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("資料庫連接失敗: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowPass_MouseHover(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '\0';
        }

        private void ShowPass_MouseLeave(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '●';
        }
    }
}
