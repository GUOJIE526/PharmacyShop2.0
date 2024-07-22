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
    public partial class DiaperForm : Form
    {
        public List<string> listPampersSize = new List<string>();
        public List<int> PampersSizePrice = new List<int>();
        public List<string> listMamySize = new List<string>();
        public List<int> MamySizePrice = new List<int>();

        string Pamsize = "";
        string Mamysize = "";
        int price = 0;

        public DiaperForm()
        {
            InitializeComponent();
        }

        private void DiaperForm_Load(object sender, EventArgs e)
        {
            SetButton(txtQuantity1, btnIncrease1, btnDecrese1);
            SetButton(txtQuantity2, btnIncrease2, btnDecrese2);

            lblPamperPrice.Text = "$ 329";
            lblMamyPrice.Text = "$ 439";

            listPampersSize.Add("NB");
            listPampersSize.Add("S");
            listPampersSize.Add("M");
            listPampersSize.Add("L");

            PampersSizePrice.Add(329);
            PampersSizePrice.Add(429);
            PampersSizePrice.Add(529);
            PampersSizePrice.Add(629);

            listMamySize.Add("NB");
            listMamySize.Add("S");
            listMamySize.Add("M");
            listMamySize.Add("L");

            MamySizePrice.Add(439);
            MamySizePrice.Add(539);
            MamySizePrice.Add(639);
            MamySizePrice.Add(739);

            for (int i = 0; i < listPampersSize.Count; i++)
            {
                string strItem = $"{listPampersSize[i]}  ${PampersSizePrice[i]}";
                cboxPamperSize.Items.Add(strItem);
                lblPamperPrice.Text = $"${PampersSizePrice[i]}";
            }
            for (int i = 0; i < listMamySize.Count; i++)
            {
                string strItem = $"{listMamySize[i]}  ${MamySizePrice[i]}";
                cbxMamySize.Items.Add(strItem);
                lblMamyPrice.Text = $"${MamySizePrice[i]}";
            }

            //表單預設
            cboxPamperSize.SelectedIndex = 0;
            Pamsize = listPampersSize[cboxPamperSize.SelectedIndex];
            cbxMamySize.SelectedIndex = 0;
            Mamysize = listMamySize[cbxMamySize.SelectedIndex];

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

        private void cboxPamperSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectPam = cboxPamperSize.SelectedIndex;
            if (selectPam >= 0 && selectPam < PampersSizePrice.Count)
            {
                lblPamperPrice.Text = $"${PampersSizePrice[selectPam]}";
            }
        }

        private void cbxMamySize_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectMamy = cbxMamySize.SelectedIndex;
            if (selectMamy >= 0 && selectMamy < MamySizePrice.Count)
            {
                lblMamyPrice.Text = $"${MamySizePrice[selectMamy]}";
            }
        }

        private void HomeKey_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
