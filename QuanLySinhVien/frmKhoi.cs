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
    public partial class frmKhoi : Form
    {
        public frmKhoi()
        {
            InitializeComponent();
        }

        private void frmKhoi_Load(object sender, EventArgs e)
        {
            LoadKhoi();
        }
        private void LoadKhoi()
        {
            List<KhoiDTO> lstkhoi = KhoiBLL.LoadKhoi();
            dgvKhoi.DataSource = lstkhoi;
            // Đặt lại tên cột
            dgvKhoi.Columns["IMaKhoi"].HeaderText = "Mã khối";
            dgvKhoi.Columns["STenKhoi"].HeaderText = "Tên khối";
            dgvKhoi.Columns["SGhiChu"].HeaderText = "Ghi chú";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtTenkhoi.Text=="")
            {
                MessageBox.Show("Bạn phải nhập vào khối học");
                return;
            }
            KhoiDTO khoiDTO = new KhoiDTO();
            khoiDTO.STenKhoi = txtTenkhoi.Text;
            khoiDTO.SGhiChu = txtGhichu.Text;
            if(KhoiBLL.ThemKhoi(khoiDTO))
            {
                MessageBox.Show("Thêm thành công.");
                LoadKhoi();
                return;
            } else { MessageBox.Show("Thêm thất bại."); }
        }

        private void dgvKhoi_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvKhoi.SelectedRows[0];
            txtMakhoi.Text = dr.Cells["IMaKhoi"].Value.ToString();
            txtTenkhoi.Text = dr.Cells["STenKhoi"].Value.ToString();
            txtGhichu.Text = dr.Cells["SGhiChu"].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMakhoi.Text == "")
            {
                MessageBox.Show("Bạn phải chọn khối cần xóa.");
                return;
            }
            KhoiDTO khoiDTO = new KhoiDTO();
            khoiDTO.IMaKhoi = int.Parse(txtMakhoi.Text);
            if(KhoiBLL.XoaKhoi(khoiDTO))
            {
                MessageBox.Show("Xóa thành công.");
                LoadKhoi();
                return;
            } else { MessageBox.Show("Xóa thất bại."); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMakhoi.Text == "")
            {
                MessageBox.Show("Bạn phải chọn khối cần Sửa.");
                return;
            }
            KhoiDTO khoiDTO = new KhoiDTO();
            khoiDTO.IMaKhoi = int.Parse(txtMakhoi.Text);
            khoiDTO.STenKhoi = txtTenkhoi.Text;
            khoiDTO.SGhiChu = txtGhichu.Text;
            if (KhoiBLL.SuaKhoi(khoiDTO))
            {
                MessageBox.Show("Sửa thành công.");
                LoadKhoi();
                return;
            }
            else { MessageBox.Show("Sửa thất bại."); }
        }
    }
}
