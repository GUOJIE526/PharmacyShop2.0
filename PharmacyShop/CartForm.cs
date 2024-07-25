using Guna.UI2.WinForms;
using System;
using System.Collections;
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
    public partial class CartForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=pharmacy;Integrated Security=True;Encrypt=False");
        List<string> listOnSale = new List<string>();
        string OnSale = "";
        public CartForm()
        {
            InitializeComponent();
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            listOnSale.Add("第二件75折");
            listOnSale.Add("岡本買一送一");
            foreach (string item in listOnSale)
            {
                cbxOnSale.Items.Add(item);
            }

            cbxOnSale.SelectedIndex = 0;
            OnSale = listOnSale[cbxOnSale.SelectedIndex];
            foreach (ArrayList item in GlobalVar.listProductCollection)
            {
                //MessageBox.Show($"Item Structure: {item[0]}, {item[1]}, {item[2]}");
                string ProdName = (string)item[0];
                int ProdQty = (int)item[1];
                int ProdPrice = (int)item[2];
                購物清單.Items.Add($"{ProdName}      {ProdQty}個      ${ProdPrice}");
            }
            TotalPrice();
        }

        void TotalPrice()
        {
            int sum = 0;
            foreach (ArrayList item in GlobalVar.listProductCollection)
            {
                int price = (int)item[2];
                sum += price;
            }
            lblTotalPay.Text = $"${sum}";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnPrinter_Click(object sender, EventArgs e)
        {

        }

        private void cbxOnSale_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnSale = listOnSale[cbxOnSale.SelectedIndex];
            foreach (ArrayList item in GlobalVar.listProductCollection)
            {
                string ProdName = (string)item[0];
                if (cbxOnSale.SelectedIndex == 1 && ProdName == "【Okamoto岡本】 002 Hydro水感勁薄")
                {
                    string freeItem = "【Okamoto岡本】 002 Hydro水感勁薄      1個      $FREE";
                    if (!購物清單.Items.Contains(freeItem))
                    {
                        購物清單.Items.Add(freeItem);
                    }
                    else
                    {
                        MessageBox.Show("你不需要這麼多", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }
        }
    }
}
