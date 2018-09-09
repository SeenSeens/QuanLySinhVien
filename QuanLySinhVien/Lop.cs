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
    public partial class Lop : Form
    {
        public Lop()
        {
            InitializeComponent();
            
        }

        private void Lop_Load(object sender, EventArgs e)
        {
            LoadLopHoc();
            LoadcbNienKhoa();
            LoadcbKhoi();
        }

        private void LoadLopHoc()
        {
            List<LopDTO> lstLop = LopBLL.LoadLop();
            dgvLop.DataSource = lstLop;
            // Đặt lại tên cho cột
            dgvLop.Columns["IMaLop"].HeaderText = "Mã lớp";
            dgvLop.Columns["STenLop"].HeaderText = "Tên lớp";
            dgvLop.Columns["ISiSo"].HeaderText = "Sỉ số";
            dgvLop.Columns["IMaNienKhoa"].Visible = false;
            dgvLop.Columns["STenNienKhoa"].HeaderText = "Tên niên khóa";
            dgvLop.Columns["IMaKhoi"].Visible = false;
            dgvLop.Columns["STenKhoi"].HeaderText = "Tên khối";
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnthem_Click(object sender, EventArgs e)
        {
            // Kiểm tra tính hợp lệ của dữ liệu
            if (txttenlop.Text == "" || txtsiso.Text == "") { MessageBox.Show("Vui lòng nhập dữ liệu.", "Thông báo!"); return; }
            // Khởi tạo đôi tượng LopDTO
            LopDTO lopDTO = new LopDTO();
            lopDTO.STenLop = txttenlop.Text;
            lopDTO.ISiSo = int.Parse(txtsiso.Text);
            lopDTO.IMaNienKhoa = int.Parse(cbNienkhoa.SelectedValue.ToString());
            lopDTO.IMaKhoi = int.Parse(cbKhoi.SelectedValue.ToString());
            // Gọi tới lớp nghiệp vụ lopBLL
            if (LopBLL.ThemLopHoc(lopDTO))
            {
                MessageBox.Show("Thêm thành công.", "Thông báo!");
                LoadLopHoc();
                return;
            }
            MessageBox.Show("Thêm thất bại.", "Thông báo!");
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmalop.Text == "")
            {
                MessageBox.Show("Hãy chọn lớp cần xóa.", "Thông báo!");
                return;
            }
            // Khởi tạo đối tượng sinh viên DTO
            LopDTO lopDTO = new LopDTO();
            lopDTO.IMaLop = int.Parse(txtmalop.Text);
            // Gọi lớp nghiệp vụ SinhVienBLL
            if (LopBLL.XoaLopHoc(lopDTO) == true)
            {
                MessageBox.Show("Xóa thành công.", "Thông báo!");
                // Load lại dữ liệu
                LoadLopHoc();
                return;
            }
            MessageBox.Show("Xóa thất bại.", "Thông báo!");
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            // Kiểm tra tính hợp lệ của dữ liệu
            if (txttenlop.Text == "" || txtsiso.Text == "") { MessageBox.Show("Vui lòng nhập dữ liệu.", "Thông báo!"); return; }
            // Khởi tạo đôi tượng LopDTO
            LopDTO lopDTO = new LopDTO();
            lopDTO.IMaLop = int.Parse(txtmalop.Text);
            lopDTO.STenLop = txttenlop.Text;
            lopDTO.ISiSo = int.Parse(txtsiso.Text);
            lopDTO.IMaNienKhoa = int.Parse(cbNienkhoa.SelectedValue.ToString());
            lopDTO.IMaKhoi = int.Parse(cbKhoi.SelectedValue.ToString());
            // Gọi tới lớp nghiệp vụ lopBLL
            if (LopBLL.SuaLopHoc(lopDTO) == true)
            {
                MessageBox.Show("Sửa thành công.", "Thông báo!");
                LoadLopHoc();
                return;
            }
            MessageBox.Show("Sửa thất bại.", "Thông báo!");
        }

        private void dgvLop_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra tính hợp lệ của dữ liệu
            if (txttenlop.Text == "" || txtsiso.Text == "") { MessageBox.Show("Vui lòng nhập dữ liệu.", "Thông báo!"); return; }
            // Khởi tạo đôi tượng LopDTO
            LopDTO lopDTO = new LopDTO();
            lopDTO.IMaLop = int.Parse(txtmalop.Text);
            lopDTO.STenLop = txttenlop.Text;
            lopDTO.ISiSo = int.Parse(txtsiso.Text);
            // Gọi tới lớp nghiệp vụ lopBLL
            if (LopBLL.SuaLopHoc(lopDTO) == true)
            {
                MessageBox.Show("Sửa thành công.", "Thông báo!");
                LoadLopHoc();
                return;
            }
            MessageBox.Show("Sửa thất bại.", "Thông báo!");
        }

        private void dgvLop_Click(object sender, EventArgs e)
        {
            // Đưa các dữ liệu từ datagridview lên các control
            DataGridViewRow dr = dgvLop.SelectedRows[0];
            txtmalop.Text = dr.Cells["IMaLop"].Value.ToString();
            txttenlop.Text = dr.Cells["STenLop"].Value.ToString();            
            txtsiso.Text = dr.Cells["ISiSo"].Value.ToString();
            cbNienkhoa.SelectedValue = int.Parse(dr.Cells["IMaNienKhoa"].Value.ToString());
            cbKhoi.SelectedValue = int.Parse(dr.Cells["IMaKhoi"].Value.ToString());
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadcbNienKhoa()
        {
            List<NienKhoaDTO> lstnienkhoa = NienKhoaBLL.LoadcbNienKhoa();
            cbNienkhoa.DataSource = lstnienkhoa;
            cbNienkhoa.DisplayMember = "STenNienKhoa"; // Giá trị cần hiển thị
            cbNienkhoa.ValueMember = "IMaNienKhoa"; // Giá trị cần lấy
        }

        private void LoadcbKhoi()
        {
            List<KhoiDTO> lstk = KhoiBLL.LoadcbKhoi();
            cbKhoi.DataSource = lstk;
            cbKhoi.DisplayMember = "STenKhoi"; // Giá trị cần hiển thị
            cbKhoi.ValueMember = "IMaKhoi"; // Giá trị cần hiển thị
        }
    }
}
