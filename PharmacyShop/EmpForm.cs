using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace PharmacyShop
{
    public partial class EmpForm : Form
    {
        public EmpForm()
        {
            InitializeComponent();
        }

        private void EmpForm_Load(object sender, EventArgs e)
        {
            showData();

            cbxSearch.Items.Add("name");
            cbxSearch.Items.Add("phone");
            cbxSearch.Items.Add("email");
            cbxSearch.SelectedIndex = 0;
        }

        void showData()
        {
            SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString);
            conn.Open();
            try
            {
                string query = "select id 員工編號, name 姓名, phone 電話, email 信箱, address 地址, lv 員工等級, createdate 到職日, updatetime 異動日期 from employee";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataEmp.DataSource = dt;
                } 
                reader.Close();
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("資料庫連接失敗: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void btnEmpUpdate_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(txtid.Text, out intID);
            if ((txtUser.Text != "") && (intID > 0))
            {
                SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString);
                conn.Open();
                try
                {
                    string query = "update employee set name = @name, phone = @phone, email = @email, address = @address, lv = @lv, updatetime = @update where id = @id";
                    DateTime date = DateTime.Today;
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtUser.Text.Trim());
                    cmd.Parameters.AddWithValue("@phone", txtphone.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@lv", txtLV.Text.Trim());
                    cmd.Parameters.AddWithValue("@update", date);
                    cmd.Parameters.AddWithValue("@id", intID);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("資料修改成功", "修改", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showData();
                    }
                    conn.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("資料庫連接失敗: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(txtid.Text, out intID);
            int pass = 1234;
            if ((txtUser.Text != "") && (intID > 0))
            {
                SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString);
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                DateTime date = DateTime.Today;
                try
                {
                    string ship = "delete from employee where id = @id";
                    SqlCommand cmdhis = new SqlCommand(ship, conn, trans);
                    cmdhis.Parameters.AddWithValue("@id", intID);
                    int rows = cmdhis.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        string finish = "insert into customer (name, password, phone, email, address, lv, updatetime) values (@name, @pass, @phone, @email, @address, @lv, @update)";
                        SqlCommand cmd = new SqlCommand(finish, conn, trans);
                        cmd.Parameters.AddWithValue("@name", txtUser.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", pass);
                        cmd.Parameters.AddWithValue("phone", txtphone.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@lv", txtLV.Text.Trim());
                        cmd.Parameters.AddWithValue("@update", date);
                        cmd.ExecuteNonQuery();

                        trans.Commit();
                        MessageBox.Show($"{txtUser.Text}掰掰!!", "資遣", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showData();
                    }
                    else
                    {
                        MessageBox.Show("刪除訂單失敗，無法找到對應的訂單。", "失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        trans.Rollback();
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("資料庫連接失敗: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtkeyword.Text != "")
            {
                string strMsg = cbxSearch.SelectedItem.ToString();
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strDB = $"select id as 員工編號, name as 姓名, phone as 電話, email as 信箱, address as 地址, lv as 員工等級 from employee where {strMsg} like @keyword";
                SqlCommand cmd = new SqlCommand(strDB, con);
                cmd.Parameters.AddWithValue("@keyword", $"%{txtkeyword.Text.Trim()}%");
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataEmp.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("查無此人", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                reader.Close();
                con.Close();
            }

        }

        void ShowEmp(int ID)
        {
            SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString);
            conn.Open();
            try
            {
                string query = "select * from employee where id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", ID);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtid.Text = reader["id"].ToString();
                    txtUser.Text = reader["name"].ToString();
                    txtphone.Text = reader["phone"].ToString();
                    txtEmail.Text = reader["email"].ToString();
                    txtAddress.Text = reader["address"].ToString();
                    txtLV.Text = reader["lv"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("資料庫連接失敗: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.RowIndex < dataEmp.RowCount))
            {
                string id = dataEmp.Rows[e.RowIndex].Cells[0].Value.ToString();
                int ID = 0;
                Int32.TryParse(id, out ID);
                ShowEmp(ID);
            }
        }
    }
}
