using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnDiem_Click(object sender, EventArgs e)
        {
            frmNhapdiem diem = new frmNhapdiem();
            diem.ShowDialog();
        }

        private void btnKhoi_Click(object sender, EventArgs e)
        {
            frmKhoi khoi = new frmKhoi();
            khoi.ShowDialog();
        }

        private void btnNienkhoa_Click(object sender, EventArgs e)
        {
            frmNienKhoa nk = new frmNienKhoa();
            nk.ShowDialog();
        }

        private void btnHocky_Click(object sender, EventArgs e)
        {
            frmHocKy hk = new frmHocKy();
            hk.ShowDialog();
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
            Lop lop = new Lop();
            lop.ShowDialog();
        }

        private void btnHocsinh_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.ShowDialog();
        }

        private void btnMonhoc_Click(object sender, EventArgs e)
        {
            frmMonHoc mh = new frmMonHoc();
            mh.ShowDialog();
        }
    }
}
