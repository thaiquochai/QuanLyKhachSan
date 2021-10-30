using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class LoaiPhong_BUS
    {
        public static int TableWidth = 102;
        public static int TableHeight = 100;
        public static List<LoaiPhong_DTO> GetLoaiPhong()
        {
            return LoaiPhong_DAO.GetLoaiPhong();
        }
        public static bool ThemLoaiPhong(LoaiPhong_DTO p)
        {
            return LoaiPhong_DAO.ThemLoaiPhong(p);
        }
        public static bool SuaLoaiPhong(LoaiPhong_DTO p)
        {
            return LoaiPhong_DAO.SuaLoaiPhong(p);
        }
        public static bool XoaLoaiPhong(LoaiPhong_DTO p)
        {
            return LoaiPhong_DAO.XoaLoaiPhong(p);
        }
        // Tìm nhân viên theo tên
        public static List<LoaiPhong_DTO> TimLoiaPhongTheoTen(string ten)
        {
            return LoaiPhong_DAO.TimLoaiPhongTheoTen(ten);
        }
        public static List<LoaiPhong_DTO> LoadDonGiaByMaPhong(string ten)
        {
            return LoaiPhong_DAO.LoadDonGiaByMaPhong(ten);
        }
    }
}
