using Guna.UI2.WinForms;
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
    public partial class ManagementForm : Form
    {
        OpenForm op = new OpenForm();
        ProductClass pd = new ProductClass();
        public Drag drag;
        Guna2DataGridView GDVBB = new Guna2DataGridView();
        Guna2DataGridView GDVBTY = new Guna2DataGridView();
        Guna2DataGridView GDVM = new Guna2DataGridView();
        private Form1 login;
        public ManagementForm(Form1 login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void ManagementForm_Load(object sender, EventArgs e)
        {
            drag = new Drag(this);
            drag.setPanel(pnlTop);
            GDVBB = dataBaby;
            GDVBTY = dataBeauty;
            GDVM = dataMed;
            pd.ShowData("baby", GDVBB);
            pd.ShowData("beauty", GDVBTY);
            pd.ShowData("medicine", GDVM);
            
        }

        private void btnCustSYS_Click(object sender, EventArgs e)
        {
            op.openForm(new CustSYSForm(), pnlMgr);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("是否要登出?", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (R == DialogResult.Yes)
            {
                login.Show();
                Close();
            }
        }

        private void btnOrdSYS_Click(object sender, EventArgs e)
        {

        }

        void UpdateProd(string tableName, Guna2DataGridView GDV)
        {
            int ID = 0;
            Int32.TryParse(txtid.Text, out ID);
            if ((ID > 0)&& (txtProdName.Text != "") && (txtPrice.Text != "") && (txtQty.Text != "") && (txtimg.Text != ""))
            {
                SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString);
                conn.Open();
                try
                {
                    string strDB = $"update {tableName} set name = @name, price = @price, qty = @qty, photo = @photo where id = @id";
                    SqlCommand cmd = new SqlCommand(strDB, conn);
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.Parameters.AddWithValue("@name", txtProdName.Text.Trim());
                    cmd.Parameters.AddWithValue("@price", txtPrice.Text.Trim());
                    cmd.Parameters.AddWithValue("@qty", txtQty.Text.Trim());
                    cmd.Parameters.AddWithValue("@photo", txtimg.Text.Trim());
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("商品修改成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pd.ShowData(tableName, GDV);
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("資料庫連接失敗: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if ((txtProdName.Text != "") && (txtPrice.Text != "") && (txtQty.Text != "") && (txtimg.Text != ""))
            {
                switch (tabctrl.SelectedTab.Name)
                {
                    case "tabBaby":
                        UpdateProd("baby", GDVBB);
                        break;
                    case "tabBeauty":
                        UpdateProd("beauty", GDVBTY);
                        break;
                    case "tabMed":
                        UpdateProd("medicine", GDVM);
                        break;
                    default:
                        MessageBox.Show("無法識別的選項卡", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
                MessageBox.Show("欄位未填寫", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void InsertProd(string tableName, Guna2DataGridView GDV)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            try
            {
                string query = $"Insert into {tableName} (name, price, qty, photo) values (@name, @price, @qty, @photo)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", txtProdName.Text.Trim());
                cmd.Parameters.AddWithValue("@price", txtPrice.Text.Trim());
                cmd.Parameters.AddWithValue("@qty", txtQty.Text.Trim());
                cmd.Parameters.AddWithValue("@photo", txtimg.Text.Trim());
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("商品上架成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pd.ShowData(tableName, GDV);
                }
                else
                {
                    MessageBox.Show("商品上架失敗", "失敗", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("資料庫連接失敗: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            if ((txtProdName.Text != "") && (txtPrice.Text != "") && (txtQty.Text != "") && (txtimg.Text != "")) 
            {
                switch (tabctrl.SelectedTab.Name)
                {
                    case "tabBaby":
                        InsertProd("baby", GDVBB);
                        break;
                    case "tabBeauty":
                        InsertProd("beauty", GDVBTY);
                        break;
                    case "tabMed":
                        InsertProd("medicine", GDVM);
                        break;
                    default:
                        MessageBox.Show("無法識別的選項卡", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
                MessageBox.Show("欄位未填寫", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void DeleteProd(string tableName, Guna2DataGridView GDV, int ID)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            try
            {
                string query = $"delete from {tableName} where id = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", ID);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("商品下架成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pd.ShowData(tableName, GDV);
                }
                else
                {
                    MessageBox.Show("商品下架失敗", "失敗", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("資料庫連接失敗: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ID = 0;
            Int32.TryParse(txtid.Text, out ID);
            if ((txtProdName.Text != "") && (txtPrice.Text != "") && (txtQty.Text != "") && (txtimg.Text != ""))
            {
                switch (tabctrl.SelectedTab.Name)
                {
                    case "tabBaby":
                        DeleteProd("baby", GDVBB, ID);
                        break;
                    case "tabBeauty":
                        DeleteProd("beauty", GDVBTY, ID);
                        break;
                    case "tabMed":
                        DeleteProd("medicine", GDVM, ID);
                        break;
                    default:
                        MessageBox.Show("無法識別的選項卡", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
                MessageBox.Show("欄位未填寫", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void DisplayMember(string tableName, int myid)
        {
            SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString);
            conn.Open();
            try
            {
                string query = $"select * from {tableName} where id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", myid);
                SqlDataReader re = cmd.ExecuteReader();
                if (re.Read())
                {
                    txtid.Text = re["id"].ToString();
                    txtProdName.Text = re["name"].ToString();
                    txtPrice.Text = re["price"].ToString();
                    txtQty.Text = re["qty"].ToString() ;
                    txtimg.Text = re["photo"].ToString();
                    Console.WriteLine("資料顯示成功");
                }
                else
                {
                    Console.WriteLine("未找到資料");
                }
                re.Close();
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("資料庫連接失敗: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataBaby_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.RowIndex < dataBaby.RowCount))
            {
                string strID = dataBaby.Rows[e.RowIndex].Cells[0].Value.ToString();
                int ID = 0;
                Int32.TryParse(strID, out ID);
                DisplayMember("baby", ID);
            }
        }

        private void dataBeauty_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.RowIndex < dataBeauty.RowCount))
            {
                string strID = dataBeauty.Rows[e.RowIndex].Cells[0].Value.ToString();
                int ID = 0;
                Int32.TryParse(strID, out ID);
                DisplayMember("beauty", ID);
            }
        }

        private void dataMed_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.RowIndex < dataMed.RowCount))
            {
                string strID = dataMed.Rows[e.RowIndex].Cells[0].Value.ToString();
                int ID = 0;
                Int32.TryParse(strID, out ID);
                DisplayMember("medicine", ID);
            }
        }

        void txtClear()
        {
            txtid.Clear();
            txtProdName.Clear();
            txtPrice.Clear();
            txtimg.Clear();
            txtQty.Clear();
        }
        
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClear();
        }
    }
}
