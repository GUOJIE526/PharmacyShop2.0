using System;
using System.Collections;
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
    public partial class BeautyForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=pharmacy;Integrated Security=True;Encrypt=False");

        List<string> listProd = new List<string>();
        List<int> listPdPrice = new List<int>();
        int qty = 0;
        int price = 0;
        int sumprice = 0;

        public BeautyForm()
        {
            InitializeComponent();
        }

        private void UpdateSumPrice()
        {
            sumprice = price * qty;
            lblSumPrice.Text = $"${sumprice}";
            
        }

        private void ShowBeauty()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    string query = "select * from beauty";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                    var ds = new DataSet();
                    sda.Fill(ds);
                    dataBeauty.DataSource = ds.Tables[0];

                    foreach (DataGridViewColumn col in dataBeauty.Columns)
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

        private void ShowPerfume()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    string query = "select * from perfume";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                    var ds = new DataSet();
                    sda.Fill(ds);
                    dataPerfume.DataSource = ds.Tables[0];

                    foreach (DataGridViewColumn col in dataPerfume.Columns)
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

        private void BeautyForm_Load(object sender, EventArgs e)
        {
            ShowBeauty();
            ShowPerfume();
            AdjustDataGridViewSettings();

            //預設
            qty = 1;
            txtqty.Text = qty.ToString();
            lblSumPrice.Text = "$0";

        }

        private void AdjustDataGridViewSettings()
        {
            // 調整間距和樣式
            dataBeauty.RowTemplate.Height += 50; // 調整行高以增加行間距

            dataPerfume.RowTemplate.Height += 50;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtqty_TextChanged(object sender, EventArgs e)
        {
            if (txtqty.Text != "")
            {
                bool isqty = Int32.TryParse(txtqty.Text, out qty);

                if ((isqty) && (qty > 0))
                {
                    UpdateSumPrice();
                }
                else
                {
                    MessageBox.Show("請輸入正確數量", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    qty = 1;
                    txtqty.Text = qty.ToString();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtqty.Text = $"{++qty}";
            UpdateSumPrice();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (qty > 1)
            {
                txtqty.Text = $"{--qty}";
                UpdateSumPrice();
            }

        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            if (txtProd.Text != "")
            {//挑選中的row

                DataGridViewRow selectRow = null;
                string table = "";
                if ((dataBeauty.SelectedRows.Count > 0) && (tabBeauty.SelectedTab == Beauty))
                {
                    selectRow = dataBeauty.SelectedRows[0];
                    table = "beauty";//對應的資料表
                }
                else if ((dataPerfume.SelectedRows.Count > 0) && (tabBeauty.SelectedTab == Perfume))
                {
                    selectRow = dataPerfume.SelectedRows[0];
                    table = "perfume";//對應的資料表
                }

                if (selectRow != null && !string.IsNullOrEmpty(table))
                {
                    int availableQty = (int)selectRow.Cells["qty"].Value;
                    //MessageBox.Show($"目前的數量: {availableQty}");
                    if (availableQty <= 0)
                    {
                        MessageBox.Show("產品已售盡", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtProd.Text = "";
                        return;
                    }

                    // 添加商品到購物車
                    ArrayList listProdAll = new ArrayList();
                    listProd.Add(txtProd.Text);
                    listPdPrice.Add(sumprice);
                    listProdAll.Add(listProd);
                    listProdAll.Add(qty);
                    listProdAll.Add(listPdPrice);
                    GlobalVar.listProductCollection.Add(listProdAll);

                    int ProdID = (int)selectRow.Cells["id"].Value;
                    string updatequery = $"update {table} set qty = qty - @qty where id = @ProdID";

                    try
                    {
                        if (conn.State != ConnectionState.Open)
                        {
                            conn.Open();
                        }
                        SqlCommand cmd = new SqlCommand(updatequery, conn);
                        cmd.Parameters.AddWithValue("@qty", qty);
                        cmd.Parameters.AddWithValue("@ProdID", ProdID);
                        cmd.ExecuteNonQuery();

                        selectRow.Cells["qty"].Value = availableQty - qty;//刷新頁面數量

                        MessageBox.Show("加入購物車成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtProd.Text = "";
                        txtqty.Text = "1"; // 重置數量為 1
                        lblSumPrice.Text = "$0";

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("更新商品數量失敗: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("未選擇商品", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("請選擇要購買的產品", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProd.Text = "";
            }

        }

        private void dataBeauty_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataBeauty.SelectedRows.Count > 0 && dataBeauty.SelectedRows[0].Cells[1] != null && dataBeauty.SelectedRows[0].Cells[2] != null && dataBeauty.SelectedRows[0].Cells[3] != null)
            {
                txtProd.Text = dataBeauty.SelectedRows[0].Cells[2].Value.ToString();
                try
                {
                    price = Convert.ToInt32(dataBeauty.SelectedRows[0].Cells[3].Value);
                    UpdateSumPrice();
                }
                catch (InvalidCastException)
                {
                    MessageBox.Show("沒有商品項目", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataPerfume_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataPerfume.SelectedRows.Count > 0 && dataPerfume.SelectedRows[0].Cells[1] != null && dataPerfume.SelectedRows[0].Cells[2] != null && dataPerfume.SelectedRows[0].Cells[3] != null)
            {
                txtProd.Text = dataPerfume.SelectedRows[0].Cells[2].Value.ToString();
                try
                {
                    price = Convert.ToInt32(dataPerfume.SelectedRows[0].Cells[3].Value);
                    UpdateSumPrice();
                }
                catch (InvalidCastException)
                {
                    MessageBox.Show("沒有商品項目", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataBeauty_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dataBeauty.Rows)
            {
                if (row.Cells["qty"].Value != null)
                {
                    int quantity = Convert.ToInt32(row.Cells["qty"].Value);
                    if (quantity <= 0)
                    {
                        row.Cells["name"].Style.ForeColor = Color.Red;
                        row.Cells["price"].Style.ForeColor = Color.Red;
                        row.Cells["qty"].Style.ForeColor = Color.Red;
                    }
                }
            }

        }

        private void dataPerfume_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dataPerfume.Rows)
            {
                if (row.Cells["qty"].Value != null)
                {
                    int quantity = Convert.ToInt32(row.Cells["qty"].Value);
                    if (quantity <= 0)
                    {
                        row.Cells["name"].Style.ForeColor = Color.Red;
                        row.Cells["price"].Style.ForeColor = Color.Red;
                        row.Cells["qty"].Style.ForeColor = Color.Red;
                    }
                }
            }

        }
    }
}
