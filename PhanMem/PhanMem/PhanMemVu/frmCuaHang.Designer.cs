namespace PhanMemVu
{
    partial class frmCuaHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaThue = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtGC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSTK = new System.Windows.Forms.TextBox();
            this.txtTenNH = new System.Windows.Forms.TextBox();
            this.xoa = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.btThemHDB = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btSuaHD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(649, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 90);
            this.label1.TabIndex = 1;
            this.label1.Text = "CỬA HÀNG";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 572);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1428, 202);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(214, 182);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(320, 34);
            this.txtMaNV.TabIndex = 1;
            this.txtMaNV.TextChanged += new System.EventHandler(this.txtTenKH_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã Nhân Viên:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên Nhân Viên:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(214, 243);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(320, 34);
            this.txtTenNV.TabIndex = 2;
            this.txtTenNV.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(12, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Địa Chỉ Cửa Hàng:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(214, 310);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(320, 34);
            this.txtDiaChi.TabIndex = 3;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(584, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã Thuế:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(584, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 27);
            this.label6.TabIndex = 4;
            this.label6.Text = "Số Điện Thoại Cửa Hàng:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(584, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 27);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tình Trạng:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtMaThue
            // 
            this.txtMaThue.Location = new System.Drawing.Point(821, 182);
            this.txtMaThue.Name = "txtMaThue";
            this.txtMaThue.Size = new System.Drawing.Size(212, 34);
            this.txtMaThue.TabIndex = 4;
            this.txtMaThue.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(821, 243);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(212, 34);
            this.txtSDT.TabIndex = 5;
            this.txtSDT.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtGC
            // 
            this.txtGC.Location = new System.Drawing.Point(821, 310);
            this.txtGC.Name = "txtGC";
            this.txtGC.Size = new System.Drawing.Size(212, 34);
            this.txtGC.TabIndex = 8;
            this.txtGC.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(1114, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(252, 27);
            this.label8.TabIndex = 4;
            this.label8.Text = "Số Tài Khoản Cửa Hàng:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(1114, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 27);
            this.label9.TabIndex = 4;
            this.label9.Text = "Tên Ngân Hàng:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtSTK
            // 
            this.txtSTK.Location = new System.Drawing.Point(1334, 182);
            this.txtSTK.Name = "txtSTK";
            this.txtSTK.Size = new System.Drawing.Size(192, 34);
            this.txtSTK.TabIndex = 6;
            // 
            // txtTenNH
            // 
            this.txtTenNH.Location = new System.Drawing.Point(1334, 243);
            this.txtTenNH.Name = "txtTenNH";
            this.txtTenNH.Size = new System.Drawing.Size(192, 34);
            this.txtTenNH.TabIndex = 7;
            // 
            // xoa
            // 
            this.xoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa.Location = new System.Drawing.Point(1008, 406);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(196, 56);
            this.xoa.TabIndex = 12;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(82, 510);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(230, 26);
            this.label10.TabIndex = 46;
            this.label10.Text = "Nhập Mã Nhân Viên:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(368, 502);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(333, 34);
            this.txtTimKiem.TabIndex = 12;
            // 
            // btTimKiem
            // 
            this.btTimKiem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiem.Location = new System.Drawing.Point(828, 502);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(147, 36);
            this.btTimKiem.TabIndex = 13;
            this.btTimKiem.Text = "Tìm Kiếm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // btThemHDB
            // 
            this.btThemHDB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemHDB.Location = new System.Drawing.Point(465, 406);
            this.btThemHDB.Name = "btThemHDB";
            this.btThemHDB.Size = new System.Drawing.Size(208, 56);
            this.btThemHDB.TabIndex = 10;
            this.btThemHDB.Text = "Thêm";
            this.btThemHDB.UseVisualStyleBackColor = true;
            this.btThemHDB.Click += new System.EventHandler(this.btThemHDB_Click);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(185, 406);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(206, 56);
            this.btThem.TabIndex = 9;
            this.btThem.Text = "Tạo Mới";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSuaHD
            // 
            this.btSuaHD.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuaHD.Location = new System.Drawing.Point(740, 406);
            this.btSuaHD.Name = "btSuaHD";
            this.btSuaHD.Size = new System.Drawing.Size(194, 56);
            this.btSuaHD.TabIndex = 11;
            this.btSuaHD.Text = "Sửa ";
            this.btSuaHD.UseVisualStyleBackColor = true;
            this.btSuaHD.Click += new System.EventHandler(this.btSuaHD_Click);
            // 
            // frmCuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::PhanMemVu.Properties.Resources._11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.btThemHDB);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btSuaHD);
            this.Controls.Add(this.txtGC);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenNH);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtSTK);
            this.Controls.Add(this.txtMaThue);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmCuaHang";
            this.Text = "Cửa Hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCuaHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaThue;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtGC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSTK;
        private System.Windows.Forms.TextBox txtTenNH;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Button btThemHDB;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSuaHD;
    }
}