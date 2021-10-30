using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
   public class NhanVien_BUS
    {
        public static List<NhanVien_DTO> GetNhanVien()
        {
            return NhanVien_DAO.GetNhanVien();
        }
        public static bool ThemNV(NhanVien_DTO p)
        {
            return NhanVien_DAO.ThemNV(p);
        }
        public static bool SuaNV(NhanVien_DTO p)
        {
            return NhanVien_DAO.SuaNV(p);
        }
        public static bool XoaNV(NhanVien_DTO p)
        {
            return NhanVien_DAO.XoaNV(p);
        }
        // Tìm nhân viên theo tên
        public static List<NhanVien_DTO> TimNVTheoTen(string ten)
        {
            return NhanVien_DAO.TimNVTheoTen(ten);
        }
    }
}
