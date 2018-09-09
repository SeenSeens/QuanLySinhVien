using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhoiDTO
    {
        private int iMaKhoi;
        private string sTenKhoi;
        private string sGhiChu;

        public int IMaKhoi { get => iMaKhoi; set => iMaKhoi = value; }
        public string STenKhoi { get => sTenKhoi; set => sTenKhoi = value; }
        public string SGhiChu { get => sGhiChu; set => sGhiChu = value; }
    }
}
