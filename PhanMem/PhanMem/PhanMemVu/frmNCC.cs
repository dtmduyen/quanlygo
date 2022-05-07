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
    public partial class frmNCC : Form
    {
        string Scon = "Data Source=HNS\\HUNGNGUYEN;Initial Catalog=CT_LuongTuong;Integrated Security=True";
        public frmNCC()
        {
            InitializeComponent();
        }

        private void frmNCC_Load(object sender, EventArgs e)
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
            string query = "exec spShowNCC";
            SqlDataAdapter adt = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            adt.Fill(ds, "NHACUNGCAP");
            dtgvncc.DataSource = ds.Tables["NHACUNGCAP"];
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDiaChi.Text = "";
            txtMaThue.Text = "";
            txtSDT.Text = "";
            txtGC.Text = "";
            txtSTK.Text = "";
            txtTenNH.Text = "";
            txtTimKiem.Text = "";
            frmNCC_Load(sender, e);
        }

        private void btThemNCC_Click(object sender, EventArgs e)
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
            if (txtTenNCC.Text != "" && txtMaThue.Text != "" && txtDiaChi.Text != "" && txtSDT.Text != "" && txtSDT.Text != "" && txtTenNH.Text != "" )
            {
                var cmd = new SqlCommand("spAddNCC", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TenNCC", SqlDbType.NVarChar).Value = txtTenNCC.Text;
                cmd.Parameters.Add("@NCC_MaThue", SqlDbType.VarChar).Value = txtMaThue.Text;
                cmd.Parameters.Add("@NCC_DiaChi", SqlDbType.NVarChar).Value = txtDiaChi.Text;
                cmd.Parameters.Add("@NCC_SDT", SqlDbType.VarChar).Value = txtSDT.Text;
                cmd.Parameters.Add("@NCC_STK", SqlDbType.VarChar).Value = txtSDT.Text;
                cmd.Parameters.Add("@NCC_TenNH", SqlDbType.NVarChar).Value = txtTenNH.Text;
                cmd.Parameters.Add("@NCC_GC", SqlDbType.NVarChar).Value = txtGC.Text;
                cmd.ExecuteNonQuery();
                frmNCC_Load(sender, e);
                MessageBox.Show("Tạo mới thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm mới thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }

        private void btSuaNCC_Click(object sender, EventArgs e)
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
            if (txtTenNCC.Text != "" && txtMaThue.Text != "" && txtDiaChi.Text != "" && txtSDT.Text != "" && txtSDT.Text != "" && txtTenNH.Text != "")
            {
                var cmd = new SqlCommand("spUpdateNCC", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaNCC", SqlDbType.VarChar).Value = txtMaNCC.Text;
                cmd.Parameters.Add("@TenNCC", SqlDbType.NVarChar).Value = txtTenNCC.Text;
                cmd.Parameters.Add("@NCC_MaThue", SqlDbType.VarChar).Value = txtMaThue.Text;
                cmd.Parameters.Add("@NCC_DiaChi", SqlDbType.NVarChar).Value = txtDiaChi.Text;
                cmd.Parameters.Add("@NCC_SDT", SqlDbType.VarChar).Value = txtSDT.Text;
                cmd.Parameters.Add("@NCC_STK", SqlDbType.VarChar).Value = txtSDT.Text;
                cmd.Parameters.Add("@NCC_TenNH", SqlDbType.NVarChar).Value = txtTenNH.Text;
                cmd.Parameters.Add("@NCC_GC", SqlDbType.NVarChar).Value = txtGC.Text;
                cmd.ExecuteNonQuery();
                frmNCC_Load(sender, e);
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }

        private void dtgvncc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNCC.Text = dtgvncc.Rows[e.RowIndex].Cells["Mã nhà cung cấp"].Value.ToString();
            txtTenNCC.Text = dtgvncc.Rows[e.RowIndex].Cells["Tên nhà cung cấp"].Value.ToString();
            txtMaThue.Text = dtgvncc.Rows[e.RowIndex].Cells["Mã thuế nhà cung cấp"].Value.ToString();
            txtDiaChi.Text = dtgvncc.Rows[e.RowIndex].Cells["Địa chỉ nhà cung cấp"].Value.ToString();
            txtSDT.Text = dtgvncc.Rows[e.RowIndex].Cells["Số điện thoại nhà cung cấp"].Value.ToString();
            txtSTK.Text = dtgvncc.Rows[e.RowIndex].Cells["Số tài khoản nhà cung cấp"].Value.ToString();
            txtTenNH.Text = dtgvncc.Rows[e.RowIndex].Cells["Tên ngân hàng"].Value.ToString();
            txtGC.Text = dtgvncc.Rows[e.RowIndex].Cells["Trạng thái"].Value.ToString();
        }

        private void btXoaNCC_Click(object sender, EventArgs e)
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
            if (txtTenNCC.Text != "" && txtMaThue.Text != "" && txtDiaChi.Text != "" && txtSDT.Text != "" && txtSDT.Text != "" && txtTenNH.Text != "")
            {
                var cmd = new SqlCommand("spDeleteNCC", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaNCC", SqlDbType.VarChar).Value = txtMaNCC.Text;
                cmd.ExecuteNonQuery();
                frmNCC_Load(sender, e);
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
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

            string query = "select MaNCC as N'Mã nhà cung cấp', TenNCC as N'Tên nhà cung cấp', NCC_MaThue as N'Mã thuế nhà cung cấp', NCC_DiaChi as N'Địa chỉ nhà cung cấp', NCC_SDT as N'Số điện thoại nhà cung cấp', NCC_STK as N'Số tài khoản nhà cung cấp', NCC_TenNH as N'Tên ngân hàng',(case when NCC_GC = 0 or NCC_GC is null then N''when NCC_GC = 1 then N'Đã xóa' end) as N'Trạng thái' from NhaCungCap where MaNCC like '%" + txtTimKiem.Text + "'";
            SqlDataAdapter adt = new SqlDataAdapter(query, con);

            DataSet ds = new DataSet();
            try
            {
                adt.Fill(ds, "MaNCC");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tìm kiếm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dtgvncc.DataSource = ds.Tables["MaNCC"];

            con.Close();//Bước 3
        }
    }
}
