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
    public partial class frmMonHoc : Form
    {
        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            LoadMonHoc();
            LoadcbHK();
            LoadcbK();
        }
        private void LoadMonHoc()
        {
            List<MonHocDTO> mh = MonHocBLL.LoadMonHoc();
            dgvMonhoc.DataSource = mh;
            dgvMonhoc.Columns["IMaMH"].HeaderText = "Mã môn học";
            dgvMonhoc.Columns["IMaMH"].Visible = false;
            dgvMonhoc.Columns["STenMH"].HeaderText = "Tên môn học";
            dgvMonhoc.Columns["ISoTiet"].HeaderText = "Số tiết";
            dgvMonhoc.Columns["IMaHK"].Visible = false;
            dgvMonhoc.Columns["STenHK"].HeaderText = "Tên học kỳ";
            dgvMonhoc.Columns["IMaKhoi"].Visible = false;
            dgvMonhoc.Columns["STenKhoi"].HeaderText = "Tên khối";
        }
        private void LoadcbHK()
        {
            List<HocKyDTO> hk = HocKyBLL.LoadcbHocKy();
            cbHocky.DataSource = hk;
            cbHocky.DisplayMember = "STenHK"; // Giá trị cần hiển thị
            cbHocky.ValueMember = "IMaHK"; // Giá trị cần lấy
        }
        private void LoadcbK()
        {
            List<KhoiDTO> k = KhoiBLL.LoadcbKhoi();
            cbKhoi.DataSource = k;
            cbKhoi.DisplayMember = "STenKhoi"; // Giá trị cần hiển thị
            cbKhoi.ValueMember = "IMaKhoi"; // Giá trị cần lấy
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenmonhoc.Text == "" || txtSotiet.Text == "")
            {
                MessageBox.Show("Bạn phải nhập dữ liệu");
                return;
            }
            MonHocDTO mh = new MonHocDTO();
            mh.STenMH = txtTenmonhoc.Text;
            mh.ISoTiet = int.Parse(txtSotiet.Text);
            mh.IMaHK = int.Parse(cbHocky.SelectedValue.ToString());
            mh.IMaKhoi = int.Parse(cbKhoi.SelectedValue.ToString());
            if (MonHocBLL.ThemMonHoc(mh))
            {
                MessageBox.Show("Thêm thành công.");
                LoadMonHoc();
                return;
            }
            MessageBox.Show("Thêm thất bại.");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMamonhoc.Text == "")
            {
                MessageBox.Show("Bạn phải chọn môn cần xóa");
                return;
            }
            MonHocDTO mh = new MonHocDTO();
            mh.IMaMH = int.Parse(txtMamonhoc.Text);
            if (MonHocBLL.XoaMonHoc(mh))
            {
                MessageBox.Show("Xóa thành công.");
                LoadMonHoc();
                return;
            }
            MessageBox.Show("Xóa thất bại.");
        }

        private void dgvMonhoc_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvMonhoc.SelectedRows[0];
            txtMamonhoc.Text = dr.Cells["IMaMH"].Value.ToString();
            txtTenmonhoc.Text = dr.Cells["STenMH"].Value.ToString();
            txtSotiet.Text = dr.Cells["ISoTiet"].Value.ToString();
            cbHocky.SelectedValue = int.Parse(dr.Cells["IMaHK"].Value.ToString());
            cbKhoi.SelectedValue = int.Parse(dr.Cells["IMaKhoi"].Value.ToString());
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MonHocDTO mh = new MonHocDTO();
            mh.IMaMH = int.Parse(txtMamonhoc.Text);
            mh.STenMH = txtTenmonhoc.Text;
            mh.ISoTiet = int.Parse(txtSotiet.Text);
            mh.IMaHK = int.Parse(cbHocky.SelectedValue.ToString());
            mh.IMaKhoi = int.Parse(cbKhoi.SelectedValue.ToString());
            if (MonHocBLL.SuaMonHoc(mh))
            {
                MessageBox.Show("Sửa thành công.");
                LoadMonHoc();
                return;
            }
            MessageBox.Show("Sửa thất bại.");
        }
    }
}
