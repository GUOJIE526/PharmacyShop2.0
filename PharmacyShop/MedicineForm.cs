using Guna.UI2.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyShop
{
    public partial class MedicineForm : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";

        public ProductClass product;
        Guna2DataGridView gridView1;
        Guna2DataGridView gridView2;
        List<string> listProd = new List<string>();
        List<int> listPdPrice = new List<int>();
        int qty = 0;
        int price = 0;
        int sumprice = 0;

        public MedicineForm()
        {
            InitializeComponent();
        }

        private void MedicineForm_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @"."; //伺服器名稱
            scsb.InitialCatalog = "pharmacy"; //資料庫名稱
            scsb.IntegratedSecurity = true; //Windows驗證: true
            strDBConnectionString = scsb.ConnectionString.ToString();

            product = new ProductClass();
            gridView1 = dataMed;
            product.ShowData("medicine", dataMed);
            gridView2 = dataMM;
            product.ShowData("mm", dataMM);

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

        private void dataMed_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataMed.SelectedRows.Count > 0)
            {
                txtProd.Text = dataMed.SelectedRows[0].Cells[1].Value.ToString();
                picProd.Image = Image.FromFile(dataMed.SelectedRows[0].Cells[4].Value.ToString());
                picProd.SizeMode = PictureBoxSizeMode.Zoom;

                try
                {
                    price = Convert.ToInt32(dataMed.SelectedRows[0].Cells[2].Value);
                    UpdateSumPrice();
                }
                catch (InvalidCastException)
                {
                    MessageBox.Show("沒有商品項目", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataMM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataMM.SelectedRows.Count > 0)
            {
                txtProd.Text = dataMM.SelectedRows[0].Cells[1].Value.ToString();
                picProd.Image = Image.FromFile(dataMM.SelectedRows[0].Cells[4].Value.ToString());
                picProd.SizeMode = PictureBoxSizeMode.Zoom;

                try
                {
                    price = Convert.ToInt32(dataMM.SelectedRows[0].Cells[2].Value);
                    UpdateSumPrice();
                }
                catch (InvalidCastException)
                {
                    MessageBox.Show("沒有商品項目", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataMed_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dataMed.Rows)
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

        private void dataMM_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dataMM.Rows)
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

        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            Close();
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
                if ((dataMed.SelectedRows.Count > 0) && (tabBaby.SelectedTab == Med))
                {
                    selectRow = dataMed.SelectedRows[0];
                    table = "medicine";//對應的資料表
                }
                else if ((dataMM.SelectedRows.Count > 0) && (tabBaby.SelectedTab == MM))
                {
                    selectRow = dataMM.SelectedRows[0];
                    table = "mm";//對應的資料表
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
    }
}
