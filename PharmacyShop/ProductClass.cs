using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Windows.Documents;


namespace PharmacyShop
{
    public class ProductClass
    {
        public void ShowData(string tableName, Guna2DataGridView gridView)
        {

            SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    string query = $"SELECT * FROM {tableName}";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        gridView.DataSource = dt;
                        gridView.Columns[4].Visible = false;
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