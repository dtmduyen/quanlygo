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
    public partial class frmHoaDonNhap : Form
    {
        string Scon = "Data Source=HNS\\HUNGNGUYEN;Initial Catalog=CT_LuongTuong;Integrated Security=True";
        public frmHoaDonNhap()
        {
            InitializeComponent();
        }

        private void txtTongTienBan_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmHoaDonNhap_Load(object sender, EventArgs e)
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
            string query = "exec spShowHoaDonNhap";
            SqlDataAdapter adt = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            adt.Fill(ds, "HOADONNHAP");
            dtgvhdn.DataSource = ds.Tables["HOADONNHAP"];

            string query1 = "exec spShowHoaDonNhapChiTiet";
            SqlDataAdapter adt1 = new SqlDataAdapter(query1, con);
            DataSet ds1 = new DataSet();
            adt1.Fill(ds1, "HOADONNHAPCHITIET");
            dtgvhdnct.DataSource = ds1.Tables["HOADONNHAPCHITIET"];

            string query2 = "select MaNV from CUAHANG";
            SqlDataAdapter adt2 = new SqlDataAdapter(query2, con);
            DataSet ds2 = new DataSet();
            adt2.Fill(ds2, "MaNV");

            cbbMaNV.DataSource = ds2.Tables["MaNV"];
            cbbMaNV.ValueMember = "MaNV";
            cbbMaNV.DisplayMember = "TenNV";

            string query3 = "select MaNCC from NHACUNGCAP";
            SqlDataAdapter adt3 = new SqlDataAdapter(query3, con);
            DataSet ds3 = new DataSet();
            adt3.Fill(ds3, "MaNCC");

            cbbMaNCC.DataSource = ds3.Tables["MaNCC"];
            cbbMaNCC.ValueMember = "MaNCC";
            cbbMaNCC.DisplayMember = "TenNCC";

            con.Close();
        }

        private void qulai_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form CaiDat = new frmMain();
            CaiDat.Show();
        }

        private void btHoaDonChiTiet_Click(object sender, EventArgs e)
        {
            frmHoaDonNhapChiTiet f = new frmHoaDonNhapChiTiet();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void tim_Click(object sender, EventArgs e)
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

            string query = "select HOADONNHAP.MaDonNH as N'Mã đơn nhập',  MaNCC as N'Mã nhà cung cấp', MaNV as N'Mã nhân viên',  TiSuatCK as N'Tỉ suất chiết khấu', VAT as N'VAT', NgayNhap as N'Ngày nhập', ((HOADONNHAPCHITIET.DonGiaNhap * HOADONNHAPCHITIET.SoLuongNhap) - (HOADONNHAPCHITIET.DonGiaNhap * HOADONNHAPCHITIET.SoLuongNhap) * TiSuatCK + (HOADONNHAPCHITIET.DonGiaNhap * HOADONNHAPCHITIET.SoLuongNhap) * VAT) as N'Tổng tiền nhập' from HOADONNHAP join HOADONNHAPCHITIET on HOADONNHAP.MaDonNH = HOADONNHAPCHITIET.MaDonNH where HOADONNHAP.MaDonNH like '%" + txtTimKiem.Text + "'";
            SqlDataAdapter adt = new SqlDataAdapter(query, con);

            DataSet ds = new DataSet();
            try
            {
                adt.Fill(ds, "MaDonNH");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tìm kiếm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dtgvhdn.DataSource = ds.Tables["MaDonNH"];

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
            if (cbbMaNV.Text != "" && cbbMaNCC.Text !="" && txtCK.Text != "" && txtVAT.Text != "")
            {
                var cmd = new SqlCommand("spAddHoaDonNhap", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaNCC", SqlDbType.NVarChar).Value = cbbMaNCC.Text;
                cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = cbbMaNV.Text;
                cmd.Parameters.Add("@TiSuatCK", SqlDbType.NVarChar).Value = txtCK.Text;
                cmd.Parameters.Add("@VAT", SqlDbType.NVarChar).Value = txtVAT.Text;
                cmd.Parameters.Add("@NgayNhap", SqlDbType.Date).Value = dtpBan.Text;

                cmd.ExecuteNonQuery();
                frmHoaDonNhap_Load(sender, e);
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            cbbMaNCC.Text = "";
            cbbMaNV.Text = "";
            txtCK.Text = "";
            txtMaHDN.Text = "";
            txtTimKiem.Text = "";
            txtTongTienNhap.Text = "";
            txtVAT.Text = "";
            frmHoaDonNhap_Load(sender, e);
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
            if (cbbMaNV.Text != "" && cbbMaNCC.Text != "" && txtCK.Text != "" && txtVAT.Text != "")
            {
                var cmd = new SqlCommand("spUpdateHoaDonNhap", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaDonNH", SqlDbType.NVarChar).Value = txtMaHDN.Text;
                cmd.Parameters.Add("@MaNCC", SqlDbType.NVarChar).Value = cbbMaNCC.Text;
                cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = cbbMaNV.Text;
                cmd.Parameters.Add("@TiSuatCK", SqlDbType.NVarChar).Value = txtCK.Text;
                cmd.Parameters.Add("@VAT", SqlDbType.NVarChar).Value = txtVAT.Text;
                cmd.Parameters.Add("@NgayNhap", SqlDbType.Date).Value = dtpBan.Text;

                cmd.ExecuteNonQuery();
                frmHoaDonNhap_Load(sender, e);
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
            if (cbbMaNV.Text != "" && cbbMaNCC.Text != "" && txtCK.Text != "" && txtVAT.Text != "")
            {
                var cmd = new SqlCommand("spDeleteHoaDonNhap", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaDonNH", SqlDbType.NVarChar).Value = txtMaHDN.Text;

                cmd.ExecuteNonQuery();
                frmHoaDonNhap_Load(sender, e);
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }

        private void dtgvhdn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbMaNV.Text = dtgvhdn.Rows[e.RowIndex].Cells["Mã nhân viên"].Value.ToString();
            cbbMaNCC.Text = dtgvhdn.Rows[e.RowIndex].Cells["Mã nhà cung cấp"].Value.ToString();
            txtMaHDN.Text = dtgvhdn.Rows[e.RowIndex].Cells["Mã đơn nhập"].Value.ToString();
            txtCK.Text = dtgvhdn.Rows[e.RowIndex].Cells["Tỉ suất chiết khấu"].Value.ToString();
            txtVAT.Text = dtgvhdn.Rows[e.RowIndex].Cells["VAT"].Value.ToString();
            dtpBan.Text = dtgvhdn.Rows[e.RowIndex].Cells["Ngày nhập"].Value.ToString();
            txtTongTienNhap.Text = dtgvhdn.Rows[e.RowIndex].Cells["Tổng tiền nhập"].Value.ToString();
        }
    }
}
