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
using System.Web.UI.WebControls;
using System.Windows.Controls;
using System.Windows.Forms;

namespace PharmacyShop
{
    public partial class OrderForm : Form
    {
        private Form1 login;
        private string username;
        private int id;

        public OrderForm(Form1 login, string username, int id)
        {
            InitializeComponent();
            this.login = login;
            GlobalVar.User = username;
            this.id = id;
        }

        public Drag drag;
        public OpenForm open;

        private void OrderForm_Load(object sender, EventArgs e)
        {
            GlobalVar.id = (int)id;
            drag = new Drag(this);
            drag.setPanel(pnlHome);
            drag.setPanel(pnlside);
            open = new OpenForm();
            lblUser.Text = $"{GlobalVar.User}";
        }

        private void btnBaby_Click(object sender, EventArgs e)
        {
            open.openForm(new BabyForm(), pnlHome);
        }

        private void btnBeauty_Click(object sender, EventArgs e)
        {
            open.openForm(new BeautyForm(), pnlHome);
        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {
            open.openForm(new MedicineForm(), pnlHome);
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            CartForm cart = new CartForm(id);
            cart.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("應用程式登出?", "登出", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (R == DialogResult.Yes)
            {
                GlobalVar.id = 0;
                GlobalVar.User = "";
                login.Show();
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void btnBaby_MouseHover(object sender, EventArgs e)
        {
            btnBaby.BackColor = Color.SeaGreen;
        }

        private void btnBeauty_MouseHover(object sender, EventArgs e)
        {
            btnBeauty.BackColor = Color.SeaGreen;
        }

        private void btnMedicine_MouseHover(object sender, EventArgs e)
        {
            btnMedicine.BackColor = Color.SeaGreen;
        }

        private void btnBaby_MouseLeave(object sender, EventArgs e)
        {
            btnBaby.BackColor = SystemColors.Control;
        }

        private void btnBeauty_MouseLeave(object sender, EventArgs e)
        {
            btnBeauty.BackColor = SystemColors.Control;
        }

        private void btnMedicine_MouseLeave(object sender, EventArgs e)
        {
            btnMedicine.BackColor = SystemColors.Control;
        }

        private void lbl會員中心_Click(object sender, EventArgs e)
        {
            open.openForm(new CustCenter(), pnlHome);
        }

        private void OrderForm_Activated(object sender, EventArgs e)
        {
            lblUser.Text = $"{GlobalVar.User}";
        }
    }
}
