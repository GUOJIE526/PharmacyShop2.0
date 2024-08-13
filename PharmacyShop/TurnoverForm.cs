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
    public partial class TurnoverForm : Form
    {
        ProductClass pd = new ProductClass();
        public TurnoverForm()
        {
            InitializeComponent();
        }

        private void TurnoverForm_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        void ShowData()
        {
            SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    string query = $"SELECT id 商品編號, name 商品名稱, price 總價, qty 數量, cust_id 會員編號, order_date 購買日期, finish_date 完成訂單日期 FROM finishitem";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DGVturnover.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("資料庫連接失敗: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString);
            conn.Open();
            try
            {
                string query = "select sum(price) as 營業額 from finishitem where (finish_date > @start) and (finish_date < @end)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@start", dTimeFrom.Value);
                cmd.Parameters.AddWithValue("@end", dtimeNow.Value);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int sumprice = (int)reader["營業額"];
                    txtTurnover.Text = sumprice.ToString("C0");
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("資料庫連接失敗: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString);
            conn.Open();
            try
            {
                string query = "select sum(price) as 營業額 from finishitem";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int sumprice = (int)reader["營業額"];
                    txtTurnover.Text = sumprice.ToString("C0");
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("資料庫連接失敗: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
