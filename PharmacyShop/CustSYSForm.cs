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
    public partial class CustSYSForm : Form
    {
        ProductClass pd = new ProductClass();
        Guna2DataGridView DGV = new Guna2DataGridView();
        int DGVqty = 0;
        public CustSYSForm()
        {
            InitializeComponent();
        }

        private void CustSYSForm_Load(object sender, EventArgs e)
        {
            DGV = dataCust;
            pd.ShowData("customer", DGV);

            cbxSearch.Items.Add("name");
            cbxSearch.Items.Add("phone");
            cbxSearch.Items.Add("email");
            cbxSearch.SelectedIndex = 0;
        }

        void ColClear()
        {
            txtid.Clear();
            txtUser.Clear();
            txtphone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
        }

        private void btnDrop_Click(object sender, EventArgs e)
        {
            ColClear();
            if (dataCust.SelectedRows.Count > 0)
            {
                SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString);
                conn.Open();
                try
                {
                    string strDB = "delete from customer where id = @id";
                    SqlCommand cmd = new SqlCommand(strDB, conn);
                    cmd.Parameters.AddWithValue("@id", dataCust.SelectedRows[0].Cells["id"].Value);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("資料刪除成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pd.ShowData("customer", DGV);
                    }
                    conn.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("資料庫連接失敗: " + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNoright_Click(object sender, EventArgs e)
        {
            if (dataCust.SelectedRows.Count > 0)
            {
                dataCust.SelectedRows[0].Cells["lv"].Value = 2;
                GlobalVar.CustPrivilage = 2;
                SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString);
                conn.Open();
                try
                {
                    string strDB = "update customer set lv = @lv where id = @id";
                    SqlCommand cmd = new SqlCommand(strDB, conn);
                    cmd.Parameters.AddWithValue("@lv", GlobalVar.CustPrivilage);
                    cmd.Parameters.AddWithValue("@id", dataCust.SelectedRows[0].Cells["id"].Value);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("停權成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("資料庫連接失敗: " + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("請選擇會員", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void ShowCust(int myid)
        {
            SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString);
            conn.Open();
            try
            {
                string strDB = "select * from customer where id = @id";
                SqlCommand cmd = new SqlCommand(strDB, conn);
                cmd.Parameters.AddWithValue("@id", myid);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtid.Text = reader["id"].ToString();
                    txtUser.Text = reader["name"].ToString();
                    txtphone.Text = reader["phone"].ToString();
                    txtEmail.Text = reader["email"].ToString();
                    txtAddress.Text = reader["address"].ToString();
                    txtLV.Text = reader["lv"].ToString() ;
                }
                else
                {
                    MessageBox.Show("查無此人", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("資料庫連接失敗: " + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtkeyword.Text != "")
            {
                string strMsg = cbxSearch.SelectedItem.ToString();
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strDB = $"select id as 會員編號, name as 姓名, phone as 電話, email as 信箱, address as 地址, lv as 會員等級 from customer where {strMsg} like @keyword";
                SqlCommand cmd = new SqlCommand(strDB, con);
                cmd.Parameters.AddWithValue("@keyword", $"%{txtkeyword.Text.Trim()}%");
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataCust.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("查無此人", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                reader.Close();
                con.Close();
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            pd.ShowData("customer", DGV);
        }

        private void btnCustUpdate_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(txtid.Text, out intID);

            if ((intID > 0) && (txtUser.Text != "") && (txtEmail.Text != ""))
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                try
                {
                    string strDB = "update customer set name = @name, phone = @phone, email = @email, address = @address where id = @id";
                    SqlCommand cmd = new SqlCommand(strDB, con);
                    cmd.Parameters.AddWithValue("@id", txtid.Text);
                    cmd.Parameters.AddWithValue("@name", txtUser.Text.Trim());
                    cmd.Parameters.AddWithValue("@phone", txtphone.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("修改成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pd.ShowData("customer", DGV);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("資料庫連接失敗: " + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            if (dataCust.SelectedRows.Count > 0)
            {
                dataCust.SelectedRows[0].Cells["lv"].Value = 1;
                GlobalVar.CustPrivilage = 1;
                SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString);
                conn.Open();
                try
                {
                    string strDB = "update customer set lv = @lv where id = @id";
                    SqlCommand cmd = new SqlCommand(strDB, conn);
                    cmd.Parameters.AddWithValue("@lv", GlobalVar.CustPrivilage);
                    cmd.Parameters.AddWithValue("@id", dataCust.SelectedRows[0].Cells["id"].Value);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("回復成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("資料庫連接失敗: " + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("請選擇會員", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataCust_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataCust.SelectedRows.Count > 0)
            {
                string strID = dataCust.SelectedRows[0].Cells[0].Value.ToString();
                int selectID = 0;
                Int32.TryParse(strID, out selectID);
                ShowCust(selectID);
            }
        }
    }
}
