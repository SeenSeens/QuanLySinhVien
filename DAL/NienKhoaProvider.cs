using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class NienKhoaProvider
    {
        static SqlConnection con;
        public static List<NienKhoaDTO> LoadNienKhoa()
        {
            // Khai báo truy vấn
            string sQuery = @"SELECT * FROM NienKhoa ";
            // Tạo đối tượng kết nối
            con = DataProvider.Connect();
            // Truy vấn
            DataTable dt = DataProvider.LayDataTable(sQuery, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Tạo list DTOSinhVien
            List<NienKhoaDTO> lstnienkhoa = new List<NienKhoaDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NienKhoaDTO nienkhoa = new NienKhoaDTO();
                nienkhoa.IMaNienKhoa = int.Parse(dt.Rows[i]["MaNienKhoa"].ToString());
                nienkhoa.STenNienKhoa = dt.Rows[i]["TenNienKhoa"].ToString();
                nienkhoa.SGhiChu = dt.Rows[i]["GhiChu"].ToString();
                lstnienkhoa.Add(nienkhoa);
            }
            // Đóng kết nối
            DataProvider.CloseConnect(con);
            return lstnienkhoa;
        }
        public static List<NienKhoaDTO> LoadcbNienKhoa()
        {
            string sQuery = @"SELECT * FROM NienKhoa";
            con = DataProvider.Connect();
            DataTable dt = DataProvider.LayDataTable(sQuery, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Tạo list Niên Khóa
            List<NienKhoaDTO> lstNienKhoa = new List<NienKhoaDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NienKhoaDTO nienkhoa = new NienKhoaDTO();
                nienkhoa.IMaNienKhoa = int.Parse(dt.Rows[i]["MaNienKhoa"].ToString());
                nienkhoa.STenNienKhoa = dt.Rows[i]["TenNienKhoa"].ToString();
                //nienkhoa.SGhiChu = dt.Rows[i]["GhiChu"].ToString();
                lstNienKhoa.Add(nienkhoa);
            }
            DataProvider.CloseConnect(con);
            return lstNienKhoa;
        }
        public static bool ThemNienKhoa(NienKhoaDTO nienKhoaDTO)
        {
            string sQuery = string.Format(@"INSERT INTO NienKhoa VALUES (N'{0}', N'{1}')", nienKhoaDTO.STenNienKhoa, nienKhoaDTO.SGhiChu);
            con = DataProvider.Connect();
            //DataTable dt = DataProvider.LayDataTable(sQuery, con);
            try
            {
                DataProvider.ExecuteQueriesNonQuery(sQuery, con);
                DataProvider.CloseConnect(con);
                return true;
            }
            catch (Exception ex)
            {
                DataProvider.CloseConnect(con);
                return false;
            }
        }
        public static bool XoaNienKhoa(NienKhoaDTO nienKhoaDTO)
        {
            string sQuery = string.Format(@"DELETE NienKhoa WHERE MaNienKhoa={0}", nienKhoaDTO.IMaNienKhoa);
            con = DataProvider.Connect();
            try
            {
                DataProvider.ExecuteQueriesNonQuery(sQuery, con);
                DataProvider.CloseConnect(con);
                return true;
            }
            catch (Exception ex)
            {
                DataProvider.CloseConnect(con);
                return false;
            }
        }
        public static bool SuaNienKhoa(NienKhoaDTO nienKhoaDTO)
        {
            string sQuery = string.Format(@"UPDATE NienKhoa SET TenNienKhoa=N'{0}', GhiChu=N'{1}' WHERE MaNienKhoa={2}", nienKhoaDTO.STenNienKhoa, nienKhoaDTO.SGhiChu, nienKhoaDTO.IMaNienKhoa);
            con = DataProvider.Connect();
            try
            {
                DataProvider.ExecuteQueriesNonQuery(sQuery, con);
                DataProvider.CloseConnect(con);
                return true;
            }
            catch (Exception ex)
            {
                DataProvider.CloseConnect(con);
                return false;
            }
        }
    }
}
