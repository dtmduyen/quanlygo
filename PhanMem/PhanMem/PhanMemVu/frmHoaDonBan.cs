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
    public partial class frmHoaDonBan : Form
    {
        string Scon = "Data Source=HNS\\HUNGNGUYEN;Initial Catalog=CT_LuongTuong;Integrated Security=True";
        public frmHoaDonBan()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {
            //Hóa đơn bán
            //Bước 1
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
            string query = "exec spShowHoaDonBan";
            SqlDataAdapter adt = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            adt.Fill(ds, "HOADONBAN");
            dtgvhdb.DataSource = ds.Tables["HOADONBAN"];

            string query2 = "select MaNV from CUAHANG";
            SqlDataAdapter adt2 = new SqlDataAdapter(query2, con);
            DataSet ds2 = new DataSet();
            adt2.Fill(ds2, "MaNV");

            cbbMaNV.DataSource = ds2.Tables["MaNV"];
            cbbMaNV.ValueMember = "MaNV";
            cbbMaNV.DisplayMember = "TenNV";

            string query3 = "select MaKH from KHACHHANG";
            SqlDataAdapter adt3 = new SqlDataAdapter(query3, con);
            DataSet ds3 = new DataSet();
            adt3.Fill(ds3, "MaKH");

            cbbMaKH.DataSource = ds3.Tables["MaKH"];
            cbbMaKH.ValueMember = "MaKH";
            cbbMaKH.DisplayMember = "TenKH";

            con.Close();//Bước 3

            //chitiet
            SqlConnection con1 = new SqlConnection(Scon);
            try
            {
                con1.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Bước 2
            string query1 = "exec spShowHoaDonBanChiTiet";
            SqlDataAdapter adt1 = new SqlDataAdapter(query1, con1);
            DataSet ds1 = new DataSet();
            adt1.Fill(ds1, "HOADONBANCHITIET");
            dtgvhdbct.DataSource = ds1.Tables["HOADONBANCHITIET"];

            con1.Close();
        }

        private void dtgvhdbct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void them_Click(object sender, EventArgs e)
        {
            txtMaHDB.Text = "";
            cbbMaNV.Text = "";
            dTP1NgayBan.Text = "";
            cbbMaKH.Text = "";
            txtTongTienBan.Text = "";
            txtMaHDB.Enabled = false;
            txtTongTienBan.Enabled = false;
            txtTimKiem.Text = "";
            frmHoaDonBan_Load(sender, e);
        }

        private void btThemHDB_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(Scon);
            //try
            //{
            //    con.Open();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            ////Bước 2
            //string sMaHDB = txtMaHDB.Text;
            //string sNgayBan = dTP1NgayBan.Value.ToString("dd-mm-yyyy");
            //string sMaNV = cbbMaNV.Text;
            //string sMaKH = cbbMaKH.Text;
            //string query = "insert into HOADONBAN values ((select dbo.fNewMaDonBH()),@MaNV, @MaKH, @NgayBan)";

            //SqlCommand cmd = new SqlCommand(query, con);
            ////cmd.Parameters.AddWithValue("@MaDonBH", sMaHDB);
            //cmd.Parameters.AddWithValue("@MaNV", sMaNV);
            //cmd.Parameters.AddWithValue("@MaKH", sMaKH);
            //cmd.Parameters.AddWithValue("@NgayBan", sNgayBan);
            //try
            //{
            //    cmd.ExecuteNonQuery();
            //    frmHoaDonBan_Load(sender, e);
            //    MessageBox.Show("Tạo mới thành công!");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Thêm mới thất bại!");
            //}
            //con.Close();//Bước 3

            SqlConnection con = new SqlConnection(Scon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (cbbMaNV.Text != "")
            {
                var cmd = new SqlCommand("spAddHoaDonBan", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = cbbMaNV.Text;
                cmd.Parameters.Add("@MaKH", SqlDbType.NVarChar).Value = cbbMaKH.Text;
                cmd.Parameters.Add("@NgayBan", SqlDbType.Date).Value = dTP1NgayBan.Text;

                cmd.ExecuteNonQuery();
                frmHoaDonBan_Load(sender, e);
                MessageBox.Show("Tạo mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm mới thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
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
            if (cbbMaNV.Text != "")
            {
                var cmd = new SqlCommand("spUpdateHoaDonBan", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaDonBH", SqlDbType.NVarChar).Value = txtMaHDB.Text;
                cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = cbbMaNV.Text;
                cmd.Parameters.Add("@MaKH", SqlDbType.NVarChar).Value = cbbMaKH.Text;
                cmd.Parameters.Add("@NgayBan", SqlDbType.Date).Value = dTP1NgayBan.Text;

                cmd.ExecuteNonQuery();
                frmHoaDonBan_Load(sender, e);
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }

        private void dtgvhdb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHDB.Text = dtgvhdb.Rows[e.RowIndex].Cells["Mã Hóa đơn bán"].Value.ToString();
            cbbMaNV.Text = dtgvhdb.Rows[e.RowIndex].Cells["Mã nhân viên"].Value.ToString();
            cbbMaKH.Text = dtgvhdb.Rows[e.RowIndex].Cells["Mã Khách hàng"].Value.ToString();
            txtTongTienBan.Text = dtgvhdb.Rows[e.RowIndex].Cells["Tổng tiền bán"].Value.ToString();
            dTP1NgayBan.Text = dtgvhdb.Rows[e.RowIndex].Cells["Ngày bán hàng"].Value.ToString();
        }

        private void btHoaDonChiTiet_Click(object sender, EventArgs e)
        {
            frmHoaDonBanChiTiet f = new frmHoaDonBanChiTiet();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void qulai_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form CaiDat = new frmMain();
            CaiDat.Show();
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

            string query = "select HOADONBAN.MaDonBH as N'Mã hóa đơn bán',MaNV as N'Mã nhân viên', MaKH as N'Mã khách hàng', NgayBan as N'Ngày bán hàng', sum(HOADONBANCHITIET.SoLuongBan * HANGHOA.DonGiaBan) as N'Tổng tiền bán' from HOADONBAN join HOADONBANCHITIET on HOADONBAN.MaDonBH = HOADONBANCHITIET.MaDonBH join HANGHOA on HOADONBANCHITIET.MaHang = HANGHOA.MaHang where HOADONBAN.MaDonBH like '%" + txtTimKiem.Text + "' group by HOADONBAN.MaDonBH,MaNV,MaKH,NgayBan";
            SqlDataAdapter adt = new SqlDataAdapter(query, con);

            DataSet ds = new DataSet();
            try
            {
                adt.Fill(ds, "MaDonBH");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tìm kiếm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dtgvhdb.DataSource = ds.Tables["MaDonBH"];

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
            if (cbbMaNV.Text != "")
            {
                var cmd = new SqlCommand("spDeleteHoaDonBan", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaDonBH", SqlDbType.NVarChar).Value = txtMaHDB.Text;

                cmd.ExecuteNonQuery();
                frmHoaDonBan_Load(sender, e);
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }
    }
}
