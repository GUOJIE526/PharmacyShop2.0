using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Web;

namespace PharmacyShop
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=pharmacy;Integrated Security=True;Encrypt=False");
        public Form1()
        {
            InitializeComponent();
        }

        public Drag drag;

        private void Form1_Load(object sender, EventArgs e)
        {
            drag = new Drag(this);
            drag.setPanel(pnlTop);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("是否退出應用程式?", "關閉", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (R == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" && txtPass.Text == "")
            {
                lblUserError.Text = "請輸入使用者帳號";
                lblPassError.Text = "請輸入使用者密碼";
            }
            foreach (char c in txtUser.Text)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    lblUserError.Text = "請輸入英文或數字";
                }
            }
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    string username = txtUser.Text.Trim();
                    string password = txtPass.Text.Trim();
                    string sqlselect = @"select * from customers where name = @username and password = @password";
                    using (SqlCommand cmd = new SqlCommand(sqlselect, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                MessageBox.Show("登入成功，將為您轉跳...", "登入", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                OrderForm order = new OrderForm(this, username);
                                order.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("帳號或密碼錯誤，請重新登入", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtUser.Text = "";
                                txtPass.Text = "";
                                txtUser.Focus();
                            }
                            reader.Close();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("資料庫連接失敗: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
        }

        private void chkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPass.Checked)
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '●';
            }
        }

        private void createAccount_Click(object sender, EventArgs e)
        {

        }
    }
}
