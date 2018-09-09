using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class MonHocBLL
    {
        public static List<MonHocDTO> LoadMonHoc()
        {
            return MonHocProvider.LoadMonHoc();
        }
        public static bool ThemMonHoc(MonHocDTO monhocDTO)
        {
            return MonHocProvider.ThemMonHoc(monhocDTO);
        }
        public static bool XoaMonHoc(MonHocDTO monhocDTO)
        {
            return MonHocProvider.XoaMonHoc(monhocDTO);
        }
        public static bool SuaMonHoc(MonHocDTO monhocDTO)
        {
            return MonHocProvider.SuaMonHoc(monhocDTO);
        }
        public static List<MonHocDTO> LoadcbMonHoc()
        {
            return MonHocProvider.LoadcbMonHoc();
        }
    }
}
