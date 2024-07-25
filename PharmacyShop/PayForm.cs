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
    public partial class PayForm : Form
    {
        public PayForm()
        {
            InitializeComponent();
        }

        private void PayForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLinePay_Click(object sender, EventArgs e)
        {
            QRCode.Visible = true;
            lblselectpay.Text = "請掃QRCode";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pnlPay_Click(object sender, EventArgs e)
        {
            QRCode.Visible = false;
            lblselectpay.Text = "請選擇支付方式";
        }
    }
}
