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
using System.Windows.Media.Animation;
using System.Windows.Markup;

namespace PharmacyShop
{
    public partial class Form1 : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();

        public Form1()
        {
            InitializeComponent();
        }

        public Drag drag;

        private void Form1_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @"."; //伺服器名稱
            scsb.InitialCatalog = "pharmacy"; //資料庫名稱
            scsb.IntegratedSecurity = true; //Windows驗證: true
            GlobalVar.strDBConnectionString = scsb.ConnectionString.ToString();

            drag = new Drag(this);
            drag.setPanel(pnlTop);
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

            //Customer login
            SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    string username = txtUser.Text.Trim();
                    string password = txtPass.Text.Trim();
                    string sqlselect = @"select 'customer' as userType, id, name, lv from customer where name = @username and password = @password
                      UNION 
                      select 'employee' as userType, id, name, lv from employee where name = @username and password = @password";
                    SqlCommand cmd = new SqlCommand(sqlselect, conn);
                    
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        string userType = reader["userType"].ToString();
                        int userid = (int)reader["id"];
                        GlobalVar.id = userid;
                        GlobalVar.CustPrivilage = (int)reader["lv"];
                        GlobalVar.EmpPrivilage = (int)reader["lv"];
                        MessageBox.Show("登入成功，將為您轉跳...", "登入", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (userType == "customer" && GlobalVar.CustPrivilage == 1)
                        {
                            OrderForm order = new OrderForm(this, username, userid);
                            order.Show();
                        }
                        else if (userType == "employee")
                        {
                            ManagementForm mgr = new ManagementForm(this, GlobalVar.EmpPrivilage);
                            mgr.Show();
                        }
                        else
                        {
                            BlackForm b = new BlackForm();
                            b.Show();
                        }
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
            SignUpForm sign = new SignUpForm();
            sign.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("退出應用程式", "退出", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (R == DialogResult.Yes)
            {
                Close();
            }
            else
            {
                return;
            }
        }
    }
}
