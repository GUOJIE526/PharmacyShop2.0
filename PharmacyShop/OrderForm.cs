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
    public partial class OrderForm : Form
    {
        bool sidebarExpand = true;
        private Form1 loginform;

        public OrderForm(Form1 loginform)
        {
            InitializeComponent();
            this.loginform = loginform;
        }

        public Drag drag;
        public OpenForm open;

        private void OrderForm_Load(object sender, EventArgs e)
        {
            drag = new Drag(this);
            drag.setPanel(pnlOrdTop);
            跑馬燈Timer.Start();
            open = new OpenForm();
        }

        private void btnClose_Click(object sender, EventArgs e)
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

        private void btnCart_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("是否登出回到登入頁面?", "登出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (R == DialogResult.OK)
            {
                loginform.Show();
                this.Close();
            }
            else
            {
                return;
            }
        }

        void isVisible(Panel panel)//panel展開收起的方法
        {
            if (panel.Visible == true)
            {
                panel.Visible = false;
            }
            else
            {
                panel.Visible = true;
            }
        }

        private void SideBartimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                pnlSideBar.Width += 40;
                if (pnlSideBar.Width == pnlSideBar.MaximumSize.Width)
                {
                    sidebarExpand = false;
                    SideBartimer.Stop();
                }
            }
            else
            {
                pnlSideBar.Width -= 40;
                if (pnlSideBar.Width == pnlSideBar.MinimumSize.Width)
                {
                    sidebarExpand = true;
                    SideBartimer.Stop();
                }
            }
        }//SlideBar

        private void 跑馬燈Timer_Tick(object sender, EventArgs e)
        {
            lbl跑馬燈.Left -= 30;
            if (lbl跑馬燈.Right < 0)
            {
                lbl跑馬燈.Left = pnl跑馬燈.Width;
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            SideBartimer.Start();

            if (lblTitle.Visible)
            {
                lblTitle.Visible = false;
                pnlBaby.Visible = false;
                pnlBeauty.Visible = false;
                pnlHealth.Visible = false;
                pnlAnimal.Visible = false;
            }
            else
            {
                lblTitle.Visible = true;
            }
            
        }

        private void btn婦幼_Click(object sender, EventArgs e)
        {
            isVisible(pnlBaby);
        }

        private void btnHealth_Click(object sender, EventArgs e)
        {
            isVisible(pnlHealth);
        }

        private void btnBeauty_Click(object sender, EventArgs e)
        {
            isVisible(pnlBeauty);
        }

        private void btnAnimal_Click(object sender, EventArgs e)
        {
            isVisible(pnlAnimal);
        }

        private void btnMilk_Click(object sender, EventArgs e)
        {
            open.openForm(new MilkForm(), pnlHome);
            pnlSideBar.BringToFront();
        }

        private void btnDiaper_Click(object sender, EventArgs e)
        {
            open.openForm(new DiaperForm(), pnlHome);
            pnlSideBar.BringToFront();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {

        }

        private void btnToy_Click(object sender, EventArgs e)
        {

        }

        private void btnVicta_Click(object sender, EventArgs e)
        {

        }

        private void btnMed_Click(object sender, EventArgs e)
        {

        }

        private void btnBabyHealth_Click(object sender, EventArgs e)
        {

        }

        private void btnGG_Click(object sender, EventArgs e)
        {

        }

        private void btnFace_Click(object sender, EventArgs e)
        {

        }

        private void btnBody_Click(object sender, EventArgs e)
        {

        }

        private void btnBabyWash_Click(object sender, EventArgs e)
        {

        }

        private void btnPregMom_Click(object sender, EventArgs e)
        {

        }

        private void btnCan_Click(object sender, EventArgs e)
        {

        }

        private void btnAnimalStuff_Click(object sender, EventArgs e)
        {

        }

        private void btnAniWash_Click(object sender, EventArgs e)
        {

        }
    }
}
