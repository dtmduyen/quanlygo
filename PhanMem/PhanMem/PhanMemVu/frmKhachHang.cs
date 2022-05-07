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
    public partial class frmKhachHang : Form
    {
        string Scon = "Data Source=HNS\\HUNGNGUYEN;Initial Catalog=CT_LuongTuong;Integrated Security=True";
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void quaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form KhachHang = new frmMain();
            KhachHang.Show();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
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
            string sQuery = " exec spShowKhachHang";
            SqlDataAdapter adt = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adt.Fill(ds, "KHACHHANG");
            dataGridView1.DataSource = ds.Tables["KHACHHANG"];
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
            if (txtTenKH.Text != "" && txtDiaChi.Text != "" && txtSDT.Text != "" && txtGioiTinh.Text !="")
            {
                var cmd = new SqlCommand("spAddKhachHang", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TenKH", SqlDbType.NVarChar).Value = txtTenKH.Text;
                cmd.Parameters.Add("@KH_GioiTinh", SqlDbType.VarChar).Value = txtGioiTinh.Text;
                cmd.Parameters.Add("@KH_DiaChi", SqlDbType.NVarChar).Value = txtDiaChi.Text;
                cmd.Parameters.Add("@KH_SDT", SqlDbType.VarChar).Value = txtSDT.Text;
                
                cmd.ExecuteNonQuery();
                frmKhachHang_Load(sender, e);
                MessageBox.Show("Tạo mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm mới thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKH.Text = dataGridView1.Rows[e.RowIndex].Cells["Mã khách hàng"].Value.ToString();
            txtTenKH.Text = dataGridView1.Rows[e.RowIndex].Cells[" Tên khách hàng"].Value.ToString();
            txtGioiTinh.Text = dataGridView1.Rows[e.RowIndex].Cells["Giới tính"].Value.ToString();
            txtDiaChi.Text = dataGridView1.Rows[e.RowIndex].Cells["Địa chỉ"].Value.ToString();
            txtSDT.Text = dataGridView1.Rows[e.RowIndex].Cells["Số điện thoại"].Value.ToString();
            txtGhiChu.Text = dataGridView1.Rows[e.RowIndex].Cells["Tình trạng"].Value.ToString();
            txtMaKH.Enabled = false;

        }

        private void taomoi_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtTimKiem.Text = "";
            txtGioiTinh.Text = "";
            txtGhiChu.Text = "";
            txtMaKH.Focus();
            txtMaKH.Enabled = true;

            frmKhachHang_Load(sender, e);

        }

        private void sua_Click(object sender, EventArgs e)
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
            if (txtTenKH.Text != "" && txtDiaChi.Text != "" && txtSDT.Text != "" && txtGioiTinh.Text != "")
            {
                var cmd = new SqlCommand("spUpdateKhachHang", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaKH", SqlDbType.VarChar).Value = txtMaKH.Text;
                cmd.Parameters.Add("@TenKH", SqlDbType.NVarChar).Value = txtTenKH.Text;
                cmd.Parameters.Add("@KH_GioiTinh", SqlDbType.VarChar).Value = txtGioiTinh.Text;
                cmd.Parameters.Add("@KH_DiaChi", SqlDbType.NVarChar).Value = txtDiaChi.Text;
                cmd.Parameters.Add("@KH_SDT", SqlDbType.VarChar).Value = txtSDT.Text;
                cmd.Parameters.Add("@KH_GC", SqlDbType.VarChar).Value = txtSDT.Text;

                cmd.ExecuteNonQuery();
                frmKhachHang_Load(sender, e);
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (txtTenKH.Text != "" && txtDiaChi.Text != "" && txtSDT.Text != "" && txtGioiTinh.Text != "")
            {
                var cmd = new SqlCommand("spDeleteKhachHang", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaKH", SqlDbType.VarChar).Value = txtMaKH.Text;
                cmd.ExecuteNonQuery();
                frmKhachHang_Load(sender, e);
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();

        }

        private void timlai_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(Scon);
            txtTimKiem.Text = "";
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtMaKH.Enabled = true;
            string sQuery = " select * from KHACHHANG";
            SqlDataAdapter adt = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adt .Fill(ds, "KHACHHANG");
            dataGridView1.DataSource = ds.Tables["KHACHHANG"];
            con.Close();


        }

        private void timkiem_Click(object sender, EventArgs e)
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

            string query = "select MaKH as N'Mã khách hàng', TenKH as N' Tên khách hàng', (case when KH_GioiTinh = 0 then N'Nữ'	when KH_GioiTinh = 1 then N'Nam' else N'Khác' end) as N'Giới tính', KH_DiaChi as N'Địa chỉ', KH_SDT as N'Số điện thoại', (case when KH_GC = 0 or KH_GC is null then N'' when KH_GC = 1 then N'Đã xóa' end) as N'Tình trạng' from KHACHHANG where MaKH like '%" + txtTimKiem.Text + "'";
            SqlDataAdapter adt = new SqlDataAdapter(query, con);

            DataSet ds = new DataSet();
            try
            {
                adt.Fill(ds, "MaKH");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tìm kiếm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dataGridView1.DataSource = ds.Tables["MaKH"];

            con.Close();         
            
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
                MessageBox.Show("Xảy ra lỗi khi kết nối DB!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string Select = "exec spShowKhachHang";
            SqlCommand cmd = new SqlCommand(Select, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }

        private void radioNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
