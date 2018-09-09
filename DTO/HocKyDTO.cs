using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HocKyDTO
    {
        private int iMaHK;
        private string sTenHK;
        private string sGhiChu;

        public int IMaHK { get => iMaHK; set => iMaHK = value; }
        public string STenHK { get => sTenHK; set => sTenHK = value; }
        public string SGhiChu { get => sGhiChu; set => sGhiChu = value; }
    }
}
