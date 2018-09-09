using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class  HocSinhDTO
    {
        private int iMaHS;
        private string sHoTen;
        private string sGioiTinh;
        private DateTime dtNgaySinh;
        private string sDiaChi;
        private int iMaLop;
        private string sTenLop;
        public int IMaHS { get => iMaHS; set => iMaHS = value; }
        public string SHoTen { get => sHoTen; set => sHoTen = value; }
        public string SGioiTinh { get => sGioiTinh; set => sGioiTinh = value; }
        public DateTime DtNgaySinh { get => dtNgaySinh; set => dtNgaySinh = value; }
        public string SDiaChi { get => sDiaChi; set => sDiaChi = value; }
        public int IMaLop { get => iMaLop; set => iMaLop = value; }
        public string STenLop { get => sTenLop; set => sTenLop = value; }
    }
}
