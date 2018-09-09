using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NienKhoaBLL
    {
        public static List<NienKhoaDTO> LoadNienKhoa()
        {
            return NienKhoaProvider.LoadNienKhoa();
        }
        public static List<NienKhoaDTO> LoadcbNienKhoa()
        {
            return NienKhoaProvider.LoadcbNienKhoa();
        }
        public static bool ThemNienKhoa(NienKhoaDTO nienKhoaDTO)
        {
            return NienKhoaProvider.ThemNienKhoa(nienKhoaDTO);
        }
        public static bool XoaNienKhoa(NienKhoaDTO nienKhoaDTO)
        {
            return NienKhoaProvider.XoaNienKhoa(nienKhoaDTO);
        }
        public static bool SuaNienKhoa(NienKhoaDTO nienKhoaDTO)
        {
            return NienKhoaProvider.SuaNienKhoa(nienKhoaDTO);
        }
    }
}
