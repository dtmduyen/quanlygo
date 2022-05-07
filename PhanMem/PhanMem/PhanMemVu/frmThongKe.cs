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
    public partial class frmThongKe : Form
    {
        string Scon = "Data Source=HNS\\HUNGNGUYEN;Initial Catalog=CT_LuongTuong;Integrated Security=True";
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
            string tuNgay = dtp1.Value.ToString("yyyy-MM-dd");
            string denNgay = dtp2.Value.ToString("yyyy-MM-dd");

            string query = "select HOADONBAN.MaDonBH as N'Mã hóa đơn bán',MaNV as N'Mã nhân viên', MaKH as N'Mã khách hàng', NgayBan as N'Ngày bán hàng', sum(HOADONBANCHITIET.SoLuongBan * HANGHOA.DonGiaBan) as N'Tổng tiền bán' from HOADONBAN join HOADONBANCHITIET on HOADONBAN.MaDonBH = HOADONBANCHITIET.MaDonBH join HANGHOA on HOADONBANCHITIET.MaHang = HANGHOA.MaHang where NgayBan between '"+tuNgay + "' and '" +denNgay +"' group by HOADONBAN.MaDonBH,MaNV,MaKH,NgayBan";
            SqlDataAdapter adt = new SqlDataAdapter(query, con);

            DataSet ds = new DataSet();
            try
            {
                adt.Fill(ds, "MaDonBH");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tìm kiếm hóa đơn bán thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dtgvBan.DataSource = ds.Tables["MaDonBH"];
            //

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
            string tuNgay1 = dtp1.Value.ToString("yyyy-MM-dd");
            string denNgay1 = dtp2.Value.ToString("yyyy-MM-dd");

            string query1 = "select HOADONNHAP.MaDonNH as N'Mã đơn nhập',  MaNCC as N'Mã nhà cung cấp',  MaNV as N'Mã nhân viên',  TiSuatCK as N'Tỉ suất chiết khấu',  VAT as N'VAT',  NgayNhap as N'Ngày nhập', ((HOADONNHAPCHITIET.DonGiaNhap * HOADONNHAPCHITIET.SoLuongNhap) - (HOADONNHAPCHITIET.DonGiaNhap * HOADONNHAPCHITIET.SoLuongNhap) * TiSuatCK + (HOADONNHAPCHITIET.DonGiaNhap * HOADONNHAPCHITIET.SoLuongNhap) * VAT) as N'Tổng tiền nhập' from HOADONNHAP join HOADONNHAPCHITIET on HOADONNHAP.MaDonNH = HOADONNHAPCHITIET.MaDonNH where NgayNhap between '" + tuNgay1 + "' and '" + denNgay1 + "' ";
            SqlDataAdapter adt1 = new SqlDataAdapter(query1, con);

            DataSet ds1 = new DataSet();
            try
            {
                adt1.Fill(ds, "MaDonNH");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tìm kiếm hóa đơn nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dtgvNhap.DataSource = ds.Tables["MaDonNH"];

            con.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
