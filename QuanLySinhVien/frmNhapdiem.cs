using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class frmNhapdiem : Form
    {
        public frmNhapdiem()
        {
            InitializeComponent();
        }
        static SqlConnection con;
        private void frmNhapdiem_Load(object sender, EventArgs e)
        {
            LoadcbNienKhoa();
            LoadcbKhoi();
            LoadcbLop();
            LoadcbHocKy();
            LoadcbMonHoc();
        }
        private void LoadcbNienKhoa()
        {
            List<NienKhoaDTO> nk = NienKhoaBLL.LoadcbNienKhoa();
            cbNienKhoa.DataSource = nk;
            cbNienKhoa.DisplayMember = "STenNienKhoa"; // Giá trị cần hiển thị ra combobox
            cbNienKhoa.ValueMember = "IMaNienKhoa"; // Giá trị cần lấy 
        }
        private void LoadcbKhoi()
        {
            List<KhoiDTO> k = KhoiBLL.LoadcbKhoi();
            cbKhoi.DataSource = k;
            cbKhoi.DisplayMember = "STenKhoi"; // Giá trị cần hiển thị ra combobox
            cbKhoi.ValueMember = "IMaKhoi"; // Giá trị cần lấy 
        }
        private void LoadcbLop()
        {
            List<LopDTO> l = LopBLL.LoadcbLop();
            cbLop.DataSource = l;
            cbLop.DisplayMember = "STenLop"; // Giá trị cần hiển thị ra combobox
            cbLop.ValueMember = "IMaLop"; // Giá trị cần lấy 
        }
        private void LoadcbHocKy()
        {
            List<HocKyDTO> hk = HocKyBLL.LoadcbHocKy();
            cbHocKy.DataSource = hk;
            cbHocKy.DisplayMember = "STenHK"; // Giá trị cần hiển thị ra combobox
            cbHocKy.ValueMember = "IMaHK"; // Giá trị cần lấy 
        }
        private void LoadcbMonHoc()
        {
            List<MonHocDTO> mh = MonHocBLL.LoadcbMonHoc();
            cbMonHoc.DataSource = mh;
            cbMonHoc.DisplayMember = "STenMH"; // Giá trị cần hiển thị ra combobox
            cbMonHoc.ValueMember = "IMaMH"; // Giá trị cần lấy 
        }
        SqlDataAdapter daLop;
        private void cbNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbNienKhoa.SelectedValue != null && !(cbNienKhoa.SelectedValue is DataRowView) && cbKhoi.SelectedValue != null && !(cbKhoi.SelectedValue is DataRowView))
            {
                string ConnectionString = @"Data Source=TUANIT;Initial Catalog=QuanLyHocSinh;Integrated Security=True";
                string sSelectLop = @"SELECT * FROM Lop WHERE MaNienKhoa=" + cbNienKhoa.SelectedValue + "and MaKhoi=" + cbKhoi.SelectedValue;
                // Khởi tạo đối tượng SqlDataAdapter thực hiện truy vấn lấy dữ liệu từ database về
                daLop = new SqlDataAdapter(sSelectLop, ConnectionString);         
                DataTable dt = new DataTable();
                // Đổ dữ liệu vào 1 bảng trong dataset
                daLop.Fill(dt);
                cbLop.DataSource = dt;
                cbLop.ValueMember = "MaLop";
                cbLop.DisplayMember = "TenLop";

            }
            
        }
        SqlDataAdapter daMonHoc;
        private void cbKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbKhoi.SelectedValue != null && !(cbKhoi.SelectedValue is DataRowView) && cbHocKy.SelectedValue != null && !(cbHocKy.SelectedValue is DataRowView) && cbNienKhoa.SelectedValue != null && !(cbNienKhoa.SelectedValue is DataRowView)) // Bổ sung điều kiện để load combobox lớp.
            {
                string ConnectionString = @"Data Source=TUANIT;Initial Catalog=QuanLyHocSinh;Integrated Security=True";
                string QSelectMonHoc = @"SELECT * FROM MonHoc WHERE MaKhoi=" + cbKhoi.SelectedValue + " and MaHK=" + cbHocKy.SelectedValue;
                string QSelectLop = @"SELECT * FROM Lop WHERE MaKhoi=" + cbKhoi.SelectedValue + " and MaNienKhoa=" + cbNienKhoa.SelectedValue;
                daMonHoc = new SqlDataAdapter(QSelectMonHoc, ConnectionString);
                DataTable dt = new DataTable();
                // Đổ dữ liệu vào 1 bảng trong dataset
                daMonHoc.Fill(dt);
                cbMonHoc.DataSource = dt;
                cbMonHoc.ValueMember = "MaMH";
                cbMonHoc.DisplayMember = "TenMH";


                // Bổ sung cbLop
                DataTable dtLop = new DataTable();
                daLop = new SqlDataAdapter(QSelectLop, ConnectionString);
                daLop.Fill(dt);
                cbLop.DataSource = dt;
                cbLop.ValueMember = "MaLop";
                cbLop.DisplayMember = "TenLop";
            }

        }

        private void cbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbKhoi.SelectedValue != null && !(cbKhoi.SelectedValue is DataRowView) && cbHocKy.SelectedValue != null && !(cbHocKy.SelectedValue is DataRowView))
            {
                string ConnectionString = @"Data Source=TUANIT;Initial Catalog=QuanLyHocSinh;Integrated Security=True";
                string SelectMonHoc = @"SELECT MonHoc WHERE MaKhoi=" + cbKhoi.SelectedValue + " and MaHK=" + cbHocKy.SelectedValue;
                DataTable dtMH = new DataTable();
                daMonHoc = new SqlDataAdapter(SelectMonHoc, ConnectionString);
                
                daMonHoc.Fill(dtMH);
                cbMonHoc.DataSource = dtMH;
                cbMonHoc.ValueMember = "MaMH";
                cbMonHoc.DisplayMember = "TenMH";
                
            }
        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        SqlDataAdapter daHocSinh;
        private void LoadDSDiemHS()
        {
            if (cbKhoi.SelectedValue != null && !(cbKhoi.SelectedValue is DataRowView)
              && cbHocKy.SelectedValue != null && !(cbHocKy.SelectedValue is DataRowView)
              && cbLop.SelectedValue != null && !(cbLop.SelectedValue is DataRowView)
              && cbNienKhoa.SelectedValue != null && !(cbNienKhoa.SelectedValue is DataRowView)
              && cbMonHoc.SelectedValue != null && !(cbMonHoc.SelectedValue is DataRowView)
              )
            {
                //Chuỗi kết nối 
                string sChuoiKetNoi = @"Data Source=(local);Initial Catalog=QuanLyHocSinh;Integrated Security=True";
                //Chuỗi truy vấn
                string sSelectDiem = string.Format(@"SELECT HocSinh.MaHS,HocSinh.HoTen,Diem.* FROM Diem, HocSinh, Lop, NienKhoa, Khoi, HocKy, MonHoc WHERE HocSinh.MaLop=Lop.MaLop AND Lop.MaKhoi=Khoi.MaKhoi AND Lop.MaNienKhoa=NienKhoa.MaNienKhoa AND MonHoc.MaHK=HocKy.MaHK AND Diem.MaHS=HocSinh.MaHS AND NienKhoa.MaNienKhoa={0} AND Lop.MaLop={1} AND Khoi.MaKhoi={2} AND MonHoc.MaMH={3} AND HocKy.MaHK ={4}", cbNienKhoa.SelectedValue, cbLop.SelectedValue, cbKhoi.SelectedValue, cbMonHoc.SelectedValue, cbHocKy.SelectedValue);
                //Khởi tạo đối tượng SQLDataAdapter thực hiện truy vấn lấy dữ liệu từ database về
                daHocSinh = new SqlDataAdapter(sSelectDiem, sChuoiKetNoi);
                DataTable dt = new DataTable();
                //Đổ dữ liệu vào 1 bảng trong datatable
                daHocSinh.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    //Nếu có điểm thì gán datasource
                    dgvBangDiem.DataSource = dt;
                }
                else
                {
                    dgvBangDiem.DataSource = null;
                }
            }

        }
        //Load dgvBangDiem những học sinh chưa nhập điểm 
        public void LoaddgvHSNhapDiem()
        {
            //Chuỗi kết nối 
            string sChuoiKetNoi = @"Data Source=(local);Initial Catalog=QuanLyHocSinh;Integrated Security=True";
            //Chuỗi truy vấn
            string sSelectDiem = string.Format(@"Select MonHoc.MaMH,HocSinh.MaHS,HocSinh.HoTen From HocSinh,Lop,NienKhoa,Khoi,HocKy,MonHoc where HocSinh.MaLop=Lop.MaLop and Lop.MaKhoi=Khoi.MaKhoi and Lop.MaNienKhoa=NienKhoa.MaNienKhoa and MonHoc.MaHK=HocKy.MaHK and NienKhoa.MaNienKhoa={0} and Lop.MaLop={1} and Khoi.MaKhoi={2} and MonHoc.MaMH={3} and HocKy.MaHK ={4} and HocSinh.MaHS NOT IN (select MaHS From Diem)  ", cbNienKhoa.SelectedValue, cbLop.SelectedValue, cbKhoi.SelectedValue, cbMonHoc.SelectedValue, cbHocKy.SelectedValue);
            //Khởi tạo đối tượng SQLDataAdapter thực hiện truy vấn lấy dữ liệu từ database về
            daHocSinh = new SqlDataAdapter(sSelectDiem, sChuoiKetNoi);
            DataTable dt = new DataTable();
            //Đổ dữ liệu vào 1 bảng trong datatable
            daHocSinh.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                //Nếu có điểm thì gán datasource
                dgvBangDiem.DataSource = dt;
            }
            else
            {
                dgvBangDiem.DataSource = null;
            }
        }
        private bool NutNhan = true;
        int TaoCot = 0;

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (NutNhan == false)
            {
                try
                {

                    //Chuỗi kết nối 
                    string sChuoiKetNoi = @"Data Source=(local);Initial Catalog=QuanLyHocSinh;Integrated Security=True";
                    //Khởi tạo đối tượng connection
                    SqlConnection con = new SqlConnection(sChuoiKetNoi);
                    con.Open();
                    for (int i = 0; i < dgvBangDiem.Rows.Count; i++)
                    {
                        //Tạo biến trung gian 
                        int sMaMH = int.Parse(dgvBangDiem.Rows[i].Cells["MaMH"].Value.ToString());
                        int sMaHS = int.Parse(dgvBangDiem.Rows[i].Cells["MaHS"].Value.ToString());
                        int sDiemMieng = int.Parse(dgvBangDiem.Rows[i].Cells["DiemMieng"].Value.ToString());
                        int sDiem15Phut = int.Parse(dgvBangDiem.Rows[i].Cells["Diem15Phut"].Value.ToString());
                        int sDiem1Tiet = int.Parse(dgvBangDiem.Rows[i].Cells["Diem1Tiet"].Value.ToString());
                        int sDiemThi = int.Parse(dgvBangDiem.Rows[i].Cells["DiemThi"].Value.ToString());
                        int DTB = (sDiemMieng + sDiem15Phut + sDiem1Tiet * 2 + sDiemThi * 3) / 7;

                        //Chuỗi truy vấn
                        string sInsert = string.Format("INSERT INTO Diem values ({0},{1},{2},{3},{4},{5},{6})", sMaMH, sMaHS, sDiemMieng, sDiem15Phut, sDiem1Tiet, sDiemThi, DTB);
                        SqlCommand cm = new SqlCommand(sInsert, con);
                        cm.ExecuteNonQuery();

                    }
                    con.Close();
                    NutNhan = true;
                    MessageBox.Show("Nhập điểm thành công !", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nhập điểm thất bại!", "Thông báo");
                }
            }
            else
            {
                try
                {
                    //Chuỗi kết nối 
                    string sChuoiKetNoi = @"Data Source=(local);Initial Catalog=QuanLyHocSinh;Integrated Security=True";
                    //Khởi tạo đối tượng connection
                    SqlConnection con = new SqlConnection(sChuoiKetNoi);
                    con.Open();
                    for (int i = 0; i < dgvBangDiem.Rows.Count; i++)
                    {
                        //Tạo biến trung gian 
                        int sMaMH = int.Parse(dgvBangDiem.Rows[i].Cells["MaMH"].Value.ToString());
                        int sMaHS = int.Parse(dgvBangDiem.Rows[i].Cells["MaHS"].Value.ToString());
                        int sDiemMieng = int.Parse(dgvBangDiem.Rows[i].Cells["DiemMieng"].Value.ToString());
                        int sDiem15Phut = int.Parse(dgvBangDiem.Rows[i].Cells["Diem15Phut"].Value.ToString());
                        int sDiem1Tiet = int.Parse(dgvBangDiem.Rows[i].Cells["Diem1Tiet"].Value.ToString());
                        int sDiemThi = int.Parse(dgvBangDiem.Rows[i].Cells["DiemThi"].Value.ToString());
                        int DTB = (sDiemMieng + sDiem15Phut + sDiem1Tiet * 2 + sDiemThi * 3) / 7;

                        //Chuỗi truy vấn
                        string sInsert = string.Format("Update Diem set DiemMieng={0},Diem15Phut={1},Diem1Tiet={2},DiemThi={3},DiemTB={4} where MaHS={5} and MaMH={6}", sDiemMieng, sDiem15Phut, sDiem1Tiet, sDiemThi, DTB, sMaHS, sMaMH);
                        SqlCommand cm = new SqlCommand(sInsert, con);
                        cm.ExecuteNonQuery();

                    }
                    con.Close();
                    NutNhan = true;
                    MessageBox.Show("Cập nhật thành công !", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật thất bại !", "Thông báo");
                }
            }
        }
    }
}
