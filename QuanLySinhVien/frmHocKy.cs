using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class frmHocKy : Form
    {
        public frmHocKy()
        {
            InitializeComponent();
        }

        private void frmHocKy_Load(object sender, EventArgs e)
        {
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            LoadHocKy();
        }

        private void LoadHocKy()
        {
            List<HocKyDTO> lstHK = HocKyBLL.LoadHocKy();
            dgvHK.DataSource = lstHK;
            dgvHK.Columns["IMaHK"].HeaderText = "Mã học kỳ";
            dgvHK.Columns["STenHK"].HeaderText = "Tên học kỳ";
            dgvHK.Columns["SGhiChu"].HeaderText = "Ghi chú";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtTenhk.Text=="")
            {
                MessageBox.Show("Bạn phải nhập vào học ky.");
                return;
            }
            HocKyDTO hk = new HocKyDTO();
            hk.STenHK = txtTenhk.Text;
            hk.SGhiChu = txtGhichu.Text;
            if(HocKyBLL.ThemHocKy(hk))
            {
                MessageBox.Show("Thêm thành công.");
                LoadHocKy();
                return;
            }
            else { MessageBox.Show("Thêm thất bại."); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(txtTenhk.Text=="")
            {
                MessageBox.Show("Bạn phải nhập vào học kỳ.");
                return;
            }
            HocKyDTO hk = new HocKyDTO();
            hk.IMaHK = int.Parse(txtMahk.Text);
            hk.STenHK = txtTenhk.Text;
            hk.SGhiChu = txtGhichu.Text;
            if(HocKyBLL.SuaHocKy(hk))
            {
                MessageBox.Show("Sửa thành công.");
                LoadHocKy();
                return;
            } else { MessageBox.Show("Sửa thất bại."); }
        }

        private void dgvHK_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvHK.SelectedRows[0];
            txtMahk.Text = dr.Cells["IMaHK"].Value.ToString();
            txtTenhk.Text = dr.Cells["STenHK"].Value.ToString();
            txtGhichu.Text = dr.Cells["SGhiChu"].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txtMahk.Text=="")
            {
                MessageBox.Show("Bạn phải chọn học kỳ cần xóa.");
                return;
            }
            HocKyDTO hk = new HocKyDTO();
            hk.IMaHK = int.Parse(txtMahk.Text);
            if(HocKyBLL.XoaHocKy(hk))
            {
                MessageBox.Show("Xóa thành công.");
                LoadHocKy();
                return;
            } else { MessageBox.Show("Xóa thất bại."); }
        }
    }
}
