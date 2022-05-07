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
    public partial class frmHangHoa : Form
    {
        string Scon = "Data Source=HNS\\HUNGNGUYEN;Initial Catalog=CT_LuongTuong;Integrated Security=True";
        public frmHangHoa()
        {
            InitializeComponent();
        }

        private void frmHangHoa_Load(object sender, EventArgs e)
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
            string sQuery = "exec spShowHangHoa";
            SqlDataAdapter adt = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adt.Fill(ds, "HANGHOA");
            dataGridView1.DataSource = ds.Tables["HANGHOA"];
            con.Close();
        }
        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHang.Text = dataGridView1.Rows[e.RowIndex].Cells["Mã hàng"].Value.ToString();
            txtTenHang.Text = dataGridView1.Rows[e.RowIndex].Cells["Tên hàng"].Value.ToString();
            txtSoLuongHH.Text = dataGridView1.Rows[e.RowIndex].Cells["Số lượng hàng hóa"].Value.ToString();
            txtDVT.Text = dataGridView1.Rows[e.RowIndex].Cells["Đơn vị tính"].Value.ToString();
            txtDonGiaBan.Text = dataGridView1.Rows[e.RowIndex].Cells["Đơn giá bán"].Value.ToString();

            txtMaHang.Enabled = false;
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
            string Select = "exec spShowHangHoa";
            SqlCommand cmd = new SqlCommand(Select, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }
        private void btnLuu_Click(object sender, EventArgs e)
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
            if (txtTenHang.Text != "" && txtDonGiaBan.Text != "" && txtDVT.Text != "")
            {
                var cmd = new SqlCommand("spAddHangHoa", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TenHang", SqlDbType.NVarChar).Value = txtTenHang.Text;
                cmd.Parameters.Add("@SoLuongHH", SqlDbType.VarChar).Value = txtSoLuongHH.Text;
                cmd.Parameters.Add("@DVT", SqlDbType.NVarChar).Value = txtDVT.Text;
                cmd.Parameters.Add("@DonGiaBan", SqlDbType.VarChar).Value = txtDonGiaBan.Text;

                cmd.ExecuteNonQuery();
                frmHangHoa_Load(sender, e);
                MessageBox.Show("Tạo mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm mới thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form HangHoa = new frmMain();
            HangHoa.Show();
        }

        private void btnTaomoi_Click(object sender, EventArgs e)
        {
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            txtSoLuongHH.Text = "";
            txtDVT.Text = "";
            txtDonGiaBan.Text = "";
            txtTimKiem.Text = "";

            txtMaHang.Focus();
            txtMaHang.Enabled = true;
            frmHangHoa_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
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
            if (txtTenHang.Text != "" && txtDonGiaBan.Text != "" && txtDVT.Text != "")
            {
                var cmd = new SqlCommand("spUpdateHangHoa", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaHang", SqlDbType.NVarChar).Value = txtMaHang.Text;
                cmd.Parameters.Add("@TenHang", SqlDbType.NVarChar).Value = txtTenHang.Text;
                cmd.Parameters.Add("@SoLuongHH", SqlDbType.VarChar).Value = txtSoLuongHH.Text;
                cmd.Parameters.Add("@DVT", SqlDbType.NVarChar).Value = txtDVT.Text;
                cmd.Parameters.Add("@DonGiaBan", SqlDbType.VarChar).Value = txtDonGiaBan.Text;

                cmd.ExecuteNonQuery();
                frmHangHoa_Load(sender, e);
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
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
            if (txtTenHang.Text != "" && txtDonGiaBan.Text != "" && txtDVT.Text != "")
            {
                var cmd = new SqlCommand("spDeleteHangHoa", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaHang", SqlDbType.NVarChar).Value = txtMaHang.Text;

                cmd.ExecuteNonQuery();
                frmHangHoa_Load(sender, e);
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
            
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
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

            string query = "select MaHang as N'Mã hàng', TenHang as N'Tên hàng', SoLuongHH as N'Số lượng hàng hóa', DVT as N'Đơn vị tính', DonGiaBan as N'Đơn giá bán' from HANGHOA where MaHang like '%" + txtTimKiem.Text + "'";
            SqlDataAdapter adt = new SqlDataAdapter(query, con);

            DataSet ds = new DataSet();
            try
            {
                adt.Fill(ds, "MaHang");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tìm kiếm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dataGridView1.DataSource = ds.Tables["MaHang"];

            con.Close();  
        }

        private void btnTimlai_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Scon);
            txtTimKiem.Text = "";
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            txtSoLuongHH.Text = "";
            txtDVT.Text = "";
            txtDonGiaBan.Text = "";
            txtMaHang.Enabled = true;
            string sQuery = " select * from HANGHOA";
            SqlDataAdapter adt = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adt.Fill(ds, "HANGHOA");
            dataGridView1.DataSource = ds.Tables["HANGHOA"];
            con.Close();
        }
    }
}
