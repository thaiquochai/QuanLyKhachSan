using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
   public class Phong_BUS
    {
        public static int TableWidth = 102;
        public static int TableHeight = 100;
        public static List<Phong_DTO> GetPhong()
        {
            return Phong_DAO.GetPhong();
        }
        public static bool ThemPhong(Phong_DTO p)
        {
            return Phong_DAO.ThemPhong(p);
        }
        public static bool SuaPhong(Phong_DTO p)
        {
            return Phong_DAO.SuaPhong(p);
        }
        public static bool XoaPhong(Phong_DTO p)
        {
            return Phong_DAO.XoaPhong(p);
        }
        // Tìm nhân viên theo tên
        public static List<Phong_DTO> TimPhongTheoTen(string ten)
        {
            return Phong_DAO.TimPhongTheoTen(ten);
        }
    }
}
