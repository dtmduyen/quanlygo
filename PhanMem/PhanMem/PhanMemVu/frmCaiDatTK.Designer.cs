namespace PhanMemVu
{
    partial class frmCaiDatTK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaiDatTK));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.doiMK = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.xoaTK = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.luu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(856, 90);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÀI ĐẶT TÀI KHOẢN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(352, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài Khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(352, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật Khẩu";
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(566, 244);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(424, 35);
            this.txtTK.TabIndex = 0;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(566, 315);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(424, 35);
            this.txtMK.TabIndex = 1;
            // 
            // doiMK
            // 
            this.doiMK.Location = new System.Drawing.Point(583, 391);
            this.doiMK.Name = "doiMK";
            this.doiMK.Size = new System.Drawing.Size(203, 39);
            this.doiMK.TabIndex = 4;
            this.doiMK.Text = "Đổi Mật Khẩu";
            this.doiMK.UseVisualStyleBackColor = true;
            this.doiMK.Click += new System.EventHandler(this.doiMK_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(147, 391);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 39);
            this.button3.TabIndex = 3;
            this.button3.Text = "Tạo Mới";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // xoaTK
            // 
            this.xoaTK.Location = new System.Drawing.Point(862, 391);
            this.xoaTK.Name = "xoaTK";
            this.xoaTK.Size = new System.Drawing.Size(186, 39);
            this.xoaTK.TabIndex = 6;
            this.xoaTK.Text = "Xóa Tài Khoản";
            this.xoaTK.UseVisualStyleBackColor = true;
            this.xoaTK.Click += new System.EventHandler(this.xoaTK_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.Location = new System.Drawing.Point(62, 457);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1335, 269);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // luu
            // 
            this.luu.Location = new System.Drawing.Point(374, 391);
            this.luu.Name = "luu";
            this.luu.Size = new System.Drawing.Size(141, 39);
            this.luu.TabIndex = 2;
            this.luu.Text = "Thêm";
            this.luu.UseVisualStyleBackColor = true;
            this.luu.Click += new System.EventHandler(this.luu_Click);
            // 
            // frmCaiDatTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::PhanMemVu.Properties.Resources._111;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.luu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.xoaTK);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.doiMK);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmCaiDatTK";
            this.Text = "Tài Khoản";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCaiDatTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Button doiMK;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button xoaTK;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button luu;
    }
}