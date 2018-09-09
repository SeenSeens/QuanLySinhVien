namespace QuanLySinhVien
{
    partial class SinhVien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cblop = new System.Windows.Forms.ComboBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.radnu = new System.Windows.Forms.RadioButton();
            this.radnam = new System.Windows.Forms.RadioButton();
            this.dtpngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtmasv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvsinhvien = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnrf = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsinhvien)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý sinh viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cblop);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.radnu);
            this.groupBox1.Controls.Add(this.radnam);
            this.groupBox1.Controls.Add(this.dtpngaysinh);
            this.groupBox1.Controls.Add(this.txthoten);
            this.groupBox1.Controls.Add(this.txtmasv);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 113);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // cblop
            // 
            this.cblop.FormattingEnabled = true;
            this.cblop.Location = new System.Drawing.Point(478, 53);
            this.cblop.Name = "cblop";
            this.cblop.Size = new System.Drawing.Size(121, 21);
            this.cblop.TabIndex = 6;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(478, 83);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(251, 20);
            this.txtdiachi.TabIndex = 7;
            this.txtdiachi.Click += new System.EventHandler(this.txtdiachi_Click);
            // 
            // radnu
            // 
            this.radnu.AutoSize = true;
            this.radnu.Location = new System.Drawing.Point(553, 24);
            this.radnu.Name = "radnu";
            this.radnu.Size = new System.Drawing.Size(39, 17);
            this.radnu.TabIndex = 5;
            this.radnu.Text = "Nữ";
            this.radnu.UseVisualStyleBackColor = true;
            // 
            // radnam
            // 
            this.radnam.AutoSize = true;
            this.radnam.Checked = true;
            this.radnam.Location = new System.Drawing.Point(495, 24);
            this.radnam.Name = "radnam";
            this.radnam.Size = new System.Drawing.Size(47, 17);
            this.radnam.TabIndex = 4;
            this.radnam.TabStop = true;
            this.radnam.Text = "Nam";
            this.radnam.UseVisualStyleBackColor = true;
            // 
            // dtpngaysinh
            // 
            this.dtpngaysinh.Location = new System.Drawing.Point(80, 80);
            this.dtpngaysinh.Name = "dtpngaysinh";
            this.dtpngaysinh.Size = new System.Drawing.Size(205, 20);
            this.dtpngaysinh.TabIndex = 3;
            this.dtpngaysinh.UseWaitCursor = true;
            this.dtpngaysinh.Value = new System.DateTime(2018, 8, 24, 0, 0, 0, 0);
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(80, 53);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(152, 20);
            this.txthoten.TabIndex = 2;
            this.txthoten.Click += new System.EventHandler(this.txthoten_Click);
            // 
            // txtmasv
            // 
            this.txtmasv.Location = new System.Drawing.Point(80, 23);
            this.txtmasv.Name = "txtmasv";
            this.txtmasv.ReadOnly = true;
            this.txtmasv.Size = new System.Drawing.Size(152, 20);
            this.txtmasv.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(414, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(414, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Lớp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã SV";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvsinhvien);
            this.panel1.Location = new System.Drawing.Point(12, 239);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 214);
            this.panel1.TabIndex = 2;
            // 
            // dgvsinhvien
            // 
            this.dgvsinhvien.AllowUserToAddRows = false;
            this.dgvsinhvien.AllowUserToOrderColumns = true;
            this.dgvsinhvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvsinhvien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvsinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsinhvien.Location = new System.Drawing.Point(3, 3);
            this.dgvsinhvien.Name = "dgvsinhvien";
            this.dgvsinhvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvsinhvien.Size = new System.Drawing.Size(616, 208);
            this.dgvsinhvien.TabIndex = 0;
            this.dgvsinhvien.Click += new System.EventHandler(this.dgvsinhvien_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnsua);
            this.panel2.Controls.Add(this.btnrf);
            this.panel2.Controls.Add(this.btnthem);
            this.panel2.Controls.Add(this.btnxoa);
            this.panel2.Controls.Add(this.btnthoat);
            this.panel2.Location = new System.Drawing.Point(637, 239);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 214);
            this.panel2.TabIndex = 3;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(3, 146);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(65, 65);
            this.btnsua.TabIndex = 10;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnrf
            // 
            this.btnrf.Location = new System.Drawing.Point(72, 35);
            this.btnrf.Name = "btnrf";
            this.btnrf.Size = new System.Drawing.Size(65, 65);
            this.btnrf.TabIndex = 8;
            this.btnrf.Text = "Refesh";
            this.btnrf.UseVisualStyleBackColor = true;
            this.btnrf.Click += new System.EventHandler(this.btnrf_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(3, 4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(65, 65);
            this.btnthem.TabIndex = 8;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(3, 75);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(65, 65);
            this.btnxoa.TabIndex = 9;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(72, 106);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(65, 65);
            this.btnthoat.TabIndex = 13;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btntimkiem);
            this.groupBox2.Controls.Add(this.txttimkiem);
            this.groupBox2.Location = new System.Drawing.Point(16, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(762, 64);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // btntimkiem
            // 
            this.btntimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.Location = new System.Drawing.Point(470, 16);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(145, 34);
            this.btntimkiem.TabIndex = 1;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.Location = new System.Drawing.Point(90, 26);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(315, 22);
            this.txttimkiem.TabIndex = 0;
            this.txttimkiem.Text = "Nhập vào tên sinh viên bạn cần tìm...";
            this.txttimkiem.Click += new System.EventHandler(this.txttimkiem_Click);
            // 
            // SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "SinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sinh Viên";
            this.Load += new System.EventHandler(this.frmquanlysinhvien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsinhvien)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.RadioButton radnu;
        private System.Windows.Forms.RadioButton radnam;
        private System.Windows.Forms.DateTimePicker dtpngaysinh;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtmasv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.DataGridView dgvsinhvien;
        private System.Windows.Forms.ComboBox cblop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btnrf;
    }
}

