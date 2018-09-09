using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LopDTO
    {
        private int iMaLop;
        private string sTenLop;
        private int iSiSo;
        private int iMaNienKhoa;
        private string sTenNienKhoa;
        private int iMaKhoi;
        private string sTenKhoi;

        public int IMaLop { get => iMaLop; set => iMaLop = value; }
        public string STenLop { get => sTenLop; set => sTenLop = value; }
        public int ISiSo { get => iSiSo; set => iSiSo = value; }
        public int IMaNienKhoa { get => iMaNienKhoa; set => iMaNienKhoa = value; }
        public string STenNienKhoa { get => sTenNienKhoa; set => sTenNienKhoa = value; }
        public int IMaKhoi { get => iMaKhoi; set => iMaKhoi = value; }
        public string STenKhoi { get => sTenKhoi; set => sTenKhoi = value; }
    }
}
