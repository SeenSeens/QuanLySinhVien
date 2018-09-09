namespace QuanLySinhVien
{
    partial class frmMonHoc
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
            this.dgvMonhoc = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTenmonhoc = new System.Windows.Forms.TextBox();
            this.cbKhoi = new System.Windows.Forms.ComboBox();
            this.cbHocky = new System.Windows.Forms.ComboBox();
            this.txtSotiet = new System.Windows.Forms.TextBox();
            this.txtMamonhoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonhoc)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Các Môn Học";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvMonhoc);
            this.panel1.Location = new System.Drawing.Point(12, 198);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 265);
            this.panel1.TabIndex = 1;
            // 
            // dgvMonhoc
            // 
            this.dgvMonhoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonhoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMonhoc.Location = new System.Drawing.Point(0, 0);
            this.dgvMonhoc.Name = "dgvMonhoc";
            this.dgvMonhoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonhoc.Size = new System.Drawing.Size(535, 265);
            this.dgvMonhoc.TabIndex = 0;
            this.dgvMonhoc.Click += new System.EventHandler(this.dgvMonhoc_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(12, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(535, 84);
            this.panel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTenmonhoc);
            this.groupBox1.Controls.Add(this.cbKhoi);
            this.groupBox1.Controls.Add(this.cbHocky);
            this.groupBox1.Controls.Add(this.txtSotiet);
            this.groupBox1.Controls.Add(this.txtMamonhoc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Môn Học";
            // 
            // txtTenmonhoc
            // 
            this.txtTenmonhoc.Location = new System.Drawing.Point(160, 41);
            this.txtTenmonhoc.Name = "txtTenmonhoc";
            this.txtTenmonhoc.Size = new System.Drawing.Size(131, 20);
            this.txtTenmonhoc.TabIndex = 8;
            // 
            // cbKhoi
            // 
            this.cbKhoi.FormattingEnabled = true;
            this.cbKhoi.Location = new System.Drawing.Point(387, 47);
            this.cbKhoi.Name = "cbKhoi";
            this.cbKhoi.Size = new System.Drawing.Size(121, 21);
            this.cbKhoi.TabIndex = 7;
            // 
            // cbHocky
            // 
            this.cbHocky.FormattingEnabled = true;
            this.cbHocky.Location = new System.Drawing.Point(387, 19);
            this.cbHocky.Name = "cbHocky";
            this.cbHocky.Size = new System.Drawing.Size(121, 21);
            this.cbHocky.TabIndex = 6;
            // 
            // txtSotiet
            // 
            this.txtSotiet.Location = new System.Drawing.Point(60, 50);
            this.txtSotiet.Name = "txtSotiet";
            this.txtSotiet.Size = new System.Drawing.Size(42, 20);
            this.txtSotiet.TabIndex = 5;
            // 
            // txtMamonhoc
            // 
            this.txtMamonhoc.Location = new System.Drawing.Point(92, 19);
            this.txtMamonhoc.Name = "txtMamonhoc";
            this.txtMamonhoc.ReadOnly = true;
            this.txtMamonhoc.Size = new System.Drawing.Size(42, 20);
            this.txtMamonhoc.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(335, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Khối";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Học kỳ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số tiết:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên môn học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã môn học:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Location = new System.Drawing.Point(268, 155);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(279, 37);
            this.panel3.TabIndex = 3;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(191, 7);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(102, 7);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(13, 7);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button7);
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Location = new System.Drawing.Point(12, 469);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(535, 37);
            this.panel4.TabIndex = 4;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(407, 7);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 3;
            this.button7.Text = ">>";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(290, 7);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 2;
            this.button6.Text = ">";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(173, 7);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "<";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(56, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "<<";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // frmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 518);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "frmMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMonHoc";
            this.Load += new System.EventHandler(this.frmMonHoc_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonhoc)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvMonhoc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenmonhoc;
        private System.Windows.Forms.ComboBox cbKhoi;
        private System.Windows.Forms.ComboBox cbHocky;
        private System.Windows.Forms.TextBox txtSotiet;
        private System.Windows.Forms.TextBox txtMamonhoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
    }
}