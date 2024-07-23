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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);

        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'pharmacyDataSet.customers' 資料表。您可以視需要進行移動或移除。
            this.customersTableAdapter.Fill(this.pharmacyDataSet.customers);

        }
    }
}
