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
    public partial class frmHoaDonBanChiTiet : Form
    {
        string Scon = "Data Source=HNS\\HUNGNGUYEN;Initial Catalog=CT_LuongTuong;Integrated Security=True";
        public frmHoaDonBanChiTiet()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmHoaDonBanChiTiet_Load(object sender, EventArgs e)
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
            string query = "exec spShowHoaDonBanChiTiet";
            SqlDataAdapter adt = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            adt.Fill(ds, "HOADONBANCHITIET");
            dtgvhdbct.DataSource = ds.Tables["HOADONBANCHITIET"];

            string query1 = "select MaDonBH from HOADONBAN";
            SqlDataAdapter adt1 = new SqlDataAdapter(query1, con);
            DataSet ds1 = new DataSet();
            adt1.Fill(ds1, "MaDonBH");

            cbbMaHDB.DataSource = ds1.Tables["MaDonBH"];
            cbbMaHDB.ValueMember = "MaDonBH";
            //cbbMaHDB.DisplayMember = "TenNV";

            string query2 = "select MaHang from HangHoa";
            SqlDataAdapter adt2 = new SqlDataAdapter(query2, con);
            DataSet ds2 = new DataSet();
            adt2.Fill(ds2, "MaHang");

            cbbMaHang.DataSource = ds2.Tables["MaHang"];
            cbbMaHang.ValueMember = "MaHang";
            cbbMaHang.DisplayMember = "TenHang";

            con.Close();
        }

        private void dtgvhdbct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbMaHDB.Text = dtgvhdbct.Rows[e.RowIndex].Cells["Mã hóa đơn bán"].Value.ToString();
            cbbMaHang.Text = dtgvhdbct.Rows[e.RowIndex].Cells["Mã hàng"].Value.ToString();
            txtSoLuongBan.Text = dtgvhdbct.Rows[e.RowIndex].Cells["Số lượng bán"].Value.ToString();
            txtThanhTien.Text = dtgvhdbct.Rows[e.RowIndex].Cells["Thành tiền bán"].Value.ToString();
            cbbMaHDB.Enabled = false;
            cbbMaHang.Enabled = false;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            cbbMaHDB.Text = "";
            cbbMaHang.Text = "";
            txtSoLuongBan.Text = "";
            txtThanhTien.Text = "";
            txtTimKiem.Text = "";
            cbbMaHDB.Enabled = true;
            cbbMaHang.Enabled = true;
            frmHoaDonBanChiTiet_Load(sender, e);
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
            if (cbbMaHang.Text != "" && cbbMaHDB.Text != "" && txtSoLuongBan.Text != "" )
            {
                var cmd = new SqlCommand("spAddHoaDonBanChiTiet", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaDonBH", SqlDbType.NVarChar).Value =cbbMaHDB.Text;
                cmd.Parameters.Add("@MaHang", SqlDbType.VarChar).Value = cbbMaHang.Text;
                cmd.Parameters.Add("@SoLuongBan", SqlDbType.NVarChar).Value = txtSoLuongBan.Text;
                cmd.ExecuteNonQuery();
                frmHoaDonBanChiTiet_Load(sender, e);
               // frmHoaDonBan_Load(sender, e);
                MessageBox.Show("Tạo mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm mới thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (cbbMaHang.Text != "" && cbbMaHDB.Text != "" && txtSoLuongBan.Text != "")
            {
                var cmd = new SqlCommand("spUpdateHoaDonBanChiTiet", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaDonBH", SqlDbType.NVarChar).Value = cbbMaHDB.Text;
                cmd.Parameters.Add("@MaHang", SqlDbType.VarChar).Value = cbbMaHang.Text;
                cmd.Parameters.Add("@SoLuongBan", SqlDbType.NVarChar).Value = txtSoLuongBan.Text;
                cmd.ExecuteNonQuery();
                frmHoaDonBanChiTiet_Load(sender, e);
               // frmHoaDonBan_Load(sender, e);
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
            if (cbbMaHang.Text != "" && cbbMaHDB.Text != "")
            {
                var cmd = new SqlCommand("spDeleteHoaDonBanChiTiet", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaDonBH", SqlDbType.NVarChar).Value = cbbMaHDB.Text;
                cmd.Parameters.Add("@MaHang", SqlDbType.VarChar).Value = cbbMaHang.Text;
                cmd.ExecuteNonQuery();
                frmHoaDonBanChiTiet_Load(sender, e);
               // frmHoaDonBan_Load(sender, e);
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }

        private void qulai_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form CaiDat = new frmMain();
            CaiDat.Show();
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

            string query = "select MaDonBH as N'Mã hóa đơn bán', HOADONBANCHITIET.MaHang as N'Mã hàng', SoLuongBan as N'Số lượng bán', (HOADONBANCHITIET.SoLuongBan * HANGHOA.DonGiaBan) as N'Thành tiền bán' from HOADONBANCHITIET join HANGHOA on HOADONBANCHITIET.MaHang = HANGHOA.MaHang where MaDonBH like '%" + txtTimKiem.Text + "%'";
            SqlDataAdapter adt = new SqlDataAdapter(query, con);

            DataSet ds = new DataSet();
            try
            {
                adt.Fill(ds, "MaDonBH");
            }
            catch ( Exception ex)
            {
                MessageBox.Show("Tìm kiếm thất bại");
            }
            dtgvhdbct.DataSource = ds.Tables["MaDonBH"];
            
            con.Close();//Bước 3
        }
    }
}
