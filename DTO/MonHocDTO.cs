using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonHocDTO
    {
        private int iMaMH;
        private string sTenMH;
        private int iSoTiet;
        private int iMaHK;
        private string sTenHK;
        private int iMaKhoi;
        private string sTenKhoi;

        public int IMaMH { get => iMaMH; set => iMaMH = value; }
        public string STenMH { get => sTenMH; set => sTenMH = value; }
        public int ISoTiet { get => iSoTiet; set => iSoTiet = value; }
        public int IMaHK { get => iMaHK; set => iMaHK = value; }
        public string STenHK { get => sTenHK; set => sTenHK = value; }
        public int IMaKhoi { get => iMaKhoi; set => iMaKhoi = value; }
        public string STenKhoi { get => sTenKhoi; set => sTenKhoi = value; }
    }
}
