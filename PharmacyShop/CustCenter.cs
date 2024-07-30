using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
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
            txtChangePass.Visible = false;
            btnConfirm.Visible = false;
            lbl指示.Visible = false;
            ShowPass.Visible = false;
            DataHistory.Visible = false;
        }

        private void ShowDataSet()
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

        private void btnCallus_Click(object sender, EventArgs e)
        {

        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            txtChangePass.Visible = true;
            btnConfirm.Visible = true;
            lbl指示.Visible = true;
            ShowPass.Visible = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString);
            conn.Open();
            try
            {
                string query = "update customer set password = @NewPassword where id = @id;";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", GlobalVar.id);
                cmd.Parameters.AddWithValue("@NewPassword", txtChangePass.Text);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("密碼修改成功!!", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtChangePass.Clear();
                }
                else
                {
                    MessageBox.Show("密碼修改失敗!!", "失敗", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("資料庫連接失敗: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCustInfo_Click(object sender, EventArgs e)
        {

        }

        private void ShowPass_Click(object sender, EventArgs e)
        {

        }

        private void ShowPass_MouseHover(object sender, EventArgs e)
        {
            txtChangePass.PasswordChar = '\0';
        }

        private void ShowPass_MouseLeave(object sender, EventArgs e)
        {
            txtChangePass.PasswordChar = '●';
        }
    }
}
