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
    public partial class CartForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=pharmacy;Integrated Security=True;Encrypt=False");

        public CartForm()
        {
            InitializeComponent();
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            ShowCart();
        }

        private void ShowCart()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    string query = "select * from cart";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                    var ds = new DataSet();
                    sda.Fill(ds);
                    dataCart.DataSource = ds.Tables[0];
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


        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
