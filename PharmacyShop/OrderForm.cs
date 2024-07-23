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
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=pharmacy;Integrated Security=True;Encrypt=False");
        private Form1 login;
        public OrderForm(Form1 login)
        {
            InitializeComponent();
            this.login = login;
        }

        public Drag drag;

        private void OrderForm_Load(object sender, EventArgs e)
        {
            drag = new Drag(this);
            drag.setPanel(pnlHome);
            ShowMilk();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("是否退出應用程式?", "退出", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void dataMilk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowMilk()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    string query = "select * from milk";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                    var ds = new DataSet();
                    sda.Fill(ds);
                    dataMilk.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("資料庫連接失敗: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
