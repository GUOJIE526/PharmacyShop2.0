using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyShop
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBKLogin_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool checkValid()
        {
            bool isValid = true;
            string name = txtName.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            bool chkname = Regex.IsMatch(name, @"^[a-z]|[A-Z]|[0-9]$");
            bool chkphone = Regex.IsMatch(phone,@"^09[0-9]{8}$");
            bool chkemail = Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            if (!chkname)
            {
                lblError1.Text = "用戶名格式錯誤";
                isValid = false;
            }
            else
            {
                lblError1.Text = "";
            }
            if (string.IsNullOrEmpty(txtPass.Text))
            {
                lblError2.Text = "密碼不可為空";
                isValid = false;
            }
            else
            {
                lblError2.Text = "";
            }
            if (!chkphone)
            {
                lblError3.Text = "手機號碼錯誤";
                isValid = false;
            }
            else
            {
                lblError3.Text = "";
            }
            if (!chkemail)
            {
                lblError4.Text = "信箱格式錯誤";
                isValid = false;
            }
            else
            {
                lblError4.Text = "";
            }
            string address = txtAddress.Text;
            if (string.IsNullOrEmpty(address))
            {
                lblError5.Text = "地址不可為空";
                isValid = false;
            }
            else
            {
                lblError5.Text = "";
            }
            return isValid;
        }

        private void textTonull()
        {
            txtName.Text = "";
            txtPass.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtName.Focus();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (!checkValid())
            {
                return;
            }
            else
            {
                SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString);
                if (conn.State != ConnectionState.Open)
                {
                    try
                    {
                        conn.Open();
                        string username = txtName.Text.Trim();
                        string hasUser = "select * from customer where name = @username";
                        using (SqlCommand cmd = new SqlCommand(hasUser, conn))
                        {
                            cmd.Parameters.AddWithValue("@username", username);
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    MessageBox.Show("使用者名稱已存在", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    textTonull();
                                    return;
                                }
                                reader.Close();
                            }
                        }
                        string insertdata = "insert into customer (name, password, phone, email, address, createdate, lv) values (@name, @password, @phone, @email, @address, @date, @lv)";
                        DateTime date = DateTime.Today;
                        GlobalVar.CustPrivilage = 1;
                        SqlCommand sql = new SqlCommand(insertdata, conn);
                        sql.Parameters.AddWithValue("@name", txtName.Text.Trim());
                        sql.Parameters.AddWithValue("@password", txtPass.Text.Trim());
                        sql.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                        sql.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        sql.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
                        sql.Parameters.AddWithValue("@date", date);
                        sql.Parameters.AddWithValue("@lv", GlobalVar.CustPrivilage);

                        if (sql.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("帳戶創建成功!!", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("帳戶創建失敗!!", "失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textTonull();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("資料庫連接失敗: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass.Checked)
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '●';
            }
        }
    }
}
