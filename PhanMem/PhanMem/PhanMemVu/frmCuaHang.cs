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

namespace PhanMemVu
{
    public partial class frmCuaHang : Form
    {
        string Scon = "Data Source=HNS\\HUNGNGUYEN;Initial Catalog=CT_LuongTuong;Integrated Security=True";
        public frmCuaHang()
        {
            InitializeComponent();
        }

        private void frmCuaHang_Load(object sender, EventArgs e)
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
            string sQuery = "exec spShowCuaHang";
            SqlDataAdapter adt = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adt.Fill(ds, "CUAHANG");
            dataGridView1.DataSource = ds.Tables["CUAHANG"];
            con.Close();
        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            txtDiaChi.Text = "";
            txtGC.Text = "";
            txtMaNV.Text = "";
            txtMaThue.Text = "";
            txtSDT.Text = "";
            txtSTK.Text = "";
            txtTenNV.Text = "";
            txtTenNH.Text = "";
            txtTimKiem.Text = "";
            frmCuaHang_Load(sender, e);
        }

        private void btSuaHD_Click(object sender, EventArgs e)
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
            if (txtTenNV.Text != "" && txtMaNV.Text != "" && txtDiaChi.Text !="" && txtMaThue.Text != "" && txtSDT.Text !="")
            {
                var cmd = new SqlCommand("spUpdateCuaHang", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = txtMaNV.Text;
                cmd.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value = txtTenNV.Text;
                cmd.Parameters.Add("@CH_MaThue", SqlDbType.NVarChar).Value = txtMaThue.Text;
                cmd.Parameters.Add("@CH_SDT", SqlDbType.NVarChar).Value = txtSDT.Text;
                cmd.Parameters.Add("@CH_DiaChi", SqlDbType.NVarChar).Value = txtDiaChi.Text;
                cmd.Parameters.Add("@CH_SoTK", SqlDbType.VarChar).Value = txtSTK.Text;
                cmd.Parameters.Add("@CH_TenNH", SqlDbType.NVarChar).Value = txtTenNH.Text;
                //cmd.Parameters.Add("@CH_GC", SqlDbType.NVarChar).Value = txtGC.Text;

                cmd.ExecuteNonQuery();
                frmCuaHang_Load(sender, e);
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }

        private void btThemHDB_Click(object sender, EventArgs e)
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
            if (txtTenNV.Text != "" )
            {
                var cmd = new SqlCommand("spAddCuaHang", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value = txtTenNV.Text;

                cmd.ExecuteNonQuery();
                frmCuaHang_Load(sender, e);
                MessageBox.Show("Tạo mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm mới thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }

        private void xoa_Click(object sender, EventArgs e)
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
            if (txtMaNV.Text != "")
            {
                var cmd = new SqlCommand("spDeleteCuaHang", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = txtMaNV.Text;

                cmd.ExecuteNonQuery();
                frmCuaHang_Load(sender, e);
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = dataGridView1.Rows[e.RowIndex].Cells["Mã nhân viên"].Value.ToString();
            txtTenNV.Text = dataGridView1.Rows[e.RowIndex].Cells["Tên nhân viên"].Value.ToString();
            txtMaThue.Text = dataGridView1.Rows[e.RowIndex].Cells["Mã thuế cửa hàng"].Value.ToString();
            txtSDT.Text = dataGridView1.Rows[e.RowIndex].Cells["Số điện thoại cửa hàng"].Value.ToString();
            txtSTK.Text = dataGridView1.Rows[e.RowIndex].Cells["Số tài khoản cửa hàng"].Value.ToString();
            txtDiaChi.Text = dataGridView1.Rows[e.RowIndex].Cells["Địa chỉ cửa hàng"].Value.ToString();
            txtTenNH.Text = dataGridView1.Rows[e.RowIndex].Cells["Tên ngân hàng"].Value.ToString();
            txtGC.Text = dataGridView1.Rows[e.RowIndex].Cells["Tình trạng"].Value.ToString();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
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
            //Bước 2

            string query = "select MaNV as N'Mã nhân viên', TenNV as N'Tên nhân viên', CH_MaThue as N'Mã thuế cửa hàng', CH_SDT as N'Số điện thoại cửa hàng', CH_DiaChi as N'Địa chỉ cửa hàng', CH_SoTK as N'Số tài khoản cửa hàng', CH_TenNH as N'Tên ngân hàng', (case when NV_GC = 0 or NV_GC is null then N'' when NV_GC = 1 then N'Đã xóa' end) as N'Tình trạng' from CUAHANG where MaNV like '%" + txtTimKiem.Text + "'";
            SqlDataAdapter adt = new SqlDataAdapter(query, con);

            DataSet ds = new DataSet();
            try
            {
                adt.Fill(ds, "MaNV");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tìm kiếm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dataGridView1.DataSource = ds.Tables["MaNV"];

            con.Close();
        }
    }
}
