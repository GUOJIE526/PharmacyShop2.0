﻿using System;
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
        List<string> listProdName = new List<string>();//value
        List<int> listProdPrice = new List<int>();//value
        List<int> listID = new List<int>();//key

        public BabyForm()
        {
            InitializeComponent();
        }

        private void BabyForm_Load(object sender, EventArgs e)
        {
            GetProdInfo();
            DisplayPicMode();
        }

        void GetProdInfo()
        {
            try
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strsql = "select * from baby";
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
            lsvBaby.Clear();
            lsvBaby.View = View.LargeIcon;//4種變化: LargeIcon, Tile, List, SmallIcon
            imglist.ImageSize = new Size(150, 150);
            lsvBaby.LargeImageList = imglist; //LargeIcon, Tile
            lsvBaby.SmallImageList = imglist; //SmallIcon, List

            for (int i = 0; i < listID.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Text = $"{listProdName[i]} {listProdPrice[i]}元";
                item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                item.Tag = listID[i];
                lsvBaby.Items.Add(item);
            }
        }

        void displayListViewCellMode()
        {
            lsvBaby.Clear();
            lsvBaby.LargeImageList = null;
            lsvBaby.SmallImageList = null;
            lsvBaby.View = View.Details;
            lsvBaby.Columns.Add("id", 150);
            lsvBaby.Columns.Add("商品名稱", 250);
            lsvBaby.Columns.Add("商品價格", 150);
            lsvBaby.GridLines = true;
            lsvBaby.FullRowSelect = true;

            for (int i = 0; i < listID.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                item.Tag = listID[i];
                item.Text = listID[i].ToString();
                item.SubItems.Add(listProdName[i]);
                item.SubItems.Add(listProdPrice[i].ToString());
                item.ForeColor = Color.DarkBlue;

                lsvBaby.Items.Add(item);
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
    }
}
