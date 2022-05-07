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
    public partial class frmHoaDonNhapChiTiet : Form
    {
        string Scon = "Data Source=HNS\\HUNGNGUYEN;Initial Catalog=CT_LuongTuong;Integrated Security=True";
        public frmHoaDonNhapChiTiet()
        {
            InitializeComponent();
        }

        private void frmHoaDonNhapChiTiet_Load(object sender, EventArgs e)
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
            string query = "exec spShowHoaDonNhapChiTiet";
            SqlDataAdapter adt = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            adt.Fill(ds, "HOADONNHAPCHITIET");
            dtgvhdnct.DataSource = ds.Tables["HOADONNHAPCHITIET"];

            string query1 = "select MaDonNH from HOADONNHAP";
            SqlDataAdapter adt1 = new SqlDataAdapter(query1, con);
            DataSet ds1 = new DataSet();
            adt1.Fill(ds1, "MaDonNH");

            cbbMaHDNCT.DataSource = ds1.Tables["MaDonNH"];
            cbbMaHDNCT.ValueMember = "MaDonNH";
            cbbMaHDNCT.DisplayMember = "MaDonNH";

            string query2 = "select MaHang from HANGHOA";
            SqlDataAdapter adt2 = new SqlDataAdapter(query2, con);
            DataSet ds2 = new DataSet();
            adt2.Fill(ds2, "MaHang");

            cbbMaHang.DataSource = ds2.Tables["MaHang"];
            cbbMaHang.ValueMember = "MaHang";
            cbbMaHang.DisplayMember = "MaHang";

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
            if (cbbMaHDNCT.Text != "" && cbbMaHang.Text != "" && txtDonGiaNhap.Text != "" && txtSoLuongNhap.Text != "" && txtHinhThuc.Text !="")
            {
                var cmd = new SqlCommand("spAddHoaDonNhapChiTiet", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaDonNhap", SqlDbType.NVarChar).Value = cbbMaHDNCT.Text;
                cmd.Parameters.Add("@MaHang", SqlDbType.VarChar).Value = cbbMaHang.Text;
                cmd.Parameters.Add("@DonGiaNhap", SqlDbType.VarChar).Value = txtDonGiaNhap.Text;
                cmd.Parameters.Add("@SoLuong", SqlDbType.NVarChar).Value = txtSoLuongNhap.Text;
                cmd.Parameters.Add("@HinhThuc", SqlDbType.NVarChar).Value = txtHinhThuc.Text;
                cmd.ExecuteNonQuery();
                frmHoaDonNhapChiTiet_Load(sender, e);
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
            if (cbbMaHDNCT.Text != "" && cbbMaHang.Text != "" && txtDonGiaNhap.Text != "" && txtSoLuongNhap.Text != "" && txtHinhThuc.Text != "")
            {
                var cmd = new SqlCommand("spDeleteHoaDonNhapChiTiet", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaDonNH", SqlDbType.NVarChar).Value = cbbMaHDNCT.Text;
                cmd.Parameters.Add("@MaHang", SqlDbType.VarChar).Value = cbbMaHang.Text;
                cmd.ExecuteNonQuery();
                frmHoaDonNhapChiTiet_Load(sender, e);
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
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
            if (cbbMaHDNCT.Text != "" && cbbMaHang.Text != "" && txtDonGiaNhap.Text != "" && txtSoLuongNhap.Text != "" && txtHinhThuc.Text != "")
            {
                var cmd = new SqlCommand("spUpdateHoaDonNhapChiTiet", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaDonNhap", SqlDbType.NVarChar).Value = cbbMaHDNCT.Text;
                cmd.Parameters.Add("@MaHang", SqlDbType.VarChar).Value = cbbMaHang.Text;
                cmd.Parameters.Add("@DonGiaNhap", SqlDbType.VarChar).Value = txtDonGiaNhap.Text;
                cmd.Parameters.Add("@SoLuong", SqlDbType.NVarChar).Value = txtSoLuongNhap.Text;
                cmd.Parameters.Add("@HinhThuc", SqlDbType.NVarChar).Value = txtHinhThuc.Text;
                cmd.ExecuteNonQuery();
                frmHoaDonNhapChiTiet_Load(sender, e);
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            cbbMaHDNCT.Text = "";
            cbbMaHang.Text = "";
            txtDonGiaNhap.Text = "";
            txtHinhThuc.Text = "";
            txtSoLuongNhap.Text = "";
            txtTimKiem.Text = "";
            cbbMaHang.Enabled = true;
            cbbMaHDNCT.Enabled = true;
            frmHoaDonNhapChiTiet_Load(sender, e);
        }

        private void dtgvhdnct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbMaHDNCT.Text = dtgvhdnct.Rows[e.RowIndex].Cells["Mã đơn nhập hàng"].Value.ToString();
            cbbMaHang.Text = dtgvhdnct.Rows[e.RowIndex].Cells["Mã hàng"].Value.ToString();
            txtDonGiaNhap.Text = dtgvhdnct.Rows[e.RowIndex].Cells["Đơn giá nhập"].Value.ToString();
            txtSoLuongNhap.Text = dtgvhdnct.Rows[e.RowIndex].Cells["Số lượng nhập"].Value.ToString();
            txtHinhThuc.Text = dtgvhdnct.Rows[e.RowIndex].Cells["Hình thức thanh toán"].Value.ToString();
            cbbMaHang.Enabled = false;
            cbbMaHDNCT.Enabled = false;
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

            string query = "select HOADONNHAPCHITIET.MaDonNH as N'Mã đơn nhập hàng', MaHang as N'Mã hàng', DonGiaNhap as N'Đơn giá nhập', SoLuongNhap as N'Số lượng nhập', (DonGiaNhap * SoLuongNhap) as N'Thành tiền nhập', (sum(DonGiaNhap * SoLuongNhap)) as N'Tiền hàng', (DonGiaNhap * SoLuongNhap * cast(HOADONNHAP.TiSuatCK as float)) as N'Tiền chiết khấu', (DonGiaNhap * SoLuongNhap * cast(HOADONNHAP.VAT as float)) as N'Tiền VAT', HinhThucTT as N'Hình thức thanh toán' from HOADONNHAPCHITIET join HOADONNHAP on HOADONNHAPCHITIET.MaDonNH = HOADONNHAP.MaDonNH where HOADONNHAPCHITIET.MaDonNH like '%" + txtTimKiem.Text + "%'" + " group by HOADONNHAPCHITIET.MaDonNH, MaHang,DonGiaNhap,SoLuongNhap,HOADONNHAP.TiSuatCK,HOADONNHAP.VAT,HinhThucTT ";
            SqlDataAdapter adt = new SqlDataAdapter(query, con);

            DataSet ds = new DataSet();
            try
            {
                adt.Fill(ds, "MaDonNH");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //MessageBox.Show("Tìm kiếm thất bại");
            }
            dtgvhdnct.DataSource = ds.Tables["MaDonNH"];

            con.Close();//Bước 3
        }
    }
}
