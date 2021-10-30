using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
  public class KhachHang_BUS
    {
        public static List<KhachHang_DTO> GetKH()
        {
            return KhachHang_DAO.GetKhachHang();
        }
        public static List<KhachHang_DTO> GetKhachHangByMaPhong(string mp)
        {
            return KhachHang_DAO.GetKhachHangByMaPhong(mp);
        }
        public static List<KhachHang_DTO> GetKhachHangByTinhTrang()
        {
            return KhachHang_DAO.GetKhachHangByTinhTrang();
        }
        public static bool ThemKH(KhachHang_DTO p)
        {
            return KhachHang_DAO.ThemKH(p);
        }
        public static bool SuaKH(KhachHang_DTO p)
        {
            return KhachHang_DAO.SuaKH(p);
        }
        public static bool XoaKH(KhachHang_DTO p)
        {
            return KhachHang_DAO.XoaKH(p);
        }
        // Tìm nhân viên theo tên
        public static List<KhachHang_DTO> TimKHTheoTen(string ten)
        {
            return KhachHang_DAO.TimKHTheoTen(ten);
        }
        public static List<KhachHang_DTO> TimKHTheoName(string ten)
        {
            return KhachHang_DAO.TimKHTheoNam(ten);
        }
        public static List<KhachHang_DTO> LoadMaPhongByMaKH(string ten)
        {
            return KhachHang_DAO.LoadMaPhongByMaKH(ten);
        }
        public static List<KhachHang_DTO> LoadNgayByMaPhong(string ten)
        {
            return KhachHang_DAO.LoadNgayByMaPhong(ten);
        }
        public static List<KhachHang_DTO> TimKHTheoNgaDat(DateTime ngay)
        {
            return KhachHang_DAO.TimKHTheoNgaDat(ngay);
        }
        public static List<KhachHang_DTO> TimKHTheoMaphong(string ten)
        {
            return KhachHang_DAO.TimKHTheoMaphong(ten);
        }
    }
}
