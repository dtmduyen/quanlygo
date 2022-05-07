using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PhanMemVu
{
    public partial class frmCaiDatTK : Form
    {
        string Scon = "Data Source=HNS\\HUNGNGUYEN;Initial Catalog=CT_LuongTuong;Integrated Security=True";
        public frmCaiDatTK()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form CaiDat = new frmMain();
            CaiDat.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtTK.Text = "";
            txtMK.Text = "";
            txtTK.Focus();
            txtTK.Enabled = true;
        }

        private void frmCaiDatTK_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Scon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi khi kết nối DB!");
            }
            string sQuery = "select username as N'Tên đăng nhập', pass as N'Mật khẩu' from dbo.fShowTK()";
            SqlDataAdapter adt = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adt.Fill(ds, "TAIKHOAN");
            dataGridView1.DataSource = ds.Tables["TAIKHOAN"];
            con.Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTK.Text = dataGridView1.Rows[e.RowIndex].Cells["Tên đăng nhập"].Value.ToString();
            txtMK.Text = dataGridView1.Rows[e.RowIndex].Cells["Mật khẩu"].Value.ToString();
            txtTK.Enabled = false;
           
        }

        private void doiMK_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Scon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtTK.Text != "" && txtMK.Text != "")
            {
                var cmd = new SqlCommand("spUpdatePassword", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = txtTK.Text;
                cmd.Parameters.Add("@pass", SqlDbType.NVarChar).Value = txtMK.Text;

                cmd.ExecuteNonQuery();
                frmCaiDatTK_Load(sender, e);
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();

        }

        private void luu_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Scon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtTK.Text != "" && txtMK.Text != "")
            {
                var cmd = new SqlCommand("spAddTK", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = txtTK.Text;
                cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = txtMK.Text;

                cmd.ExecuteNonQuery();
                frmCaiDatTK_Load(sender, e);
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }

        private void xoaTK_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Scon);
            try
            {
                con.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi khi kết nối DB!");
            }
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn chắc chắn muốn Xóa?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                
                if (txtTK.Text != "" && txtMK.Text != "")
                {
                    var cmd = new SqlCommand("spDeleteTK", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = txtTK.Text;

                    cmd.ExecuteNonQuery();
                    frmCaiDatTK_Load(sender, e);
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                con.Close();
            }
        }
        public void HienThi()
        {
            SqlConnection con = new SqlConnection(Scon);
            try
            {
                con.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi khi kết nối DB!");
            }
            string Select = "select username as N'Tên đăng nhập', pass as N'Mật khẩu' from dbo.fShowTK()";
            SqlCommand cmd = new SqlCommand(Select, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
