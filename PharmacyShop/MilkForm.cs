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
    public partial class MilkForm : Form
    {
        public MilkForm()
        {
            InitializeComponent();
        }

        private void MilkForm_Load(object sender, EventArgs e)
        {
            SetButton(txtQuantity1, btnIncrease1, btnDecrese1);
            SetButton(txtQuantity2, btnIncrease2, btnDecrese2);
            SetButton(txtQuantity3, btnIncrease3, btnDecrese3);
        }

        private void SetButton(TextBox textBox, PictureBox btnIncrease, PictureBox btnDecrease)
        {
            btnIncrease.Tag = textBox;
            btnDecrease.Tag = textBox;

            btnIncrease.Click += BtnIncrease_Click;
            btnDecrease.Click += BtnDecrease_Click;
        }

        private void BtnIncrease_Click(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            TextBox textBox = (TextBox)btn.Tag;

            if (int.TryParse(textBox.Text, out int quantity))
            {
                quantity++;
                textBox.Text = quantity.ToString();
            }
        }

        private void BtnDecrease_Click(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            TextBox textBox = (TextBox)btn.Tag;

            if (int.TryParse(textBox.Text, out int quantity) && quantity > 0)
            {
                quantity--;
                textBox.Text = quantity.ToString();
            }
        }

        private void HomeKey_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
