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
    public class KhoiProvider
    {
        static SqlConnection con;
        public static List<KhoiDTO> LoadKhoi()
        {
            string sQuery = @"SELECT * FROM Khoi ";
            con = DataProvider.Connect();
            DataTable dt = DataProvider.LayDataTable(sQuery, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<KhoiDTO> lstk = new List<KhoiDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhoiDTO k = new KhoiDTO();
                k.IMaKhoi = int.Parse(dt.Rows[i]["MaKhoi"].ToString());
                k.STenKhoi = dt.Rows[i]["TenKhoi"].ToString();
                k.SGhiChu = dt.Rows[i]["GhiChu"].ToString();
                lstk.Add(k);
            }
            DataProvider.CloseConnect(con);
            return lstk;
        }
        public static bool ThemKhoi(KhoiDTO khoiDTO)
        {
            string sQuery = string.Format(@"INSERT INTO Khoi VALUES (N'{0}', N'{1}')", khoiDTO.STenKhoi, khoiDTO.SGhiChu);
            con = DataProvider.Connect();
            DataTable dt = DataProvider.LayDataTable(sQuery, con);
            try
            {
                DataProvider.ExecuteQueriesNonQuery(sQuery, con);
                DataProvider.CloseConnect(con);
                return true;
            }
            catch(Exception ex) { DataProvider.CloseConnect(con); return false;                         }
        }
        public static bool XoaKhoi(KhoiDTO khoiDTO)
        {
            string sQuery = string.Format(@"DELETE Khoi WHERE MaKhoi={0}", khoiDTO.IMaKhoi);
            con = DataProvider.Connect();
            DataTable dt = DataProvider.LayDataTable(sQuery, con);
            try
            {
                DataProvider.ExecuteQueriesNonQuery(sQuery, con);
                DataProvider.CloseConnect(con);
                return true;
            }
            catch (Exception ex) { DataProvider.CloseConnect(con); return false; }
        }
        public static bool SuaKhoi(KhoiDTO khoiDTO)
        {
            string sQuery = string.Format(@"UPDATE Khoi SET TenKhoi=N'{0}', GhiChu=N'{1}' WHERE MaKhoi={2}", khoiDTO.STenKhoi, khoiDTO.SGhiChu, khoiDTO.IMaKhoi);
            con = DataProvider.Connect();
            DataTable dt = DataProvider.LayDataTable(sQuery, con);
            try
            {
                DataProvider.ExecuteQueriesNonQuery(sQuery, con);
                DataProvider.CloseConnect(con);
                return true;
            }
            catch (Exception ex) { DataProvider.CloseConnect(con); return false; }
        }
        public static List<KhoiDTO> LoadcbKhoi()
        {
            string sQuery = string.Format("SELECT * FROM Khoi");
            con = DataProvider.Connect();
            DataTable dt = DataProvider.LayDataTable(sQuery, con);
            List<KhoiDTO> lstk = new List<KhoiDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhoiDTO khoiDTO = new KhoiDTO();
                khoiDTO.IMaKhoi = int.Parse(dt.Rows[i]["MaKhoi"].ToString());
                khoiDTO.STenKhoi = dt.Rows[i]["TenKhoi"].ToString();
                //khoiDTO.SGhiChu = dt.Rows[i]["GhiChu"].ToString();
                lstk.Add(khoiDTO);
            }
            DataProvider.CloseConnect(con);
            return lstk;
        }
    }
}
