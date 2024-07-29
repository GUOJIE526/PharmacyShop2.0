using Guna.UI2.WinForms;
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
    public partial class BabyForm : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";
        Guna2DataGridView gridView1 = new Guna2DataGridView();
        Guna2DataGridView gridView2 = new Guna2DataGridView();
        int qty = 0;
        int price = 0;
        int sumprice = 0;

        public BabyForm()
        {
            InitializeComponent();
        }

        public ProductClass product = new ProductClass(); 

        private void BabyForm_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @"."; //伺服器名稱
            scsb.InitialCatalog = "pharmacy"; //資料庫名稱
            scsb.IntegratedSecurity = true; //Windows驗證: true
            strDBConnectionString = scsb.ConnectionString.ToString();

            gridView1 = dataMilk;
            product.ShowData("milk", gridView1);
            gridView2 = dataDiaper;
            product.ShowData("diaper", gridView2);

            //預設
            qty = 1;
            txtqty.Text = qty.ToString();
            lblSumPrice.Text = "$0";
        }

        private void UpdateSumPrice()
        {
            sumprice = price * qty;
            lblSumPrice.Text = $"${sumprice}";
        }

        private void dataMilk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataMilk.SelectedRows.Count > 0)
            {
                txtProd.Text = dataMilk.SelectedRows[0].Cells[1].Value.ToString();
                picProd.Image = Image.FromFile(dataMilk.SelectedRows[0].Cells[4].Value.ToString());
                picProd.SizeMode = PictureBoxSizeMode.Zoom;
                try
                {
                    price = Convert.ToInt32(dataMilk.SelectedRows[0].Cells[2].Value);
                    UpdateSumPrice();
                }
                catch (InvalidCastException)
                {
                    MessageBox.Show("沒有商品項目", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataDiaper_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataDiaper.SelectedRows.Count > 0)
            {
                txtProd.Text = dataDiaper.SelectedRows[0].Cells[1].Value.ToString();
                picProd.Image = Image.FromFile(dataDiaper.SelectedRows[0].Cells[4].Value.ToString());
                picProd.SizeMode = PictureBoxSizeMode.Zoom;

                try
                {
                    price = Convert.ToInt32(dataDiaper.SelectedRows[0].Cells[2].Value);
                    UpdateSumPrice();
                }
                catch (InvalidCastException)
                {
                    MessageBox.Show("沒有商品項目", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataMilk_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dataMilk.Rows)
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

        private void dataDiaper_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dataDiaper.Rows)
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

        private void txtqty_TextChanged_1(object sender, EventArgs e)
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

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            txtqty.Text = $"{++qty}";
            UpdateSumPrice();
        }

        private void btnMinus_Click_1(object sender, EventArgs e)
        {
            if (qty > 1)
            {
                txtqty.Text = $"{--qty}";
                UpdateSumPrice();
            }
        }

        private void btnAddCart_Click_1(object sender, EventArgs e)
        {
            if (txtProd.Text != "")
            {//挑選中的row

                DataGridViewRow selectRow = null;
                string table = "";
                if ((dataMilk.SelectedRows.Count > 0) && (tabBaby.SelectedTab == Milk))
                {
                    selectRow = dataMilk.SelectedRows[0];
                    table = "milk";//對應的資料表
                }
                else if ((dataDiaper.SelectedRows.Count > 0) && (tabBaby.SelectedTab == Diaper))
                {
                    selectRow = dataDiaper.SelectedRows[0];
                    table = "diaper";//對應的資料表
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

                    // 檢查裡面有沒有重複商品，有的話qty+qty
                    bool found = false;
                    foreach (ArrayList item in GlobalVar.listProductCollection)
                    {
                        if (item[0].ToString() == txtProd.Text)
                        {
                            item[1] = (int)item[1] + qty;
                            item[2] = (int)item[2] + sumprice;
                            found = true;
                            break;
                        }
                    }
                    //沒有重複再加進去
                    if (!found)
                    {
                        ArrayList listProdAll = new ArrayList();
                        listProdAll.Add(txtProd.Text);
                        listProdAll.Add(qty);
                        listProdAll.Add(sumprice);
                        GlobalVar.listProductCollection.Add(listProdAll);
                    }

                    int ProdID = (int)selectRow.Cells["id"].Value;
                    string updatequery = $"update {table} set qty = qty - @qty where id = @ProdID";

                    SqlConnection conn = new SqlConnection(strDBConnectionString);
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

        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
