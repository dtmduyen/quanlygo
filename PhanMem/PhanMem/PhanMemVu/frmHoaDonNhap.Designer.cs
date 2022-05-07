namespace PhanMemVu
{
    partial class frmHoaDonNhap
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
            this.dtgvhdnct = new System.Windows.Forms.DataGridView();
            this.grBHoaDonBanChiTiet = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.tim = new System.Windows.Forms.Button();
            this.btHoaDonChiTiet = new System.Windows.Forms.Button();
            this.btThemHDB = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.btSuaHD = new System.Windows.Forms.Button();
            this.dtgvhdn = new System.Windows.Forms.DataGridView();
            this.cbbMaNV = new System.Windows.Forms.ComboBox();
            this.txtMaHDN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTongTienNhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grBHoaDonBan = new System.Windows.Forms.GroupBox();
            this.txtCK = new System.Windows.Forms.TextBox();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.cbbMaNCC = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpBan = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvhdnct)).BeginInit();
            this.grBHoaDonBanChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvhdn)).BeginInit();
            this.grBHoaDonBan.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvhdnct
            // 
            this.dtgvhdnct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvhdnct.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvhdnct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvhdnct.Location = new System.Drawing.Point(42, 62);
            this.dtgvhdnct.Name = "dtgvhdnct";
            this.dtgvhdnct.RowTemplate.Height = 24;
            this.dtgvhdnct.Size = new System.Drawing.Size(1576, 242);
            this.dtgvhdnct.TabIndex = 19;
            // 
            // grBHoaDonBanChiTiet
            // 
            this.grBHoaDonBanChiTiet.BackColor = System.Drawing.Color.PapayaWhip;
            this.grBHoaDonBanChiTiet.Controls.Add(this.dtgvhdnct);
            this.grBHoaDonBanChiTiet.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBHoaDonBanChiTiet.Location = new System.Drawing.Point(115, 652);
            this.grBHoaDonBanChiTiet.Name = "grBHoaDonBanChiTiet";
            this.grBHoaDonBanChiTiet.Size = new System.Drawing.Size(1672, 327);
            this.grBHoaDonBanChiTiet.TabIndex = 7;
            this.grBHoaDonBanChiTiet.TabStop = false;
            this.grBHoaDonBanChiTiet.Text = "Chi Tiết";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(75, 478);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 26);
            this.label9.TabIndex = 30;
            this.label9.Text = "Tìm Kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(205, 475);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(333, 34);
            this.txtTimKiem.TabIndex = 13;
            // 
            // tim
            // 
            this.tim.Location = new System.Drawing.Point(597, 474);
            this.tim.Name = "tim";
            this.tim.Size = new System.Drawing.Size(147, 36);
            this.tim.TabIndex = 14;
            this.tim.Text = "Tìm Kiếm";
            this.tim.UseVisualStyleBackColor = true;
            this.tim.Click += new System.EventHandler(this.tim_Click);
            // 
            // btHoaDonChiTiet
            // 
            this.btHoaDonChiTiet.Location = new System.Drawing.Point(1162, 403);
            this.btHoaDonChiTiet.Name = "btHoaDonChiTiet";
            this.btHoaDonChiTiet.Size = new System.Drawing.Size(273, 54);
            this.btHoaDonChiTiet.TabIndex = 12;
            this.btHoaDonChiTiet.Text = "Hóa Đơn Chi Tiết";
            this.btHoaDonChiTiet.UseVisualStyleBackColor = true;
            this.btHoaDonChiTiet.Click += new System.EventHandler(this.btHoaDonChiTiet_Click);
            // 
            // btThemHDB
            // 
            this.btThemHDB.Location = new System.Drawing.Point(322, 403);
            this.btThemHDB.Name = "btThemHDB";
            this.btThemHDB.Size = new System.Drawing.Size(212, 54);
            this.btThemHDB.TabIndex = 9;
            this.btThemHDB.Text = "Thêm Hóa Đơn";
            this.btThemHDB.UseVisualStyleBackColor = true;
            this.btThemHDB.Click += new System.EventHandler(this.btThemHDB_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(42, 403);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(210, 54);
            this.btThem.TabIndex = 8;
            this.btThem.Text = "Tạo Mới";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(872, 403);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(200, 54);
            this.xoa.TabIndex = 11;
            this.xoa.Text = "Xóa Hóa Đơn";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // btSuaHD
            // 
            this.btSuaHD.Location = new System.Drawing.Point(597, 403);
            this.btSuaHD.Name = "btSuaHD";
            this.btSuaHD.Size = new System.Drawing.Size(198, 54);
            this.btSuaHD.TabIndex = 9;
            this.btSuaHD.Text = "Sửa Hóa Đơn";
            this.btSuaHD.UseVisualStyleBackColor = true;
            this.btSuaHD.Click += new System.EventHandler(this.btSuaHD_Click);
            // 
            // dtgvhdn
            // 
            this.dtgvhdn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvhdn.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvhdn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvhdn.Location = new System.Drawing.Point(42, 153);
            this.dtgvhdn.Name = "dtgvhdn";
            this.dtgvhdn.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dtgvhdn.RowTemplate.Height = 24;
            this.dtgvhdn.Size = new System.Drawing.Size(1576, 234);
            this.dtgvhdn.TabIndex = 15;
            this.dtgvhdn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvhdn_CellClick);
            // 
            // cbbMaNV
            // 
            this.cbbMaNV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaNV.FormattingEnabled = true;
            this.cbbMaNV.Location = new System.Drawing.Point(241, 93);
            this.cbbMaNV.Name = "cbbMaNV";
            this.cbbMaNV.Size = new System.Drawing.Size(215, 34);
            this.cbbMaNV.TabIndex = 5;
            // 
            // txtMaHDN
            // 
            this.txtMaHDN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHDN.Location = new System.Drawing.Point(241, 46);
            this.txtMaHDN.Name = "txtMaHDN";
            this.txtMaHDN.ReadOnly = true;
            this.txtMaHDN.Size = new System.Drawing.Size(215, 34);
            this.txtMaHDN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mã Hóa Đơn Nhập:";
            // 
            // txtTongTienNhap
            // 
            this.txtTongTienNhap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTienNhap.Location = new System.Drawing.Point(1466, 100);
            this.txtTongTienNhap.Name = "txtTongTienNhap";
            this.txtTongTienNhap.ReadOnly = true;
            this.txtTongTienNhap.Size = new System.Drawing.Size(152, 34);
            this.txtTongTienNhap.TabIndex = 7;
            this.txtTongTienNhap.TabStop = false;
            this.txtTongTienNhap.TextChanged += new System.EventHandler(this.txtTongTienBan_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 27);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mã Nhân Viên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1323, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 27);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tổng Tiền:";
            // 
            // grBHoaDonBan
            // 
            this.grBHoaDonBan.BackColor = System.Drawing.Color.PapayaWhip;
            this.grBHoaDonBan.Controls.Add(this.txtCK);
            this.grBHoaDonBan.Controls.Add(this.txtVAT);
            this.grBHoaDonBan.Controls.Add(this.cbbMaNCC);
            this.grBHoaDonBan.Controls.Add(this.label8);
            this.grBHoaDonBan.Controls.Add(this.label7);
            this.grBHoaDonBan.Controls.Add(this.label4);
            this.grBHoaDonBan.Controls.Add(this.label9);
            this.grBHoaDonBan.Controls.Add(this.txtTimKiem);
            this.grBHoaDonBan.Controls.Add(this.tim);
            this.grBHoaDonBan.Controls.Add(this.btHoaDonChiTiet);
            this.grBHoaDonBan.Controls.Add(this.btThemHDB);
            this.grBHoaDonBan.Controls.Add(this.btThem);
            this.grBHoaDonBan.Controls.Add(this.xoa);
            this.grBHoaDonBan.Controls.Add(this.btSuaHD);
            this.grBHoaDonBan.Controls.Add(this.dtgvhdn);
            this.grBHoaDonBan.Controls.Add(this.cbbMaNV);
            this.grBHoaDonBan.Controls.Add(this.dtpBan);
            this.grBHoaDonBan.Controls.Add(this.label6);
            this.grBHoaDonBan.Controls.Add(this.txtMaHDN);
            this.grBHoaDonBan.Controls.Add(this.label1);
            this.grBHoaDonBan.Controls.Add(this.txtTongTienNhap);
            this.grBHoaDonBan.Controls.Add(this.label3);
            this.grBHoaDonBan.Controls.Add(this.label5);
            this.grBHoaDonBan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBHoaDonBan.Location = new System.Drawing.Point(115, 113);
            this.grBHoaDonBan.Name = "grBHoaDonBan";
            this.grBHoaDonBan.Size = new System.Drawing.Size(1672, 533);
            this.grBHoaDonBan.TabIndex = 6;
            this.grBHoaDonBan.TabStop = false;
            this.grBHoaDonBan.Text = "Hóa Đơn Nhập";
            // 
            // txtCK
            // 
            this.txtCK.Location = new System.Drawing.Point(1137, 42);
            this.txtCK.Name = "txtCK";
            this.txtCK.Size = new System.Drawing.Size(162, 34);
            this.txtCK.TabIndex = 3;
            // 
            // txtVAT
            // 
            this.txtVAT.Location = new System.Drawing.Point(1466, 42);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.Size = new System.Drawing.Size(152, 34);
            this.txtVAT.TabIndex = 4;
            // 
            // cbbMaNCC
            // 
            this.cbbMaNCC.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaNCC.FormattingEnabled = true;
            this.cbbMaNCC.Location = new System.Drawing.Point(700, 42);
            this.cbbMaNCC.Name = "cbbMaNCC";
            this.cbbMaNCC.Size = new System.Drawing.Size(203, 34);
            this.cbbMaNCC.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1380, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 27);
            this.label8.TabIndex = 33;
            this.label8.Text = "VAT:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(935, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 27);
            this.label7.TabIndex = 33;
            this.label7.Text = "Tỉ Suất Chiết Khấu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(500, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 27);
            this.label4.TabIndex = 33;
            this.label4.Text = "Mã Nhà Cung Cấp:";
            // 
            // dtpBan
            // 
            this.dtpBan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBan.Location = new System.Drawing.Point(700, 93);
            this.dtpBan.Name = "dtpBan";
            this.dtpBan.Size = new System.Drawing.Size(203, 34);
            this.dtpBan.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(500, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 27);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ngày Bán:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(691, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(660, 90);
            this.label2.TabIndex = 5;
            this.label2.Text = "HÓA ĐƠN NHẬP";
            // 
            // frmHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::PhanMemVu.Properties.Resources._11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.grBHoaDonBanChiTiet);
            this.Controls.Add(this.grBHoaDonBan);
            this.Controls.Add(this.label2);
            this.Name = "frmHoaDonNhap";
            this.Text = "Hóa Đơn Nhập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHoaDonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvhdnct)).EndInit();
            this.grBHoaDonBanChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvhdn)).EndInit();
            this.grBHoaDonBan.ResumeLayout(false);
            this.grBHoaDonBan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvhdnct;
        private System.Windows.Forms.GroupBox grBHoaDonBanChiTiet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button tim;
        private System.Windows.Forms.Button btHoaDonChiTiet;
        private System.Windows.Forms.Button btThemHDB;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button btSuaHD;
        private System.Windows.Forms.DataGridView dtgvhdn;
        private System.Windows.Forms.ComboBox cbbMaNV;
        private System.Windows.Forms.TextBox txtMaHDN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTongTienNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grBHoaDonBan;
        private System.Windows.Forms.ComboBox cbbMaNCC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpBan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCK;
        private System.Windows.Forms.TextBox txtVAT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}