namespace PhanMemVu
{
    partial class frmHoaDonNhapChiTiet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvhdnct = new System.Windows.Forms.DataGridView();
            this.btXoaHD = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.btThemHDN = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btSuaHD = new System.Windows.Forms.Button();
            this.cbbMaHang = new System.Windows.Forms.ComboBox();
            this.cbbMaHDNCT = new System.Windows.Forms.ComboBox();
            this.txtDonGiaNhap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoLuongNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHinhThuc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvhdnct)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvhdnct
            // 
            this.dtgvhdnct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvhdnct.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvhdnct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvhdnct.Location = new System.Drawing.Point(44, 570);
            this.dtgvhdnct.Name = "dtgvhdnct";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvhdnct.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvhdnct.RowTemplate.Height = 24;
            this.dtgvhdnct.Size = new System.Drawing.Size(1794, 368);
            this.dtgvhdnct.TabIndex = 0;
            this.dtgvhdnct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvhdnct_CellClick);
            // 
            // btXoaHD
            // 
            this.btXoaHD.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaHD.Location = new System.Drawing.Point(960, 404);
            this.btXoaHD.Name = "btXoaHD";
            this.btXoaHD.Size = new System.Drawing.Size(183, 55);
            this.btXoaHD.TabIndex = 8;
            this.btXoaHD.Text = "Xóa Hóa Đơn";
            this.btXoaHD.UseVisualStyleBackColor = true;
            this.btXoaHD.Click += new System.EventHandler(this.xoa_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 486);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(275, 26);
            this.label9.TabIndex = 54;
            this.label9.Text = "Nhập Mã Hóa Đơn Nhập:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(331, 478);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(333, 34);
            this.txtTimKiem.TabIndex = 9;
            // 
            // btTimKiem
            // 
            this.btTimKiem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiem.Location = new System.Drawing.Point(768, 478);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(147, 36);
            this.btTimKiem.TabIndex = 10;
            this.btTimKiem.Text = "Tìm Kiếm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // btThemHDN
            // 
            this.btThemHDN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemHDN.Location = new System.Drawing.Point(417, 404);
            this.btThemHDN.Name = "btThemHDN";
            this.btThemHDN.Size = new System.Drawing.Size(201, 55);
            this.btThemHDN.TabIndex = 6;
            this.btThemHDN.Text = "Thêm Hóa Đơn";
            this.btThemHDN.UseVisualStyleBackColor = true;
            this.btThemHDN.Click += new System.EventHandler(this.btThemHDB_Click);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(137, 404);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(193, 55);
            this.btThem.TabIndex = 5;
            this.btThem.Text = "Tạo Mới";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSuaHD
            // 
            this.btSuaHD.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuaHD.Location = new System.Drawing.Point(692, 404);
            this.btSuaHD.Name = "btSuaHD";
            this.btSuaHD.Size = new System.Drawing.Size(181, 55);
            this.btSuaHD.TabIndex = 7;
            this.btSuaHD.Text = "Sửa Hóa Đơn";
            this.btSuaHD.UseVisualStyleBackColor = true;
            this.btSuaHD.Click += new System.EventHandler(this.btSuaHD_Click);
            // 
            // cbbMaHang
            // 
            this.cbbMaHang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaHang.FormattingEnabled = true;
            this.cbbMaHang.Location = new System.Drawing.Point(267, 289);
            this.cbbMaHang.Name = "cbbMaHang";
            this.cbbMaHang.Size = new System.Drawing.Size(302, 34);
            this.cbbMaHang.TabIndex = 2;
            // 
            // cbbMaHDNCT
            // 
            this.cbbMaHDNCT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaHDNCT.FormattingEnabled = true;
            this.cbbMaHDNCT.Location = new System.Drawing.Point(267, 207);
            this.cbbMaHDNCT.Name = "cbbMaHDNCT";
            this.cbbMaHDNCT.Size = new System.Drawing.Size(302, 34);
            this.cbbMaHDNCT.TabIndex = 1;
            // 
            // txtDonGiaNhap
            // 
            this.txtDonGiaNhap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGiaNhap.Location = new System.Drawing.Point(989, 207);
            this.txtDonGiaNhap.Name = "txtDonGiaNhap";
            this.txtDonGiaNhap.Size = new System.Drawing.Size(302, 34);
            this.txtDonGiaNhap.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(803, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 27);
            this.label5.TabIndex = 45;
            this.label5.Text = "Đơn Giá Nhập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(803, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 27);
            this.label4.TabIndex = 44;
            this.label4.Text = "Số Lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 27);
            this.label3.TabIndex = 43;
            this.label3.Text = "Mã Hàng:";
            // 
            // txtSoLuongNhap
            // 
            this.txtSoLuongNhap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongNhap.Location = new System.Drawing.Point(989, 296);
            this.txtSoLuongNhap.Name = "txtSoLuongNhap";
            this.txtSoLuongNhap.Size = new System.Drawing.Size(302, 34);
            this.txtSoLuongNhap.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 27);
            this.label1.TabIndex = 41;
            this.label1.Text = "Mã Hóa Đơn Nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(434, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1036, 90);
            this.label2.TabIndex = 57;
            this.label2.Text = "HÓA ĐƠN NHẬP CHI TIẾT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1505, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 27);
            this.label6.TabIndex = 58;
            this.label6.Text = "Hình Thức:";
            // 
            // txtHinhThuc
            // 
            this.txtHinhThuc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHinhThuc.Location = new System.Drawing.Point(1669, 207);
            this.txtHinhThuc.Name = "txtHinhThuc";
            this.txtHinhThuc.Size = new System.Drawing.Size(169, 34);
            this.txtHinhThuc.TabIndex = 59;
            // 
            // frmHoaDonNhapChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::PhanMemVu.Properties.Resources._11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1909, 1052);
            this.Controls.Add(this.txtHinhThuc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btXoaHD);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.btThemHDN);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btSuaHD);
            this.Controls.Add(this.cbbMaHang);
            this.Controls.Add(this.cbbMaHDNCT);
            this.Controls.Add(this.txtDonGiaNhap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoLuongNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvhdnct);
            this.Name = "frmHoaDonNhapChiTiet";
            this.Text = "Hóa Đơn Nhập Chi Tiết";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHoaDonNhapChiTiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvhdnct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvhdnct;
        private System.Windows.Forms.Button btXoaHD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Button btThemHDN;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSuaHD;
        private System.Windows.Forms.ComboBox cbbMaHang;
        private System.Windows.Forms.ComboBox cbbMaHDNCT;
        private System.Windows.Forms.TextBox txtDonGiaNhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoLuongNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHinhThuc;
    }
}