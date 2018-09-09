using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class SinhVienProvider
    {
        // Khởi tạo biến kết nối
        static SqlConnection con;
        // Load Sinh Vien
        public static List<HocSinhDTO> LoadSinhVien()
        {
            // Khai báo truy vấn
            string sQuery = "SELECT * FROM HocSinh, Lop WHERE HocSinh.MaLop = Lop.MaLop";
            // Tạo đối tượng kết nối
            con = DataProvider.Connect();
            // Truy vấn
            DataTable dt = DataProvider.LayDataTable(sQuery, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Tạo list DTOSinhVien
            List<HocSinhDTO> lstsv = new List<HocSinhDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HocSinhDTO sv = new HocSinhDTO();
                sv.IMaHS = int.Parse(dt.Rows[i]["MaHS"].ToString());
                sv.SHoTen = dt.Rows[i]["Hoten"].ToString();
                sv.SGioiTinh = dt.Rows[i]["GioiTinh"].ToString();
                sv.DtNgaySinh = DateTime.Parse( dt.Rows[i]["NgaySinh"].ToString());
                sv.SDiaChi = dt.Rows[i]["DiaChi"].ToString();
                sv.IMaLop = int.Parse(dt.Rows[i]["MaLop"].ToString());
                sv.STenLop = dt.Rows[i]["TenLop"].ToString();
                lstsv.Add(sv);
            }
            // Đóng kết nối
            DataProvider.CloseConnect(con);
            return lstsv;
        }

        // Thêm Sinh Viên
        public static bool ThemSinhVien(HocSinhDTO svDTO)
        {
            // Khai báo truy vấn
            string sQuery = string.Format("INSERT INTO HocSinh VALUES (N'{0}', N'{1}', '{2}', N'{3}', {4})", svDTO.SHoTen, svDTO.SGioiTinh, svDTO.DtNgaySinh, svDTO.SDiaChi, svDTO.IMaLop);
            // Tạo đối tượng kết nối
            con = DataProvider.Connect();
            // Thực thi truy vấn
            try
            {
                DataProvider.ExecuteQueriesNonQuery(sQuery, con);
                DataProvider.CloseConnect(con);
                return true;
            }
            catch(Exception ex) { DataProvider.CloseConnect(con); return false; }
        }

        // Sửa Sinh Viên
        public static bool SuaSinhVien(HocSinhDTO svDTO)
        {
            // Khai báo truy vấn
            string sQuery = string.Format("UPDATE HocSinh SET HoTen=N'{0}', GioiTinh=N'{1}', NgaySinh='{2}', DiaChi=N'{3}', MaLop='{4}' WHERE MaHS={5}", svDTO.SHoTen, svDTO.SGioiTinh, svDTO.DtNgaySinh, svDTO.SDiaChi, svDTO.IMaLop, svDTO.IMaHS);
            // Tạo đối tượng kết nối
            con = DataProvider.Connect();
            // Thực thi truy vấn
            try
            {
                DataProvider.ExecuteQueriesNonQuery(sQuery, con);
                // Đóng kết nối
                DataProvider.CloseConnect(con);
                return true;
            }
            catch(Exception ex)
            {
                // Đóng kết nối
                DataProvider.CloseConnect(con);
                return false;
            }
        }

        // Xóa sinh viên
        public static bool XoaSinhVien(HocSinhDTO svDTO)
        {
            // Khai báo truy vấn
            string sQuery = string.Format("DELETE FROM HocSinh WHERE MaHS={0}", svDTO.IMaHS);
            // Tạo đối tượng kết nối
            con = DataProvider.Connect();
            // Thực thi truy vấn
            try
            {
                DataProvider.ExecuteQueriesNonQuery(sQuery, con);
                // Đóng kết nối
                DataProvider.CloseConnect(con);
                return true;
            }
            catch (Exception ex)
            {
                // Đóng kết nối
                DataProvider.CloseConnect(con);
                return false;
            }
        }

        // Tìm kiếm sinh viên
        public static List<HocSinhDTO> TimKiemSinhVien(string key)
        {
            // Khai báo truy vấn
            string sQuery = string.Format("SELECT * FROM HocSinh WHERE HoTen like N'%{0}%'", key);
            // Tạo đối tượng kết nối
            con = DataProvider.Connect();
            // Truy vấn
            DataTable dt = DataProvider.LayDataTable(sQuery, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Tạo list DTOSinhVien
            List<HocSinhDTO> lstsv = new List<HocSinhDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HocSinhDTO sv = new HocSinhDTO();
                sv.IMaHS = int.Parse(dt.Rows[i]["MaHS"].ToString());
                sv.SHoTen = dt.Rows[i]["Hoten"].ToString();
                sv.SGioiTinh = dt.Rows[i]["GioiTinh"].ToString();
                sv.DtNgaySinh = DateTime.Parse(dt.Rows[i]["NgaySinh"].ToString());
                sv.SDiaChi = dt.Rows[i]["DiaChi"].ToString();
                sv.IMaLop = int.Parse(dt.Rows[i]["MaLop"].ToString());
                lstsv.Add(sv);
            }
            // Đóng kết nối
            DataProvider.CloseConnect(con);
            return lstsv;
        }
    }
}
