using System;
using System.Collections;
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
        public List<PictureBox> listPic = new List<PictureBox>();
        public List<string> listDiaperName = new List<string>();
        public List<string> listPampersSize = new List<string>();
        public List<int> PampersSizePrice = new List<int>();
        public List<string> listMamySize = new List<string>();
        public List<int> MamySizePrice = new List<int>();

        
        string PamName = "";
        string MamName = "";
        string Pamsize = "";
        string Mamysize = "";
        int quantity1 = 0;
        int quantity2 = 0;
        int price1 = 0;
        int price2 = 0;

        public DiaperForm()
        {
            InitializeComponent();
        }

        private void DiaperForm_Load(object sender, EventArgs e)
        {

            listPic.Add(picPampers);
            listPic.Add(picMamyPoko);

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
            }
            for (int i = 0; i < listMamySize.Count; i++)
            {
                string strItem = $"{listMamySize[i]}  ${MamySizePrice[i]}";
                cbxMamySize.Items.Add(strItem);
            }

            //表單預設
            cboxPamperSize.SelectedIndex = 0;
            Pamsize = listPampersSize[cboxPamperSize.SelectedIndex];
            cbxMamySize.SelectedIndex = 0;
            Mamysize = listMamySize[cbxMamySize.SelectedIndex];

            PamName = lblPam.Text;
            MamName = lblMamy.Text;
            quantity1 = 1;
            txtQuantity1.Text = quantity1.ToString();
            price1 = PampersSizePrice[cboxPamperSize.SelectedIndex];
            lblPamperPrice.Text = $"${price1}";

            quantity2 = 1;
            txtQuantity2.Text = quantity2.ToString();
            price2 = MamySizePrice[cbxMamySize.SelectedIndex];
            lblMamyPrice.Text = $"${price2}";
        }

        void PamSumPrice()
        {
            if (cboxPamperSize.SelectedIndex >= 0)
            {
                lblPamperPrice.Text = $"${price1 * quantity1}";
            }
        }

        void MamySumPrice()
        {
            if (cbxMamySize.SelectedIndex >= 0)
            {
                lblMamyPrice.Text = $"${price2 * quantity2}";
            }
        }

        private void cboxPamperSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectPam = cboxPamperSize.SelectedIndex;
            if (selectPam >= 0 && selectPam < PampersSizePrice.Count)
            {
                price1 = PampersSizePrice[selectPam];
                //lblPamperPrice.Text = $"${PampersSizePrice[selectPam]}";
                PamSumPrice();
            }
        }

        private void cbxMamySize_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectMamy = cbxMamySize.SelectedIndex;
            if (selectMamy >= 0 && selectMamy < MamySizePrice.Count)
            {
                price2 = MamySizePrice[selectMamy];
                //lblMamyPrice.Text = $"${MamySizePrice[selectMamy]}";
                MamySumPrice();
            }
        }

        private void HomeKey_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtQuantity1_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity1.Text != "")
            {
                bool isQuantity1 = Int32.TryParse(txtQuantity1.Text, out quantity1);
                if((isQuantity1) && (quantity1 > 0) && (quantity1 < 100))
                {
                    PamSumPrice();
                }
                else
                {
                    MessageBox.Show("數量輸入錯誤", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    quantity1 = 1;
                    txtQuantity1.Text = quantity1.ToString();
                    PamSumPrice();
                }
                
            }
        }

        private void txtQuantity2_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity2.Text != "")
            {
                bool isQuantity2 = Int32.TryParse(txtQuantity2.Text, out quantity2);
                if ((isQuantity2) && (quantity2 > 0) && (quantity2 < 100))
                {
                    MamySumPrice();
                }
                else
                {
                    MessageBox.Show("數量輸入錯誤", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    quantity2 = 1;
                    txtQuantity2.Text = quantity2.ToString();
                    MamySumPrice();
                }
                
            }
        }

        private void btnIncrease1_Click(object sender, EventArgs e)
        {
            txtQuantity1.Text = $"{++quantity1}";
            PamSumPrice();
        }

        private void btnDecrese1_Click(object sender, EventArgs e)
        {
            txtQuantity1.Text = $"{--quantity1}";
            PamSumPrice();
        }

        private void btnIncrease2_Click(object sender, EventArgs e)
        {
            txtQuantity2.Text = $"{++quantity2}";
            MamySumPrice();
        }

        private void btnDecrese2_Click(object sender, EventArgs e)
        {
            txtQuantity2.Text = $"{--quantity2}";
            MamySumPrice();
        }

        private void btnAddDiaper1_Click(object sender, EventArgs e)
        {
        }

        private void btnAddDiaper2_Click(object sender, EventArgs e)
        {

        }
    }
}
