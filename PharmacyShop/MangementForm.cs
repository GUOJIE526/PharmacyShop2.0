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
using System.Windows.Forms;

namespace PharmacyShop
{
    public partial class MangementForm : Form
    {
        private Form1 login;
        private int id;
        public Drag drag;
        public OpenForm open;

        public MangementForm(Form1 login, int id)
        {
            InitializeComponent();
            this.login = login;
            this.id = id;
        }

        private void MangementForm_Load(object sender, EventArgs e)
        {
            drag = new Drag(this);
            drag.setPanel(pnlTopBar);
            open = new OpenForm();
            ShowDataSet("milk", dataMilk);
            ShowDataSet("diaper", dataDiaper);
            ShowDataSet("beauty", dataBeauty);
            ShowDataSet("perfume", dataPerfume);
            ShowDataSet("medicine", dataMed);
            ShowDataSet("mm", dataMM);
        }

        void ShowDataSet(string tableName, Guna2DataGridView DGV)
        {
            SqlConnection conn  = new SqlConnection(GlobalVar.strDBConnectionString);
            conn.Open();
            try
            {
                string strDB = $"select id as 商品編號, name as 商品, price as 價格, qty as 數量 from {tableName}";
                SqlCommand cmd = new SqlCommand(strDB, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    DGV.DataSource = dt;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("資料庫連接失敗: " + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
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

        private void btnCustSys_Click(object sender, EventArgs e)
        {
            open.openForm(new CustSYSForm(), pnlMgr);
        }

        private void btnOrdSys_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
