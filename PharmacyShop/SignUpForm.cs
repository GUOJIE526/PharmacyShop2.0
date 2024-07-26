using Guna.UI2.WinForms;
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
    public partial class SignUpForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=pharmacy;Integrated Security=True;Encrypt=False");
        
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

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (!txtName.Text.All(char.IsLetterOrDigit))
            {
                lblError1.Text = "請輸入英文或數字";
            }
            else if(string.IsNullOrEmpty(txtName.Text))
            {
                lblError1.Text = "請輸入使用者帳號";
            }
            else
            {
                lblError1.Text = "";
            }

            if (string.IsNullOrEmpty(txtPass.Text))
            {
                lblError2.Text = "密碼不可為空";
            }
            else
            {
                lblError2.Text = "";
            }

            string phoneNum = txtPhone.Text;
            if (phoneNum.Length != 10 || phoneNum[0] != '0' || phoneNum[1] != '9' || string.IsNullOrEmpty(phoneNum))
            {
                lblError3.Text = "請輸入正確手機號碼";
            }
            else
            {
                lblError3.Text = "";
            }
            string email = txtEmail.Text;
            bool contains = email.Contains('@');
            if (!contains || string.IsNullOrEmpty(email) || !email.EndsWith(".com"))
            {
                lblError4.Text = "請輸入有效信箱";
            }
            else
            {
                lblError4.Text = "";
            }
            string address = txtAddress.Text;
            if (!isChinese(address) || string.IsNullOrEmpty(address))
            {
                lblError5.Text = "請輸入正確地址";
            }
            else
            {
                lblError5.Text = "";
            }

        }
        private bool isChinese(string strChinese)
        {
            int strMax = Convert.ToInt32("9fff", 16);
            int strMin = Convert.ToInt32("4e00", 16);

            foreach (char c in strChinese)
            {
                int Range = Convert.ToInt32(c);
                if (Range >= strMin && Range <= strMax)
                {
                    return true; // 找到中文字符，直接返回 true
                }
            }
            return false; // 沒有找到中文字符，返回 false
        }
    }
}
