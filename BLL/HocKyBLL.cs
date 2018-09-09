using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HocKyBLL
    {
        public static List<HocKyDTO> LoadHocKy()
        {
            return HocKyProvider.LoadHocKy();
        }
        public static List<HocKyDTO> LoadcbHocKy()
        {
            return HocKyProvider.LoadcbHocKy();
        }
        public static bool ThemHocKy (HocKyDTO hkDTO)
        {
            return HocKyProvider.ThemHocKy(hkDTO);
        }
        public static bool XoaHocKy (HocKyDTO hkDTO)
        {
            return HocKyProvider.XoaHocKy(hkDTO);
        }
        public static bool SuaHocKy (HocKyDTO hkDTO)
        {
            return HocKyProvider.SuaHocKy(hkDTO);
        }
    }
}
