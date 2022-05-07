namespace PhanMemVu
{
    partial class frmHoaDonBanChiTiet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgvhdbct = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoLuongBan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.cbbMaHDB = new System.Windows.Forms.ComboBox();
            this.cbbMaHang = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btSuaHD = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.btThemHDB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvhdbct)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvhdbct
            // 
            this.dtgvhdbct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvhdbct.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvhdbct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvhdbct.Location = new System.Drawing.Point(40, 560);
            this.dtgvhdbct.Name = "dtgvhdbct";
            this.dtgvhdbct.RowTemplate.Height = 24;
            this.dtgvhdbct.Size = new System.Drawing.Size(1812, 408);
            this.dtgvhdbct.TabIndex = 0;
            this.dtgvhdbct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvhdbct_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(450, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(983, 90);
            this.label2.TabIndex = 3;
            this.label2.Text = "HÓA ĐƠN BÁN CHI TIẾT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã Hóa Đơn Bán:";
            // 
            // txtSoLuongBan
            // 
            this.txtSoLuongBan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongBan.Location = new System.Drawing.Point(1037, 210);
            this.txtSoLuongBan.Name = "txtSoLuongBan";
            this.txtSoLuongBan.Size = new System.Drawing.Size(302, 34);
            this.txtSoLuongBan.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 27);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mã Hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(851, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 27);
            this.label4.TabIndex = 16;
            this.label4.Text = "Số Lượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(851, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 27);
            this.label5.TabIndex = 17;
            this.label5.Text = "Thành Tiền:";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Location = new System.Drawing.Point(1037, 292);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(302, 34);
            this.txtThanhTien.TabIndex = 18;
            // 
            // cbbMaHDB
            // 
            this.cbbMaHDB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaHDB.FormattingEnabled = true;
            this.cbbMaHDB.Location = new System.Drawing.Point(315, 210);
            this.cbbMaHDB.Name = "cbbMaHDB";
            this.cbbMaHDB.Size = new System.Drawing.Size(302, 34);
            this.cbbMaHDB.TabIndex = 19;
            // 
            // cbbMaHang
            // 
            this.cbbMaHang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaHang.FormattingEnabled = true;
            this.cbbMaHang.Location = new System.Drawing.Point(315, 292);
            this.cbbMaHang.Name = "cbbMaHang";
            this.cbbMaHang.Size = new System.Drawing.Size(302, 34);
            this.cbbMaHang.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(70, 489);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(261, 26);
            this.label9.TabIndex = 38;
            this.label9.Text = "Nhập Mã Hóa Đơn Bán:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(356, 481);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(333, 34);
            this.txtTimKiem.TabIndex = 35;
            // 
            // btTimKiem
            // 
            this.btTimKiem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiem.Location = new System.Drawing.Point(816, 481);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(147, 36);
            this.btTimKiem.TabIndex = 36;
            this.btTimKiem.Text = "Tìm Kiếm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(173, 385);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(206, 56);
            this.btThem.TabIndex = 33;
            this.btThem.Text = "Tạo Mới";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSuaHD
            // 
            this.btSuaHD.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuaHD.Location = new System.Drawing.Point(728, 385);
            this.btSuaHD.Name = "btSuaHD";
            this.btSuaHD.Size = new System.Drawing.Size(194, 56);
            this.btSuaHD.TabIndex = 34;
            this.btSuaHD.Text = "Sửa ";
            this.btSuaHD.UseVisualStyleBackColor = true;
            this.btSuaHD.Click += new System.EventHandler(this.btSuaHD_Click);
            // 
            // xoa
            // 
            this.xoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa.Location = new System.Drawing.Point(996, 385);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(196, 56);
            this.xoa.TabIndex = 40;
            this.xoa.Text = "Xóa Hóa Đơn";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // btThemHDB
            // 
            this.btThemHDB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemHDB.Location = new System.Drawing.Point(453, 385);
            this.btThemHDB.Name = "btThemHDB";
            this.btThemHDB.Size = new System.Drawing.Size(208, 56);
            this.btThemHDB.TabIndex = 32;
            this.btThemHDB.Text = "Thêm";
            this.btThemHDB.UseVisualStyleBackColor = true;
            this.btThemHDB.Click += new System.EventHandler(this.btThemHDB_Click);
            // 
            // frmHoaDonBanChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::PhanMemVu.Properties.Resources._11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.btThemHDB);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btSuaHD);
            this.Controls.Add(this.cbbMaHang);
            this.Controls.Add(this.cbbMaHDB);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoLuongBan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgvhdbct);
            this.Name = "frmHoaDonBanChiTiet";
            this.Text = "Hóa Đơn Bán Chi Tiết";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHoaDonBanChiTiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvhdbct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvhdbct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoLuongBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.ComboBox cbbMaHDB;
        private System.Windows.Forms.ComboBox cbbMaHang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSuaHD;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button btThemHDB;
    }
}