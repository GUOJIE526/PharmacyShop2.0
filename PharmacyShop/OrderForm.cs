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
using System.Windows.Forms;

namespace PharmacyShop
{
    public partial class OrderForm : Form
    {
        private Form1 login;

        public OrderForm(Form1 login)
        {
            InitializeComponent();
            this.login = login;
        }

        public Drag drag;
        public OpenForm open;


        private void OrderForm_Load(object sender, EventArgs e)
        {
            drag = new Drag(this);
            drag.setPanel(pnlHome);
            open = new OpenForm();
        }

        private void btnBaby_Click(object sender, EventArgs e)
        {
            open.openForm(new BabyForm(), pnlHome);
        }

        private void btnBeauty_Click(object sender, EventArgs e)
        {

        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {

        }

        private void btnCart_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("應用程式登出?", "登出", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (R == DialogResult.Yes)
            {
                login.Show();
                this.Close();
            }
            else
            {
                return;
            }
        }
    }
}
