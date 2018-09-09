using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DiemDTO
    {
        private int iMaMH;
        private string sTenMH;
        private int iMaHS;
        private string sTenHS;
        private int iDiemMieng;
        private int iDiem1t;
        private int DiemThi;
        private int DiemTB;

        public int IMaMH { get => iMaMH; set => iMaMH = value; }
        public string STenMH { get => sTenMH; set => sTenMH = value; }
        public int IMaHS { get => iMaHS; set => iMaHS = value; }
        public int IDiemMieng { get => iDiemMieng; set => iDiemMieng = value; }
        public string STenHS { get => sTenHS; set => sTenHS = value; }
        public int IDiem1t { get => iDiem1t; set => iDiem1t = value; }
        public int DiemThi1 { get => DiemThi; set => DiemThi = value; }
        public int DiemTB1 { get => DiemTB; set => DiemTB = value; }
    }
}
