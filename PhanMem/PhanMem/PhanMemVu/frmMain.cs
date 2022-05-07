using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemVu
{
    public partial class frmMain : Form
    {
        
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn chắc chắn muốn đăng xuất?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                this.Hide();
                Form frmDangNhap = new frmDangNhap();
                frmDangNhap.Show();
            }
            else if (traloi == DialogResult.Cancel)
            {
                this.Hide();
                Form frmMain = new frmMain();
                frmMain.Show();
            }
            
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn thoát không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                Application.Exit();
            }
            else if (traloi == DialogResult.Cancel)
            {
                this.Hide();
                Form frmMain = new frmMain();
                frmMain.Show();
            }
            
        }

        

        private void KhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang f = new frmKhachHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void CaiDatTKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCaiDatTK f = new frmCaiDatTK();
            this.Hide();
            f.ShowDialog();
            this.Show(); 
        }

        private void thốngKêDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKe f = new frmThongKe();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

       

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDonNhap f = new frmHoaDonNhap();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDonBan f = new frmHoaDonBan();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmHangHoa f = new frmHangHoa();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void DonHangToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNCC f = new frmNCC();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void cửaHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCuaHang f = new frmCuaHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKe f = new frmThongKe();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }


      
    }
}
