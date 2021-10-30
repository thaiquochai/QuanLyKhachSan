using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
   public class HoaDon_BUS
    {
        public static List<HoaDon_DTO> GetHoaDon()
        {
            return HoaDon_DAO.GetHD();
        }
        public static List<HoaDon_DTO> GetHDByDate(DateTime p)
        {
            return HoaDon_DAO.GetHDByDate(p);
        }
        public static bool ThemHD(HoaDon_DTO p)
        {
            return HoaDon_DAO.ThemHD(p);
        }
        public static bool SuaHD(HoaDon_DTO p)
        {
            return HoaDon_DAO.SuaHD(p);
        }
        public static bool XoaHD(HoaDon_DTO p)
        {
            return HoaDon_DAO.XoaHD(p);
        }
        // Tìm nhân viên theo tên
        public static List<HoaDon_DTO> TimHDTheoTen(string ten)
        {
            return HoaDon_DAO.TimHDTheoTen(ten);
        }
        public static List<HoaDon_DTO> TimHDTheoMaphong(string ten)
        {
            return HoaDon_DAO.TimHDTheoMaphong(ten);
        }
        public static List<HoaDon_DTO> TimHDTheoMaKH(string ten)
        {
            return HoaDon_DAO.TimHDTheoMaKH(ten);
        }
        public static List<HoaDon_DTO> TimHDTheoNgay(DateTime ngay)
        {
            return HoaDon_DAO.TimHDTheoNgay(ngay);
        }
    }
}
