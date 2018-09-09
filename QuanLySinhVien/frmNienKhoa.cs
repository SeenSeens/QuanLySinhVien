using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
namespace QuanLySinhVien
{
    public partial class frmNienKhoa : Form
    {
        public frmNienKhoa()
        {
            InitializeComponent();
        }

        private void frmNienKhoa_Load(object sender, EventArgs e)
        {
            LoadNienKhoa();
        }
        private void LoadNienKhoa()
        {
            List<NienKhoaDTO> nienKhoaDTO = NienKhoaBLL.LoadNienKhoa();
            dgvNienkhoa.DataSource = nienKhoaDTO;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTennk.Text == "")
            {
                MessageBox.Show("Bạn phải nhập vào niên khóa.");
                return;
            }
            NienKhoaDTO nienKhoaDTO = new NienKhoaDTO();
            nienKhoaDTO.STenNienKhoa = txtTennk.Text;
            nienKhoaDTO.SGhiChu = txtGhichu.Text;
            if (NienKhoaBLL.ThemNienKhoa(nienKhoaDTO))
            {
                MessageBox.Show("Thêm thành công.");
                LoadNienKhoa();
                return;
            }
            MessageBox.Show("Thêm thất bại.");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMank.Text == "")
            {
                MessageBox.Show("Bạn phải chọn niên khóa cần xóa.");
                return;
            }
            NienKhoaDTO nienKhoaDTO = new NienKhoaDTO();
            nienKhoaDTO.IMaNienKhoa = int.Parse(txtMank.Text);
            if(NienKhoaBLL.XoaNienKhoa(nienKhoaDTO))
            {
                MessageBox.Show("Xóa thành công.");
                LoadNienKhoa();
                return;
            }
            MessageBox.Show("Xóa thất bại.");
        }

        private void dgvNienkhoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvNienkhoa.SelectedRows[0];
            txtMank.Text = dr.Cells["IMaNienKhoa"].Value.ToString();
            txtTennk.Text = dr.Cells["STenNienKhoa"].Value.ToString();
            txtGhichu.Text = dr.Cells["SGhiChu"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMank.Text == "")
            {
                MessageBox.Show("Bạn phải chọn niên khóa cần sửa.");
                return;
            }
            NienKhoaDTO nienKhoaDTO = new NienKhoaDTO();
            nienKhoaDTO.IMaNienKhoa = int.Parse(txtMank.Text);
            nienKhoaDTO.STenNienKhoa = txtTennk.Text;
            nienKhoaDTO.SGhiChu = txtGhichu.Text;
            if (NienKhoaBLL.SuaNienKhoa(nienKhoaDTO))
            {
                MessageBox.Show("Sửa thành công.");
                LoadNienKhoa();
                return;
            }
            MessageBox.Show("Sửa thất bại.");
        }
    }
}
