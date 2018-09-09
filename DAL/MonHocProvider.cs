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
    public class MonHocProvider
    {
        static SqlConnection con;
        public static List<MonHocDTO> LoadMonHoc()
        {
            string sQuery = string.Format(
                                            @"SELECT * FROM MonHoc mh
                                            INNER JOIN HocKy hk
                                                    ON hk.MaHK = mh.MaHK
                                            INNER JOIN Khoi k
                                                    ON k.MaKhoi = mh.MaKhoi"
                                          );
            con = DataProvider.Connect();
            DataTable dt = DataProvider.LayDataTable(sQuery, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<MonHocDTO> lstmh = new List<MonHocDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                MonHocDTO monhocDTO = new MonHocDTO();
                monhocDTO.IMaMH = int.Parse(dt.Rows[i]["MaMH"].ToString());
                monhocDTO.STenMH = dt.Rows[i]["TenMH"].ToString();
                monhocDTO.ISoTiet = int.Parse(dt.Rows[i]["SoTiet"].ToString());
                monhocDTO.IMaHK = int.Parse(dt.Rows[i]["MaHK"].ToString());
                monhocDTO.STenHK = dt.Rows[i]["TenHK"].ToString();
                monhocDTO.IMaKhoi = int.Parse(dt.Rows[i]["MaKhoi"].ToString());
                monhocDTO.STenKhoi = dt.Rows[i]["TenKhoi"].ToString();
                lstmh.Add(monhocDTO);
            }
            // Đóng kết nối
            DataProvider.CloseConnect(con);
            return lstmh;
        }
        public static bool ThemMonHoc(MonHocDTO monhocDTO)
        {
            string sQuery = string.Format(@"INSERT INTO MonHoc VALUES (N'{0}', {1}, {2}, {3})", monhocDTO.STenMH, monhocDTO.ISoTiet, monhocDTO.IMaHK, monhocDTO.IMaKhoi);
            con = DataProvider.Connect();
            try
            {
                DataProvider.ExecuteQueriesNonQuery(sQuery, con);
                DataProvider.CloseConnect(con);
                return true;
            }
            catch (Exception ex) { DataProvider.CloseConnect(con); return false; }
        }
        public static bool XoaMonHoc(MonHocDTO monhocDTO)
        {
            string sQuery = string.Format(@"DELETE MonHoc WHERE MaMH={0}", monhocDTO.IMaMH);
            con = DataProvider.Connect();
            try
            {
                DataProvider.ExecuteQueriesNonQuery(sQuery, con);
                DataProvider.CloseConnect(con);
                return true;
            }
            catch (Exception ex) { DataProvider.CloseConnect(con); return false; }
        }
        public static bool SuaMonHoc(MonHocDTO monhocDTO)
        {
            string sQuery = string.Format(@"UPDATE MonHoc SET TenMH=N'{0}', SoTiet={1}, MaHK={2}, MaKhoi={3} WHERE MaMH={4}", monhocDTO.STenMH, monhocDTO.ISoTiet, monhocDTO.IMaHK, monhocDTO.IMaKhoi, monhocDTO.IMaMH);
            con = DataProvider.Connect();
            try
            {
                DataProvider.ExecuteQueriesNonQuery(sQuery, con);
                DataProvider.CloseConnect(con);
                return true;
            }
            catch (Exception ex) { DataProvider.CloseConnect(con); return false; }
        }
        public static List<MonHocDTO> LoadcbMonHoc()
        {
            string sQuery = string.Format(@"SELECT * FROM MonHoc");
            con = DataProvider.Connect();
            DataTable dt = DataProvider.LayDataTable(sQuery, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<MonHocDTO> lstmh = new List<MonHocDTO>();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                MonHocDTO monhocDTO = new MonHocDTO();
                monhocDTO.IMaMH = int.Parse(dt.Rows[i]["MaMH"].ToString());
                monhocDTO.STenMH = dt.Rows[i]["TenMH"].ToString();
                lstmh.Add(monhocDTO);
            }
            DataProvider.CloseConnect(con);
            return lstmh;
        }
    }
}
