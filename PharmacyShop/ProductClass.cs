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
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";
        

        public void ShowData(string tableName, Guna2DataGridView gridView)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "pharmacy";
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ConnectionString.ToString();

            SqlConnection conn = new SqlConnection(strDBConnectionString);
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