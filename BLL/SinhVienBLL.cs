using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class SinhVienBLL
    {
        // Load SinhVien
        public static List<HocSinhDTO> LoadSinhVien()
        {
            return SinhVienProvider.LoadSinhVien();
        }

        // Thêm SinhVien
        public static bool ThemSinhVien(HocSinhDTO svDTO)
        {
            return SinhVienProvider.ThemSinhVien(svDTO);
        }

        // Sửa Sinh Viên
        public static bool SuaSinhVien(HocSinhDTO svDTO)
        {
            return SinhVienProvider.SuaSinhVien(svDTO);
        }

        // Xóa Sinh Viên
        public static bool XoaSinhVien(HocSinhDTO svDTO)
        {
            return SinhVienProvider.XoaSinhVien(svDTO);
        }

        // Tìm Kiếm Sinh Viên
        public static List<HocSinhDTO> TimKiemSinhVien(string key)
        {
            return SinhVienProvider.TimKiemSinhVien(key);
        }
    }
}
