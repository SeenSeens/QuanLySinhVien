namespace QuanLySinhVien
{
    partial class Main
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDiem = new System.Windows.Forms.Button();
            this.btnHocky = new System.Windows.Forms.Button();
            this.btnHocsinh = new System.Windows.Forms.Button();
            this.btnKhoi = new System.Windows.Forms.Button();
            this.btnLop = new System.Windows.Forms.Button();
            this.btnMonhoc = new System.Windows.Forms.Button();
            this.btnNienkhoa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNienkhoa);
            this.groupBox1.Controls.Add(this.btnMonhoc);
            this.groupBox1.Controls.Add(this.btnLop);
            this.groupBox1.Controls.Add(this.btnKhoi);
            this.groupBox1.Controls.Add(this.btnHocsinh);
            this.groupBox1.Controls.Add(this.btnHocky);
            this.groupBox1.Controls.Add(this.btnDiem);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vui lòng chọn";
            // 
            // btnDiem
            // 
            this.btnDiem.Location = new System.Drawing.Point(24, 35);
            this.btnDiem.Name = "btnDiem";
            this.btnDiem.Size = new System.Drawing.Size(75, 23);
            this.btnDiem.TabIndex = 0;
            this.btnDiem.Text = "Điểm";
            this.btnDiem.UseVisualStyleBackColor = true;
            this.btnDiem.Click += new System.EventHandler(this.btnDiem_Click);
            // 
            // btnHocky
            // 
            this.btnHocky.Location = new System.Drawing.Point(181, 35);
            this.btnHocky.Name = "btnHocky";
            this.btnHocky.Size = new System.Drawing.Size(75, 23);
            this.btnHocky.TabIndex = 1;
            this.btnHocky.Text = "Học kỳ";
            this.btnHocky.UseVisualStyleBackColor = true;
            this.btnHocky.Click += new System.EventHandler(this.btnHocky_Click);
            // 
            // btnHocsinh
            // 
            this.btnHocsinh.Location = new System.Drawing.Point(315, 34);
            this.btnHocsinh.Name = "btnHocsinh";
            this.btnHocsinh.Size = new System.Drawing.Size(75, 23);
            this.btnHocsinh.TabIndex = 2;
            this.btnHocsinh.Text = "Học sinh";
            this.btnHocsinh.UseVisualStyleBackColor = true;
            this.btnHocsinh.Click += new System.EventHandler(this.btnHocsinh_Click);
            // 
            // btnKhoi
            // 
            this.btnKhoi.Location = new System.Drawing.Point(24, 79);
            this.btnKhoi.Name = "btnKhoi";
            this.btnKhoi.Size = new System.Drawing.Size(75, 23);
            this.btnKhoi.TabIndex = 3;
            this.btnKhoi.Text = "Khối";
            this.btnKhoi.UseVisualStyleBackColor = true;
            this.btnKhoi.Click += new System.EventHandler(this.btnKhoi_Click);
            // 
            // btnLop
            // 
            this.btnLop.Location = new System.Drawing.Point(211, 79);
            this.btnLop.Name = "btnLop";
            this.btnLop.Size = new System.Drawing.Size(75, 23);
            this.btnLop.TabIndex = 4;
            this.btnLop.Text = "Lớp";
            this.btnLop.UseVisualStyleBackColor = true;
            this.btnLop.Click += new System.EventHandler(this.btnLop_Click);
            // 
            // btnMonhoc
            // 
            this.btnMonhoc.Location = new System.Drawing.Point(318, 89);
            this.btnMonhoc.Name = "btnMonhoc";
            this.btnMonhoc.Size = new System.Drawing.Size(75, 23);
            this.btnMonhoc.TabIndex = 5;
            this.btnMonhoc.Text = "Môn học";
            this.btnMonhoc.UseVisualStyleBackColor = true;
            this.btnMonhoc.Click += new System.EventHandler(this.btnMonhoc_Click);
            // 
            // btnNienkhoa
            // 
            this.btnNienkhoa.Location = new System.Drawing.Point(118, 108);
            this.btnNienkhoa.Name = "btnNienkhoa";
            this.btnNienkhoa.Size = new System.Drawing.Size(75, 23);
            this.btnNienkhoa.TabIndex = 6;
            this.btnNienkhoa.Text = "Niên khóa";
            this.btnNienkhoa.UseVisualStyleBackColor = true;
            this.btnNienkhoa.Click += new System.EventHandler(this.btnNienkhoa_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 178);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNienkhoa;
        private System.Windows.Forms.Button btnMonhoc;
        private System.Windows.Forms.Button btnLop;
        private System.Windows.Forms.Button btnKhoi;
        private System.Windows.Forms.Button btnHocsinh;
        private System.Windows.Forms.Button btnHocky;
        private System.Windows.Forms.Button btnDiem;
    }
}