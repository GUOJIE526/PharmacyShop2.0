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
    public partial class BeautyForm : Form
    {
        List<string> listProdName = new List<string>();//value
        List<int> listProdPrice = new List<int>();//value
        List<int> listID = new List<int>();//key
        int loadid = 0;
        int qty = 0;
        int price = 0;
        int sumprice = 0;

        public BeautyForm()
        {
            InitializeComponent();
        }

        private void BeautyForm_Load(object sender, EventArgs e)
        {
            GetProdInfo();
            DisplayPicMode();
            qty = 1;
            txtqty.Text = qty.ToString();
            //price = listProdPrice[lsvBeauty.SelectedIndices];
        }

        void GetProdInfo()
        {
            try
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strsql = "select * from beauty";
                SqlCommand cmd = new SqlCommand(strsql, con);
                SqlDataReader rd = cmd.ExecuteReader();

                int count = 0;
                while (rd.Read())
                {
                    listID.Add((int)rd["id"]);
                    listProdName.Add((string)rd["name"]);
                    listProdPrice.Add((int)rd["price"]);
                    string img_name = (string)rd["photo"];
                    string FilePath = $"{GlobalVar.image_dir}\\{img_name}";
                    //Console.WriteLine(FilePath);
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
            lsvBeauty.Clear();
            lsvBeauty.View = View.LargeIcon;//4種變化: LargeIcon, Tile, List, SmallIcon
            imglist.ImageSize = new Size(150, 150);
            lsvBeauty.LargeImageList = imglist; //LargeIcon, Tile
            lsvBeauty.SmallImageList = imglist; //SmallIcon, List

            for (int i = 0; i < listID.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Text = $"{listProdName[i]} {listProdPrice[i]}元";
                item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                item.Tag = listID[i];
                lsvBeauty.Items.Add(item);
            }
        }

        void displayListViewCellMode()
        {
            lsvBeauty.Clear();
            lsvBeauty.LargeImageList = null;
            lsvBeauty.SmallImageList = null;
            lsvBeauty.View = View.Details;
            lsvBeauty.Columns.Add("id", 150);
            lsvBeauty.Columns.Add("商品名稱", 250);
            lsvBeauty.Columns.Add("商品價格", 150);
            lsvBeauty.GridLines = true;
            lsvBeauty.FullRowSelect = true;

            for (int i = 0; i < listID.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                item.Tag = listID[i];
                item.Text = listID[i].ToString();
                item.SubItems.Add(listProdName[i]);
                item.SubItems.Add(listProdPrice[i].ToString());
                item.ForeColor = Color.DarkBlue;

                lsvBeauty.Items.Add(item);
            }
        }

        void CountSum()
        {
            if (lsvBeauty.SelectedItems.Count > 0)
            {
                sumprice = price * qty;
                lblSumprice.Text = sumprice.ToString("C");
            }
        }

        void showProdDesc()
        {
            if (lsvBeauty.SelectedItems.Count > 0)
            {
                SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString);
                conn.Open();
                try
                {
                    string strDB = "select * from beauty where id = @id";
                    SqlCommand cmd = new SqlCommand(strDB, conn);
                    cmd.Parameters.AddWithValue("@id", lsvBeauty.SelectedItems[0].Tag);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtid.Text = reader["id"].ToString();
                        txtprodname.Text = reader["name"].ToString();
                        price = (int)reader["price"];
                        txtprodprice.Text = price.ToString("C");
                        CountSum();
                    }
                    reader.Close();
                    conn.Close();
                }
                catch(Exception ex)
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

        }

        private void lsvBeauty_ItemActivate(object sender, EventArgs e)
        {
            showProdDesc();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            txtqty.Text = $"{++qty}";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if(qty > 1)
            {
                txtqty.Text = $"{--qty}";
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
    }
}
