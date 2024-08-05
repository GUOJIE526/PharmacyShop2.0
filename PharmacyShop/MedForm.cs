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
using System.Windows.Documents;
using System.Windows.Forms;

namespace PharmacyShop
{
    public partial class MedForm : Form
    {
        List<int> listqty = new List<int>();
        List<string> listProdName = new List<string>();//value
        List<int> listProdPrice = new List<int>();//value
        List<int> listID = new List<int>();//key
        int ProdQty = 0;
        int qty = 0;
        int price = 0;
        int sumprice = 0;
        string ProdName = "";


        public MedForm()
        {
            InitializeComponent();
        }

        private void MedForm_Load(object sender, EventArgs e)
        {
            GetProdInfo();
            DisplayPicMode();

            qty = 1;
            txtqty.Text = qty.ToString();
        }

        void GetProdInfo()
        {
            try
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strsql = "select * from medicine";
                SqlCommand cmd = new SqlCommand(strsql, con);
                SqlDataReader rd = cmd.ExecuteReader();

                int count = 0;
                while (rd.Read())
                {
                    listID.Add((int)rd["id"]);
                    listProdName.Add((string)rd["name"]);
                    listProdPrice.Add((int)rd["price"]);
                    listqty.Add((int)rd["qty"]);
                    string img_name = (string)rd["photo"];
                    string FilePath = $"{GlobalVar.image_dir}\\{img_name}";
                    System.IO.FileStream fs = System.IO.File.OpenRead(FilePath);
                    Image imgProdPic = Image.FromStream(fs);

                    imglist.Images.Add(imgProdPic);
                    fs.Close();
                    count++;
                }
                rd.Close();
                con.Close();
                Console.WriteLine($"讀取了{count}筆資料");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void DisplayPicMode()
        {
            lsvMed.Clear();
            lsvMed.View = View.LargeIcon;//4種變化: LargeIcon, Tile, List, SmallIcon
            imglist.ImageSize = new Size(150, 150);
            lsvMed.LargeImageList = imglist; //LargeIcon, Tile
            lsvMed.SmallImageList = imglist; //SmallIcon, List

            for (int i = 0; i < listID.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Text = $"{listProdName[i]} {listProdPrice[i]}元";
                item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                item.Tag = listID[i];
                lsvMed.Items.Add(item);
            }
        }

        void displayListViewCellMode()
        {
            lsvMed.Clear();
            lsvMed.LargeImageList = null;
            lsvMed.SmallImageList = null;
            lsvMed.View = View.Details;
            lsvMed.Columns.Add("id", 150);
            lsvMed.Columns.Add("商品名稱", 250);
            lsvMed.Columns.Add("商品價格", 150);
            lsvMed.GridLines = true;
            lsvMed.FullRowSelect = true;

            for (int i = 0; i < listID.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                item.Tag = listID[i];
                item.Text = listID[i].ToString();
                item.SubItems.Add(listProdName[i]);
                item.SubItems.Add(listProdPrice[i].ToString());
                item.ForeColor = Color.DarkBlue;

                lsvMed.Items.Add(item);
            }
        }

        void CountSum()
        {
            if (lsvMed.SelectedItems.Count > 0)
            {
                sumprice = price * qty;
                lblSumPrice.Text = sumprice.ToString("C0");
            }
        }


        void showProdDesc()
        {
            if (lsvMed.SelectedItems.Count > 0)
            {
                SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString);
                conn.Open();
                try
                {
                    string strDB = "select * from medicine where id = @id";
                    SqlCommand cmd = new SqlCommand(strDB, conn);
                    cmd.Parameters.AddWithValue("@id", lsvMed.SelectedItems[0].Tag);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtid.Text = reader["id"].ToString();
                        txtprodname.Text = reader["name"].ToString();
                        txtprodQty.Text = reader["qty"].ToString();
                        price = (int)reader["price"];
                        txtprodprice.Text = price.ToString("C0");
                        CountSum();
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


        private void btnPic_Click(object sender, EventArgs e)
        {
            DisplayPicMode();
        }

        private void btnCell_Click(object sender, EventArgs e)
        {
            displayListViewCellMode();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            ProdName = txtprodname.Text;
            txtprodprice.Text = price.ToString();
            txtqty.Text = qty.ToString();

            if (!int.TryParse(txtprodQty.Text, out int prodQty) || prodQty == 0)
            {
                MessageBox.Show("產品已完售", "完售", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            int lastqty = prodQty - qty;

            if (lsvMed.SelectedItems.Count > 0)
            {
                ArrayList OrderItem = new ArrayList();
                OrderItem.Add(ProdName);
                OrderItem.Add(qty);
                OrderItem.Add(price);
                GlobalVar.listProductCollection.Add(OrderItem);

                SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString);
                conn.Open();
                try
                {
                    string strDB = "update medicine set qty = @qty where id = @id";
                    SqlCommand cmd = new SqlCommand(strDB, conn);
                    cmd.Parameters.AddWithValue("@qty", lastqty);
                    cmd.Parameters.AddWithValue("@id", lsvMed.SelectedItems[0].Tag);
                    Console.WriteLine(lsvMed.SelectedItems[0].Tag);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("商品購買成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtprodQty.Text = lastqty.ToString(); // 更新顯示的庫存數量
                        qty = 1;
                        txtqty.Text = qty.ToString();
                        CountSum();
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("資料庫接失敗: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void txtqty_TextChanged(object sender, EventArgs e)
        {
            if (txtqty.Text != "")
            {
                bool isCorrect = Int32.TryParse(txtqty.Text, out qty);
                if (isCorrect && qty > 0)
                {

                }
                else
                {
                    MessageBox.Show("輸入錯誤, 請重新輸入", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    qty = 1;
                    txtqty.Text = qty.ToString();
                }
                CountSum();
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            txtqty.Text = $"{++qty}";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (qty > 1)
            {
                txtqty.Text = $"{--qty}";
            }
        }

        private void lsvMed_ItemActivate_1(object sender, EventArgs e)
        {
            showProdDesc();
        }
    }
}
