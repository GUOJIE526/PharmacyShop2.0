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
        private SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=pharmacy;Integrated Security=True;Encrypt=False");

        public void ShowData(string tableName, Guna2DataGridView gridView)
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
    }
}