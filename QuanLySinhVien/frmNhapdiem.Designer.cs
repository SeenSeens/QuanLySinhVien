namespace QuanLySinhVien
{
    partial class frmNhapdiem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbNhapDiem = new System.Windows.Forms.GroupBox();
            this.cbMonHoc = new System.Windows.Forms.ComboBox();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbKhoi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNienKhoa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvBangDiem = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gbNhapDiem.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangDiem)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Điểm Môn Học";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.gbNhapDiem);
            this.panel1.Location = new System.Drawing.Point(12, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 474);
            this.panel1.TabIndex = 1;
            // 
            // gbNhapDiem
            // 
            this.gbNhapDiem.Controls.Add(this.cbMonHoc);
            this.gbNhapDiem.Controls.Add(this.cbHocKy);
            this.gbNhapDiem.Controls.Add(this.label6);
            this.gbNhapDiem.Controls.Add(this.label5);
            this.gbNhapDiem.Controls.Add(this.cbLop);
            this.gbNhapDiem.Controls.Add(this.label4);
            this.gbNhapDiem.Controls.Add(this.cbKhoi);
            this.gbNhapDiem.Controls.Add(this.label3);
            this.gbNhapDiem.Controls.Add(this.cbNienKhoa);
            this.gbNhapDiem.Controls.Add(this.label2);
            this.gbNhapDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbNhapDiem.Location = new System.Drawing.Point(0, 0);
            this.gbNhapDiem.Name = "gbNhapDiem";
            this.gbNhapDiem.Size = new System.Drawing.Size(151, 474);
            this.gbNhapDiem.TabIndex = 0;
            this.gbNhapDiem.TabStop = false;
            this.gbNhapDiem.Text = "Nhập Điểm Theo";
            // 
            // cbMonHoc
            // 
            this.cbMonHoc.FormattingEnabled = true;
            this.cbMonHoc.Location = new System.Drawing.Point(6, 385);
            this.cbMonHoc.Name = "cbMonHoc";
            this.cbMonHoc.Size = new System.Drawing.Size(139, 21);
            this.cbMonHoc.TabIndex = 9;
            // 
            // cbHocKy
            // 
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Location = new System.Drawing.Point(6, 306);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(139, 21);
            this.cbHocKy.TabIndex = 8;
            this.cbHocKy.SelectedIndexChanged += new System.EventHandler(this.cbHocKy_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Môn Học";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Học Kỳ";
            // 
            // cbLop
            // 
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(6, 225);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(139, 21);
            this.cbLop.TabIndex = 5;
            this.cbLop.SelectedIndexChanged += new System.EventHandler(this.cbLop_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lớp";
            // 
            // cbKhoi
            // 
            this.cbKhoi.FormattingEnabled = true;
            this.cbKhoi.Location = new System.Drawing.Point(6, 146);
            this.cbKhoi.Name = "cbKhoi";
            this.cbKhoi.Size = new System.Drawing.Size(139, 21);
            this.cbKhoi.TabIndex = 3;
            this.cbKhoi.SelectedIndexChanged += new System.EventHandler(this.cbKhoi_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khối";
            // 
            // cbNienKhoa
            // 
            this.cbNienKhoa.FormattingEnabled = true;
            this.cbNienKhoa.Location = new System.Drawing.Point(6, 65);
            this.cbNienKhoa.Name = "cbNienKhoa";
            this.cbNienKhoa.Size = new System.Drawing.Size(139, 21);
            this.cbNienKhoa.TabIndex = 1;
            this.cbNienKhoa.SelectedIndexChanged += new System.EventHandler(this.cbNienKhoa_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Niên Khóa";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Location = new System.Drawing.Point(169, 486);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(647, 61);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.dgvBangDiem);
            this.panel3.Location = new System.Drawing.Point(169, 181);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(647, 299);
            this.panel3.TabIndex = 3;
            // 
            // dgvBangDiem
            // 
            this.dgvBangDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBangDiem.Location = new System.Drawing.Point(0, 0);
            this.dgvBangDiem.Name = "dgvBangDiem";
            this.dgvBangDiem.Size = new System.Drawing.Size(647, 299);
            this.dgvBangDiem.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(169, 73);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(647, 102);
            this.panel4.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(389, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Học Kỳ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(389, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Lớp:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Niên Khóa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Bảng Điểm Môn:";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(15, 19);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmNhapdiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 559);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "frmNhapdiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Điểm";
            this.Load += new System.EventHandler(this.frmNhapdiem_Load);
            this.panel1.ResumeLayout(false);
            this.gbNhapDiem.ResumeLayout(false);
            this.gbNhapDiem.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangDiem)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox gbNhapDiem;
        private System.Windows.Forms.ComboBox cbMonHoc;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbKhoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbNienKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvBangDiem;
        private System.Windows.Forms.Button btnLuu;
    }
}