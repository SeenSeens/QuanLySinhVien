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
    public class HocKyProvider
    {

        static SqlConnection con;
        public static List<HocKyDTO> LoadHocKy()
        {
            string sQuery = @"SELECT * FROM HocKy ";
            con = DataProvider.Connect();
            DataTable dt = DataProvider.LayDataTable(sQuery, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HocKyDTO> lsthk = new List<HocKyDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HocKyDTO hk = new HocKyDTO();
                hk.IMaHK = int.Parse(dt.Rows[i]["MaHK"].ToString());
                hk.STenHK = dt.Rows[i]["TenHK"].ToString();
                hk.SGhiChu = dt.Rows[i]["GhiChu"].ToString();
                lsthk.Add(hk);
            }
            DataProvider.CloseConnect(con);
            return lsthk;
        }

        public static List<HocKyDTO> LoadcbHocKy()
        {
            string sQuery = @"SELECT * FROM HocKy";
            con = DataProvider.Connect();
            DataTable dt = DataProvider.LayDataTable(sQuery, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HocKyDTO> lsthk = new List<HocKyDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HocKyDTO hk = new HocKyDTO();
                hk.IMaHK = int.Parse(dt.Rows[i]["MaHK"].ToString());
                hk.STenHK = dt.Rows[i]["TenHK"].ToString();
                hk.SGhiChu = dt.Rows[i]["GhiChu"].ToString();
                lsthk.Add(hk);
            }
            DataProvider.CloseConnect(con);
            return lsthk;
        }

        public static bool ThemHocKy(HocKyDTO hkDTO)
        {
            string sQuery = string.Format("INSERT INTO HocKy VALUES (N'{0}', N'{1}')", hkDTO.STenHK, hkDTO.SGhiChu);
            con = DataProvider.Connect();
            try
            {
                DataProvider.ExecuteQueriesNonQuery(sQuery, con);
                DataProvider.CloseConnect(con);
                return true;
            }
            catch (Exception ex) { DataProvider.CloseConnect(con); return false; }
        }

        public static bool SuaHocKy(HocKyDTO hkDTO)
        {
            string sQuery = string.Format("UPDATE HocKy SET TenHK=N'{0}', GhiChu=N'{1}' WHERE MaHK={2}", hkDTO.STenHK, hkDTO.SGhiChu, hkDTO.IMaHK);
            con = DataProvider.Connect();
            try
            {
                DataProvider.ExecuteQueriesNonQuery(sQuery, con);
                DataProvider.CloseConnect(con);
                return true;
            }
            catch (Exception ex) { DataProvider.CloseConnect(con); return false; }
        }

        public static bool XoaHocKy(HocKyDTO hkDTO)
        {
            string sQuery = string.Format("DELETE HocKy WHERE MaHK={0}", hkDTO.IMaHK);
            con = DataProvider.Connect();
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
