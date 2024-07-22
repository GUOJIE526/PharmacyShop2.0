using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyShop
{
    public partial class Form1 : Form
    {
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
            OrderForm orderForm = new OrderForm(this);//把Form1傳到OrderForm
            orderForm.Show();
            this.Hide();

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

        private void btnSignUp_Click(object sender, EventArgs e)
        {

        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {

        }
    }
}
