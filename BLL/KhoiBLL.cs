using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class KhoiBLL
    {
        public static List<KhoiDTO> LoadKhoi()
        {
            return KhoiProvider.LoadKhoi();
        }
        public static bool ThemKhoi(KhoiDTO khoiDTO)
        {
            return KhoiProvider.ThemKhoi(khoiDTO);
        }
        public static bool XoaKhoi(KhoiDTO khoiDTO)
        {
            return KhoiProvider.XoaKhoi(khoiDTO);
        }
        public static bool SuaKhoi(KhoiDTO khoiDTO)
        {
            return KhoiProvider.SuaKhoi(khoiDTO);
        }
        public static List<KhoiDTO> LoadcbKhoi()
        {
            return KhoiProvider.LoadcbKhoi();
        }
    }
}
