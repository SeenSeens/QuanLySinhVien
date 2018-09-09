using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class LopBLL
    {
        public static List<LopDTO> LoadLop()
        {
            return LopProvider.LoadLop();                                           
        }

        public static List<LopDTO> LoadcbLop()
        {
            return LopProvider.LoadcbLop();           
        }

        public static bool ThemLopHoc (LopDTO lopDTO)
        {
            return LopProvider.ThemLopHoc(lopDTO);
        }

        public static bool SuaLopHoc(LopDTO lopDTO)
        {
            return LopProvider.SuaLop(lopDTO);
        }

        public static bool XoaLopHoc(LopDTO lopDTO)
        {
            return LopProvider.XoaLop(lopDTO);
        }
    }
}
