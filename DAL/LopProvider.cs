using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using System.Data;

namespace DAL
{

    public class LopProvider
    {

        // Khai báo truy vấn
        static SqlConnection con;

        
        public static List<LopDTO> LoadLop()
        {
            // Khai báo truy vấn
            string sQuery = @"SELECT * FROM Lop l
                              INNER JOIN NienKhoa nk
                                    ON nk.MaNienKhoa = l.MaNienKhoa
                              INNER JOIN Khoi k
                                    ON k.MaKhoi = l.MaKhoi";
            // Tạo đối tượng kết nối
            con = DataProvider.Connect();
            // Truy vấn
            DataTable dt = DataProvider.LayDataTable(sQuery, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Tạo list DTOSinhVien
            List<LopDTO> lstlop = new List<LopDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LopDTO lop = new LopDTO();
                lop.IMaLop = int.Parse(dt.Rows[i]["MaLop"].ToString());
                lop.STenLop = dt.Rows[i]["TenLop"].ToString();
                lop.ISiSo = int.Parse(dt.Rows[i]["SiSo"].ToString());
                lop.IMaNienKhoa = int.Parse(dt.Rows[i]["MaNienKhoa"].ToString());
                lop.STenNienKhoa = dt.Rows[i]["TenNienKhoa"].ToString();
                lop.IMaKhoi = int.Parse(dt.Rows[i]["MaKhoi"].ToString());
                lop.STenKhoi = dt.Rows[i]["TenKhoi"].ToString();
                lstlop.Add(lop);
            }
            // Đóng kết nối
            DataProvider.CloseConnect(con);
            return lstlop;
        }

        /// <summary>
        /// Load combobox 
        /// </summary>
        /// <returns> list Lớp</returns>
        public static List<LopDTO> LoadcbLop()
        {

            // Khai báo truy vấn.
            string sQuery = string.Format(@"SELECT * FROM Lop");
            // Mở kết nối
            con = DataProvider.Connect();
            // Truy vấn
            DataTable dt = DataProvider.LayDataTable(sQuery, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Tạo list LopDTO
            List<LopDTO> lstLop = new List<LopDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LopDTO lop = new LopDTO();
                lop.IMaLop = int.Parse(dt.Rows[i]["MaLop"].ToString());
                lop.STenLop = dt.Rows[i]["TenLop"].ToString();
                //lop.ISiSo = int.Parse(dt.Rows[i]["SiSo"].ToString());
                lstLop.Add(lop);
            }
            // Đóng kết nối
            DataProvider.CloseConnect(con);
            return lstLop;
        }      

        /// <summary>
        /// Thêm lớp học
        /// </summary>
        /// <param name="lopDTO"></param>
        /// <returns> bool </returns>
        public static bool ThemLopHoc(LopDTO lopDTO)
        {
            // Khai báo truy vấn
            string sQuery = string.Format("INSERT INTO Lop VALUES (N'{0}', {1}, {2}, {3})", lopDTO.STenLop, lopDTO.ISiSo, lopDTO.IMaNienKhoa, lopDTO.IMaKhoi);
            // Tạo đối tượng kết nối
            con = DataProvider.Connect();
            // Thực thi truy vấn
            try
            {
                DataProvider.ExecuteQueriesNonQuery(sQuery, con);
                DataProvider.CloseConnect(con);
                return true;
            }
            catch (Exception ex) { DataProvider.CloseConnect(con); return false; }
        }

        /// <summary>
        /// Sửa Lớp Học
        /// </summary>
        /// <param name="lopDTO"></param>
        /// <returns></returns>
        public static bool SuaLop(LopDTO lopDTO)
        {
            // Khai báo truy vấn
            string sQuery = string.Format("UPDATE Lop SET TenLop=N'{0}', SiSo={1}, MaNienKhoa={2}, MaKhoi={3} WHERE MaLop={4}", lopDTO.STenLop, lopDTO.ISiSo, lopDTO.IMaNienKhoa, lopDTO.IMaKhoi, lopDTO.IMaLop);
            // Tạo đối tượng kết nối
            con = DataProvider.Connect();
            // Thực thi truy vấn
            try
            {
                DataProvider.ExecuteQueriesNonQuery(sQuery, con);
                DataProvider.CloseConnect(con);
                return true;
            }
            catch (Exception ex) { DataProvider.CloseConnect(con); return false; }
        }

        public static bool XoaLop(LopDTO lopDTO)
        {
            // Khai báo truy vấn
            string sQuery = string.Format("DELETE Lop WHERE MaLop={0}", lopDTO.IMaLop);
            // Tạo đối tượng kết nối
            con = DataProvider.Connect();
            // Thực thi truy vấn
            try
            {
                DataProvider.ExecuteQueriesNonQuery(sQuery, con);
                DataProvider.CloseConnect(con);
                return true;
            }
            catch (Exception ex) { DataProvider.CloseConnect(con); return false; }
        }
        
    }
}
