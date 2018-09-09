 using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BLL;
using DTO;

namespace QuanLySinhVien
{
    public partial class SinhVien : Form
    {
        public SinhVien()
        {
            InitializeComponent();
        }

        private void frmquanlysinhvien_Load(object sender, EventArgs e)
        {
            // Load dữ liệu control datagridview
            LoadSinhVien();
            // Load dữ liệu combobox Lớp
            LoadcbLop();
        }
        private void LoadSinhVien()
        {
            List<HocSinhDTO> lstSinhVien = SinhVienBLL.LoadSinhVien();
            dgvsinhvien.DataSource = lstSinhVien;
            dgvsinhvien.Columns["IMaHS"].HeaderText = "Mã học sinh";
            dgvsinhvien.Columns["SHoTen"].HeaderText = "Tên học sinh";
            dgvsinhvien.Columns["SGioiTinh"].HeaderText = "Giới tính";
            dgvsinhvien.Columns["DtNgaySinh"].HeaderText = "Ngày sinh";
            dgvsinhvien.Columns["SDiaChi"].HeaderText = "Địa chỉ";
            dgvsinhvien.Columns["IMaLop"].Visible = false;
            dgvsinhvien.Columns["STenLop"].HeaderText = "Tên lớp";
        }
        private void LoadcbLop()
        {
            List<LopDTO> lstLop = LopBLL.LoadcbLop();
            cblop.DataSource = lstLop;
            cblop.DisplayMember = "STenLop"; // Giá trị hiển thị
            cblop.ValueMember = "IMaLop"; // Giá trị cần lấy
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn muốn thoát khỏi chương trình?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes) { this.Close(); }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            // Kiểm tra tính hợp lệ của dữ liệ
            if (txthoten.Text == "" || txtdiachi.Text == "") { MessageBox.Show("Vui lòng nhập dữ liệu.", "Thông báo!"); return; }
            // Khởi tạo đối tượng sinh viên DTO
            HocSinhDTO svDTO = new HocSinhDTO();
            svDTO.SHoTen = txthoten.Text;
            if (radnam.Checked == true) { svDTO.SGioiTinh = "Nam"; }
            else { svDTO.SGioiTinh = "Nữ"; }
            svDTO.DtNgaySinh = DateTime.Parse(dtpngaysinh.Text);
            svDTO.SDiaChi = txtdiachi.Text;
            svDTO.IMaLop = int.Parse(cblop.SelectedValue.ToString());
            // Gọi lớp nghiệp vụ SinhVienBLL
            if (SinhVienBLL.ThemSinhVien(svDTO) == true)
            {
                MessageBox.Show("Thêm thành công.", "Thông báo!");
                // Load lại dữ liệu
                LoadSinhVien();
                return;
            }
            MessageBox.Show("Thêm thất bại.", "Thông báo!");
        }

        private void dgvsinhvien_Click(object sender, EventArgs e)
        {
            // Đưa các dữ liệu từ datagridview lên các control
            DataGridViewRow dr = dgvsinhvien.SelectedRows[0];
            txtmasv.Text = dr.Cells["IMaHS"].Value.ToString();
            txthoten.Text = dr.Cells["SHoTen"].Value.ToString();
            if(dr.Cells["SGioiTinh"].Value.ToString()=="Nam")
            {
                radnam.Checked = true;
            }
            else { radnu.Checked = true; }
            dtpngaysinh.Text = dr.Cells["DtNgaySinh"].Value.ToString();
            txtdiachi.Text = dr.Cells["SDiaChi"].Value.ToString();
            cblop.SelectedValue = int.Parse(dr.Cells["IMaLop"].Value.ToString());
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            // Khởi tạo đối tượng sinh viên DTO
            HocSinhDTO svDTO = new HocSinhDTO();
            svDTO.IMaHS = int.Parse(txtmasv.Text);
            svDTO.SHoTen = txthoten.Text;
            if (radnam.Checked == true) { svDTO.SGioiTinh = "Nam"; }
            else { svDTO.SGioiTinh = "Nữ"; }
            svDTO.DtNgaySinh = DateTime.Parse(dtpngaysinh.Text);
            svDTO.SDiaChi = txtdiachi.Text;
            svDTO.IMaLop = int.Parse(cblop.SelectedValue.ToString());
            // Gọi lớp nghiệp vụ SinhVienBLL
            if(SinhVienBLL.SuaSinhVien(svDTO)==true)
            {
                MessageBox.Show("Sửa thành công.", "Thông báo!");
                // Load lại dữ liệu
                LoadSinhVien();
                return;
            }
            MessageBox.Show("Sửa thất bại.", "Thông báo!");
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmasv.Text == "")
            {
                MessageBox.Show("Hãy chọn sinh viên cần xóa.", "Thông báo!");
                return;
            }
            // Khởi tạo đối tượng sinh viên DTO
            HocSinhDTO svDTO = new HocSinhDTO();
            svDTO.IMaHS = int.Parse(txtmasv.Text);
            // Gọi lớp nghiệp vụ SinhVienBLL
            if (SinhVienBLL.XoaSinhVien(svDTO) == true)
            {
                MessageBox.Show("Xóa thành công.", "Thông báo!");
                // Load lại dữ liệu
                LoadSinhVien();
                return;
            }
            MessageBox.Show("Xóa thất bại.", "Thông báo!");
        }

        private void txttimkiem_Click(object sender, EventArgs e)
        {
            txttimkiem.ResetText();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string key = txttimkiem.Text;
            List<HocSinhDTO> lstKQ = SinhVienBLL.TimKiemSinhVien(key);
            if (lstKQ == null)
            {
                MessageBox.Show("Không tìm thấy học sinh nào.", "Thông báo!");
                return;
            }
            dgvsinhvien.DataSource = lstKQ;
        }

        private void txthoten_Click(object sender, EventArgs e)
        {
            this.txthoten.ResetText();
        }

        private void txtdiachi_Click(object sender, EventArgs e)
        {
            this.txtdiachi.ResetText();
        }

        private void btnrf_Click(object sender, EventArgs e)
        {
            this.txtmasv.ResetText();
            this.txthoten.ResetText();
            this.txtdiachi.ResetText();
            this.txttimkiem.Text = "Nhập vào tên sinh viên bạn cần tìm...";
            LoadSinhVien();
        }







        //#region ado.net thuần
        //DataSet ds;
        //DataView dv;
        //SqlDataAdapter daSinhVien;
        //int iMaSV;
        //private void frmquanlysinhvien_Load(object sender, EventArgs e)
        //{
        //    /*txtmasv.Enabled = false;
        //    txthoten.Enabled = false;
        //    txtdiachi.Enabled = false;*/
        //    // Chuỗi kết nối
        //    string Connection = @"Data Source=DESKTOP-RIMVVK5;Initial Catalog=QuanLySinhVien;Integrated Security=True";
        //    // Chuỗi truy vấn
        //    string QuerySV = @"SELECT * FROM SinhVien";
        //    // Khởi tạo đối tượng SQLDataAdapter, thực hiện truy vấn lấy dữ liệu từ database về
        //    daSinhVien = new SqlDataAdapter(QuerySV, Connection);
        //    // Khởi tạo DataSet
        //    ds = new DataSet("DsQuanLySinhVien");
        //    // Đổ dữ liệu vào 1 bảng trong dataset
        //    daSinhVien.Fill(ds, "tbSinhVien");
        //    dv = new DataView(ds.Tables["tbSinhVien"]);
        //    //dgvsinhvien.DataSource = ds.Tables["tbSinhVien"];
        //    dgvsinhvien.DataSource = dv;
        //    // Đặt tên cột cho datagridview
        //    dgvsinhvien.Columns["MaSV"].HeaderText = "Mã SV";
        //    dgvsinhvien.Columns["Hoten"].HeaderText = "Họ tên";
        //    dgvsinhvien.Columns["GioiTinh"].HeaderText = "Giới tính";
        //    dgvsinhvien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
        //    dgvsinhvien.Columns["Diachi"].HeaderText = "Địa chỉ";
        //    dgvsinhvien.Columns["MaLop"].HeaderText = "Lớp học";
        //    // Đổ dữ liệu lên control combobox
        //    string QueryLopHoc = @"SELECT * FROM Lop";
        //    SqlDataAdapter daLopHoc = new SqlDataAdapter(QueryLopHoc, Connection);
        //    daLopHoc.Fill(ds, "tbLopHoc");
        //    cblop.DataSource = ds.Tables["tbLopHoc"];
        //    cblop.DisplayMember = "TenLop"; // Lấy thuộc tính hiện thị ra bên ngoài
        //    cblop.ValueMember = "MaLop"; // Lấy giá trị
        //    /* Lấy ra tên lớp
        //    //Tạo chuỗi truy vấn lấy thông tin 2 bảng
        //    string QuerySV_LH = "SELECT SinhVien.*, Lop.TenLop FROM SinhVien,Lop WHERE SinhVien.MaLop = Lop.MaLop";
        //    SqlDataAdapter daSinhVien_LopHoc = new SqlDataAdapter(QuerySV_LH, Connection);
        //    daSinhVien_LopHoc.Fill(ds, "tbSinhVien_LopHoc");
        //    dgvsinhvien.DataSource = ds.Tables["tbSinhVien_LopHoc"];
        //    //Ẩn cột lớp học
        //    dgvsinhvien.Columns["MaLop"].Visible = false;
        //    dgvsinhvien.Columns["TenLop"].HeaderText = "Tên Lớp";*/
        //    DataGridViewColumn clTenLop = new DataGridViewColumn();
        //    DataGridViewCell cell = new DataGridViewTextBoxCell();
        //    clTenLop.CellTemplate = cell;
        //    clTenLop.Name = "TenLop";
        //    clTenLop.HeaderText = "Tên lớp";
        //    dgvsinhvien.Columns.Add(clTenLop);
        //    for (int i = 0; i < dgvsinhvien.RowCount; i++)
        //    {
        //        dgvsinhvien.Rows[i].Cells["TenLop"].Value = LayTenLopHoc(dgvsinhvien.Rows[i].Cells["MaLop"].Value.ToString());
        //    }
        //    //Ẩn cột lớp học
        //    dgvsinhvien.Columns["MaLop"].Visible = false;
        //    dgvsinhvien.Columns["TenLop"].HeaderText = "Tên Lớp";
        //    // Tạo đối tượng kết nối tới database
        //    SqlConnection conn = new SqlConnection(Connection);
        //    // Tạo đối tượng command & thực thi truy vấn
        //    string QueryInsertSV = @"INSERT INTO SinhVien(HoTen, GioiTinh, NgaySinh, DiaChi, MaLop) VALUES (@HoTen, @GioiTinh, @NgaySinh, @DiaChi, @MaLop)";
        //    SqlCommand cmInsertSV = new SqlCommand(QueryInsertSV, conn);
        //    cmInsertSV.Parameters.Add("@HoTen", SqlDbType.NVarChar, 50, "HoTen");
        //    cmInsertSV.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 5, "GioiTinh");
        //    cmInsertSV.Parameters.Add("@NgaySinh", SqlDbType.DateTime, 10, "NgaySinh");
        //    cmInsertSV.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 200, "DiaChi");
        //    cmInsertSV.Parameters.Add("@MaLop", SqlDbType.Int, 5, "MaLop");
        //    daSinhVien.InsertCommand = cmInsertSV;
        //    // Tạo đối tượng command update & thực thi truy vấn
        //    string QueryUpdateSV = @"UPDATE SinhVien SET HoTen=@HoTen, GioiTinh=@GioiTinh, NgaySinh=@NgaySinh, DiaChi=@DiaChi, MaLop=@MaLop WHERE MaSV=@MaSV";
        //    SqlCommand cmUpdateSV = new SqlCommand(QueryUpdateSV, conn);
        //    cmUpdateSV.Parameters.Add("@HoTen", SqlDbType.NVarChar, 50, "HoTen");
        //    cmInsertSV.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 5, "GioiTinh");
        //    cmInsertSV.Parameters.Add("@NgaySinh", SqlDbType.DateTime, 10, "NgaySinh");
        //    cmInsertSV.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 200, "DiaChi");
        //    cmInsertSV.Parameters.Add("@MaLop", SqlDbType.Int, 5, "MaLop");
        //    cmUpdateSV.Parameters.Add("@MaSV", SqlDbType.Int, 5, "MaSV");
        //    daSinhVien.UpdateCommand = cmUpdateSV;
        //    // Tạo đối tượng command delete & thực thi truy vấn
        //    string QueryDeleteSV = @"DELETE FROM SinhVien WHERE MaSV=@MaSV";
        //    SqlCommand cmDeleteSV = new SqlCommand(QueryDeleteSV, conn);
        //    cmDeleteSV.Parameters.Add("@MaSV", SqlDbType.Int, 5, "MaSV");
        //    daSinhVien.DeleteCommand = cmDeleteSV;
        //}
        //public string LayTenLopHoc(string sMaLop)
        //{
        //    // Chuỗi kết nối
        //    string Connection = @"Data Source=DESKTOP-RIMVVK5;Initial Catalog=QuanLySinhVien;Integrated Security=True";
        //    // Chuỗi truy vấn
        //    string QueryTenLop = @"SELECT TenLop FROM Lop WHERE MaLop=" + sMaLop;
        //    SqlDataAdapter daTenLop = new SqlDataAdapter(QueryTenLop, Connection);
        //    DataTable dt = new DataTable();
        //    daTenLop.Fill(dt);
        //    if (dt.Rows.Count > 0) { return dt.Rows[0][0].ToString(); }
        //    return "";
        //}
        //private void frmquanlysinhvien_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    DialogResult kq = MessageBox.Show("Bạn chắc chắn có muốn thoát khỏi chương trình không?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        //    if (kq == DialogResult.OK) { Close(); }
        //    return;
        //}
        //private void btnthem_Click(object sender, EventArgs e)
        //{
        //    /*txtmasv.Enabled = true;
        //    txthoten.Enabled = true;
        //    txtdiachi.Enabled = true;*/
        //    // Kiểm tra tính hợp lệ của đầu vào dữ liệu
        //    if (txthoten.Text == "" || txtdiachi.Text == "")
        //    {
        //        MessageBox.Show("Bạn cần phải nhập đầy đủ thông tin.", "Thông báo!");
        //        return;
        //    }
        //    // Thêm 1 dòng vào tbSinhVien
        //    DataRow r = ds.Tables["tbSinhVien"].NewRow();
        //    // Nhập giá trị vào các trường tương ứng trên DataRow
        //    r["HoTen"] = txthoten.Text;
        //    if (radnam.Checked == true) { r["GioiTinh"] = "Nam"; }
        //    else { r["GioiTinh"] = "Nữ"; }
        //    r["NgaySinh"] = dtpngaysinh.Text;
        //    r["DiaChi"] = txtdiachi.Text;
        //    r["MaLop"] = cblop.SelectedValue;
        //    if (iMaSV == 0) { MaSVCuoiCungTruocKhiThem(); }
        //    iMaSV++;
        //    r["MaSV"] = iMaSV;
        //    // Add vào tbSinhVien
        //    ds.Tables["tbSinhVien"].Rows.Add(r);
        //    // Add tên lớp vào datagridview
        //    dgvsinhvien.Rows[dgvsinhvien.RowCount - 1].Cells["TenLop"].Value = LayTenLopHoc(cblop.SelectedValue.ToString());
        //}
        //public void MaSVCuoiCungTruocKhiThem()
        //{
        //    // Chuỗi kết nối
        //    string Connection = @"Data Source=DESKTOP-RIMVVK5;Initial Catalog=QuanLySinhVien;Integrated Security=True";
        //    // Chuỗi truy vấn
        //    string QueryMaSVCuoiCung = @"SELECT MaSV FROM SinhVien";
        //    SqlDataAdapter daTenLop = new SqlDataAdapter(QueryMaSVCuoiCung, Connection);
        //    DataTable dt = new DataTable();
        //    daTenLop.Fill(dt);
        //    if (dt.Rows.Count > 0)
        //    {
        //        // Lấy chỉ số phần tử dòng cuối cùng
        //        int iDongCuoi = dt.Rows.Count - 1;
        //        iMaSV = int.Parse(dt.Rows[iDongCuoi][0].ToString());
        //    }
        //}
        //private void btnluu_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        daSinhVien.Update(ds, "tbSinhVien");
        //        DialogResult luu = MessageBox.Show("Bạn có muốn lưu?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        //        if (luu == DialogResult.Yes) { MessageBox.Show("Lưu thành công.", "Thông báo!"); }
        //        else { MessageBox.Show("Lỗi!"); }
        //    }
        //    catch (Exception ex) { return; }
        //}
        //private void dgvsinhvien_Click(object sender, EventArgs e)
        //{
        //    DataGridViewRow dr = dgvsinhvien.SelectedRows[0];
        //    txtmasv.Text = dr.Cells["MaSV"].Value.ToString();
        //    txthoten.Text = dr.Cells["HoTen"].Value.ToString();
        //    if (dr.Cells["GioiTinh"].Value.ToString() == "Nam")
        //    {
        //        radnam.Checked = true;
        //    }
        //    else
        //    {
        //        radnu.Checked = true;
        //    }
        //    dtpngaysinh.Text = dr.Cells["NgaySinh"].Value.ToString();
        //    txtdiachi.Text = dr.Cells["DiaChi"].Value.ToString();
        //    cblop.Text = dr.Cells["MaLop"].Value.ToString();
        //}
        //private void btnsua_Click(object sender, EventArgs e)
        //{
        //    DataGridViewRow dr = dgvsinhvien.SelectedRows[0];
        //    dgvsinhvien.BeginEdit(true);
        //    dr.Cells["MaSV"].Value = txtmasv.Text;
        //    dr.Cells["HoTen"].Value = txthoten.Text;
        //    if (radnam.Checked == true)
        //    {
        //        dr.Cells["GioiTinh"].Value = "Nam";
        //    }
        //    else
        //    {
        //        dr.Cells["GioiTinh"].Value = "Nu";
        //    }
        //    dr.Cells["NgaySinh"].Value = dtpngaysinh.Text;
        //    dr.Cells["DiaChi"].Value = txtdiachi.Text;
        //    dr.Cells["MaLop"].Value = cblop.SelectedValue;
        //    dgvsinhvien.EndEdit();
        //    MessageBox.Show("Cập nhật thành công!");
        //}
        //private void btnxoa_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        DataGridViewRow dr = dgvsinhvien.SelectedRows[0];
        //        dgvsinhvien.Rows.Remove(dr);
        //        MessageBox.Show("Xóa thành công.", "Thông báo.");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Xóa thất bại.", "Thông báo.");
        //    }
        //}
        //private void btnhuy_Click(object sender, EventArgs e)
        //{
        //    ds.Tables["tbSinhVien"].RejectChanges();
        //}
        //private void txttimkiem_Click(object sender, EventArgs e)
        //{
        //    txttimkiem.Text = "";
        //}
        //private void btntimkiem_Click(object sender, EventArgs e)
        //{
        //    dv.RowFilter = "HoTen like '%" + txttimkiem.Text + "%'";
        //    //dv.RowFilter = string.Format("HoTen like '%{0}%'", txttimkiem.Text);
        //}
        //#endregion;
    }
}
