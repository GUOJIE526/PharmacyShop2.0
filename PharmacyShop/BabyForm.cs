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
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=pharmacy;Integrated Security=True;Encrypt=False");

        List<string> listProd = new List<string>();
        List<int> listPdPrice = new List<int>();
        int qty = 0;
        int price = 0;
        int sumprice = 0;

        public BabyForm()
        {
            InitializeComponent();
        }

        public Drag drag;

        private void BabyForm_Load(object sender, EventArgs e)
        {
            drag = new Drag(this);
            drag.setPanel(pnlbaby);
            ShowMilk();
            ShowDiaper();

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


        private void ShowMilk()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    string query = "select * from milks";
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

        private void ShowDiaper()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    string query = "select * from diapers";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                    var ds = new DataSet();
                    sda.Fill(ds);
                    dataDiaper.DataSource = ds.Tables[0];
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

        private void dataMilk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataMilk.SelectedRows.Count > 0)
            {
                txtProd.Text = dataMilk.SelectedRows[0].Cells[1].Value.ToString();
                price = (int)dataMilk.SelectedRows[0].Cells[2].Value;
                UpdateSumPrice();
                //sumprice = price * qty;
                //lblSumPrice.Text = $"${sumprice}";
            }
        }

        private void dataDiaper_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataDiaper.SelectedRows.Count > 0)
            {
                txtProd.Text = dataDiaper.SelectedRows[0].Cells[1].Value.ToString();
                price = (int)dataDiaper.SelectedRows[0].Cells[2].Value;
                UpdateSumPrice();
                //sumprice = price * qty;
                //lblSumPrice.Text = $"${sumprice}";
            }
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

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            if (txtProd.Text != "")
            {
                ArrayList listProdAll = new ArrayList();
                listProd.Add(txtProd.Text);
                listPdPrice.Add(sumprice);
                listProdAll.Add(listProd);
                listProdAll.Add(qty);
                listProdAll.Add(listPdPrice);
                GlobalVar.listProductCollection.Add(listProdAll);
                
                //修改加入購物車後剩餘數量
                    
                MessageBox.Show("加入購物車成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProd.Text = "";
                txtqty.Text = qty.ToString();
                lblSumPrice.Text = "$0";
            }
            else
            {
                MessageBox.Show("請選擇要購買的產品", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProd.Text = "";
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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
