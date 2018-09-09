using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NienKhoaDTO
    {
        private int iMaNienKhoa;
        private string sTenNienKhoa;
        private string sGhiChu;

        public int IMaNienKhoa { get => iMaNienKhoa; set => iMaNienKhoa = value; }
        public string STenNienKhoa { get => sTenNienKhoa; set => sTenNienKhoa = value; }
        public string SGhiChu { get => sGhiChu; set => sGhiChu = value; }
    }
}
