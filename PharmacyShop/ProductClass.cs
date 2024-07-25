using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PharmacyShop
{
    public class ProductClass
    {
        protected SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=pharmacy;Integrated Security=True;Encrypt=False");
        protected Guna2DataGridView gridView;
        protected int TotalPrice = 0;
        protected Label lblSumPrice;

        protected void ShowData(string tableName)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    string query = $"SELECT * FROM {tableName}";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                    var ds = new DataSet();
                    sda.Fill(ds);
                    gridView.DataSource = ds.Tables[0];

                    foreach (DataGridViewColumn col in gridView.Columns)
                    {
                        if (col is DataGridViewImageColumn imgcol)
                        {
                            imgcol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                        }
                    }
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

        protected void UpdateSumPrice(int price)
        {
            TotalPrice += price;
            lblSumPrice.Text = TotalPrice.ToString();
        }

        protected void GridView_CellContentClick(object sender, DataGridViewCellEventArgs e, TextBox txtProd)
        {
            if (gridView.SelectedRows.Count > 0 && gridView.SelectedRows[0].Cells[1] != null && gridView.SelectedRows[0].Cells[2] != null && gridView.SelectedRows[0].Cells[3] != null)
            {
                txtProd.Text = gridView.SelectedRows[0].Cells[2].Value.ToString();
                try
                {
                    int price = Convert.ToInt32(gridView.SelectedRows[0].Cells[3].Value);
                    UpdateSumPrice(price);
                }
                catch (InvalidCastException)
                {
                    MessageBox.Show("沒有商品項目", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        protected void GridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (row.Cells["qty"].Value != null)
                {
                    int quantity = Convert.ToInt32(row.Cells["qty"].Value);
                    if (quantity <= 0)
                    {
                        row.Cells["name"].Style.ForeColor = System.Drawing.Color.Red;
                        row.Cells["price"].Style.ForeColor = System.Drawing.Color.Red;
                        row.Cells["qty"].Style.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
        }
    }
}