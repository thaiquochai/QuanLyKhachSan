using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAO
{
   public class LoaiPhong_DAO
    {
        static SqlConnection con;
        public static List<LoaiPhong_DTO> GetLoaiPhong()
        {
            string sTruyVan = "select * from loaiphong";
            con = Dataprovider.MoKetNoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<LoaiPhong_DTO> dslp = new List<LoaiPhong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LoaiPhong_DTO p = new LoaiPhong_DTO();
                p.MaLphong = dt.Rows[i]["maLphong"].ToString();
                p.TenLphong = dt.Rows[i]["tenLphong"].ToString();
                p.Dongia = double.Parse(dt.Rows[i]["dongia"].ToString());
                dslp.Add(p);

            }
            return dslp;
        }
        public static bool ThemLoaiPhong(LoaiPhong_DTO p)
        {
            string sTruyVan = string.Format(@"insert into loaiphong values(N'{0}',N'{1}',N'{2}')", p.MaLphong, p.TenLphong, p.Dongia);
            con = Dataprovider.MoKetNoi();
            bool kq = Dataprovider.TruyVanKhongLayDL(sTruyVan, con);
            Dataprovider.DongKetNoi(con);
            return kq;
        }
        public static bool SuaLoaiPhong(LoaiPhong_DTO p)
        {
            string sTruyVan = string.Format(@"Update loaiphong set maLphong=N'{0}',tenLphong=N'{1}',dongia=N'{2}'where maLphong=N'{3}'", p.MaLphong, p.TenLphong, p.Dongia, p.MaLphong);
            con = Dataprovider.MoKetNoi();
            bool kq = Dataprovider.TruyVanKhongLayDL(sTruyVan, con);
            Dataprovider.DongKetNoi(con);
            return kq;
        }
        public static bool XoaLoaiPhong(LoaiPhong_DTO p)
        {
            string sTruyVan = string.Format(@"Delete from loaiphong where maLphong=N'{0}'", p.MaLphong);
            con = Dataprovider.MoKetNoi();
            bool kq = Dataprovider.TruyVanKhongLayDL(sTruyVan, con);
            Dataprovider.DongKetNoi(con);
            return kq;
        }
        public static List<LoaiPhong_DTO> TimLoaiPhongTheoTen(string ten)
        {
            string sTruyVan = string.Format(@"select * from loaiphong where maLphong like'%{0}%'", ten);
            con = Dataprovider.MoKetNoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<LoaiPhong_DTO> dslp = new List<LoaiPhong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LoaiPhong_DTO p = new LoaiPhong_DTO();
                p.MaLphong = dt.Rows[i]["maLphong"].ToString();
                p.TenLphong = dt.Rows[i]["tenLphong"].ToString();
                p.Dongia = double.Parse(dt.Rows[i]["dongia"].ToString());
                dslp.Add(p);

            }
            return dslp;
        }
        public static List<LoaiPhong_DTO> LoadDonGiaByMaPhong(string ten)
        {
            string sTruyVan = string.Format(@"SELECT * FROM dbo.loaiphong,dbo.phong 
                                            WHERE loaiphong.maLphong=phong.maLphong AND maphong=N'{0}'", ten);
            con = Dataprovider.MoKetNoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<LoaiPhong_DTO> dslp = new List<LoaiPhong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LoaiPhong_DTO p = new LoaiPhong_DTO();
                p.MaLphong = dt.Rows[i]["maLphong"].ToString();
                p.TenLphong = dt.Rows[i]["tenLphong"].ToString();
                p.Dongia = double.Parse(dt.Rows[i]["dongia"].ToString());
                dslp.Add(p);

            }
            return dslp;
        }
    }
}
