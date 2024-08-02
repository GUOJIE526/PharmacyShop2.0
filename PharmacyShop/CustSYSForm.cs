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
    public partial class CustSYSForm : Form
    {
        public ProductClass pd = new ProductClass();
        Guna2DataGridView DGV = new Guna2DataGridView();
        public CustSYSForm()
        {
            InitializeComponent();
        }

        private void CustSYSForm_Load(object sender, EventArgs e)
        {
            DGV = dataCust;
            pd.ShowData("customer", DGV);
        }

        private void btnCustInsert_Click(object sender, EventArgs e)
        {

        }

        private void btnDrop_Click(object sender, EventArgs e)
        {

        }

        private void btnNoright_Click(object sender, EventArgs e)
        {
            if (dataCust.SelectedRows.Count > 0)
            {
                dataCust.SelectedRows[0].Cells["lv"].Value = 0;
                GlobalVar.CustPrivilage = 0;
                SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString);
                conn.Open();
                try
                {
                    string strDB = "update customer set lv = @lv where id = @id";
                    SqlCommand cmd = new SqlCommand(strDB, conn);
                    cmd.Parameters.AddWithValue("@lv", GlobalVar.CustPrivilage);
                    cmd.Parameters.AddWithValue("@id", dataCust.SelectedRows[0].Cells["id"].Value);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("停權成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("資料庫連接失敗: " + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("請選擇會員", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void ShowCust()
        {
            SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString);
            conn.Open();
            try
            {
                string strDB = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("資料庫連接失敗: " + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataCust_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
