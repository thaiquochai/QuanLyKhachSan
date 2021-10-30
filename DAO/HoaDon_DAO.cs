using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;
namespace DAO
{
  public class HoaDon_DAO
    {
        static SqlConnection con;
        public static List<HoaDon_DTO> GetHD()
        {
            string sTruyVan = "select * from hoadon";
            con = Dataprovider.MoKetNoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDon_DTO> dslp = new List<HoaDon_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDon_DTO p = new HoaDon_DTO();
                p.Mahd = dt.Rows[i]["mahd"].ToString();
                p.Makh= dt.Rows[i]["makh"].ToString();
                p.Ngaylap = Convert.ToDateTime(dt.Rows[i]["ngaylap"].ToString());
                p.Songaytro =int.Parse( dt.Rows[i]["songaytro"].ToString());
                p.Tienphong =double.Parse(dt.Rows[i]["tienphong"].ToString());
                p.Thanhtien =double.Parse(dt.Rows[i]["thanhtien"].ToString());
                p.Maphong = dt.Rows[i]["maphong"].ToString();
               

                dslp.Add(p);

            }
            return dslp;
        }
        public static List<HoaDon_DTO> GetHDByDate(DateTime ngay)
        {
            string sTruyVan =string.Format(@"select * from hoadon where MONTH(ngaylap)=N'{0}' AND YEAR(ngaylap)=N'{1}'",ngay,ngay);
            con = Dataprovider.MoKetNoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDon_DTO> dslp = new List<HoaDon_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDon_DTO p = new HoaDon_DTO();
                p.Mahd = dt.Rows[i]["mahd"].ToString();
                p.Makh = dt.Rows[i]["makh"].ToString();
                p.Ngaylap = Convert.ToDateTime(dt.Rows[i]["ngaylap"].ToString());
                p.Songaytro = int.Parse(dt.Rows[i]["songaytro"].ToString());
                p.Tienphong = double.Parse(dt.Rows[i]["tienphong"].ToString());
                p.Thanhtien = double.Parse(dt.Rows[i]["thanhtien"].ToString());
                p.Maphong = dt.Rows[i]["maphong"].ToString();


                dslp.Add(p);

            }
            return dslp;
        }
        public static bool ThemHD(HoaDon_DTO p)
        {
            string sTruyVan = string.Format(@"insert into hoadon values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}') update phong set tinhtrang= N'Trống' where maphong='{7}' update khachhang set tinhtrang=N'Đã thanh toán' where makh='{8}'",
             p.Mahd, p.Makh, p.Ngaylap, p.Songaytro, p.Tienphong, p.Thanhtien, p.Maphong,p.Maphong,p.Makh);
            con = Dataprovider.MoKetNoi();
            bool kq = Dataprovider.TruyVanKhongLayDL(sTruyVan, con);
            Dataprovider.DongKetNoi(con);
            return kq;
        }
        public static bool SuaHD(HoaDon_DTO p)
        {
            string sTruyVan = string.Format(@"Update hoadon set mahd=N'{0}',makh=N'{1}',ngaylap=N'{2}',songaytro=N'{3}',tienphong=N'{4}',thanhtien=N'{5}',maphong=N'{6}'where mahd=N'{7}'",
             p.Mahd, p.Makh, p.Ngaylap, p.Songaytro, p.Tienphong, p.Thanhtien, p.Maphong, p.Mahd);
            con = Dataprovider.MoKetNoi();
            bool kq = Dataprovider.TruyVanKhongLayDL(sTruyVan, con);
            Dataprovider.DongKetNoi(con);
            return kq;
        }
        public static bool XoaHD(HoaDon_DTO p)
        {
            string sTruyVan = string.Format(@"Delete from hoadon where mahd=N'{0}'", p.Mahd);
            con = Dataprovider.MoKetNoi();
            bool kq = Dataprovider.TruyVanKhongLayDL(sTruyVan, con);
            Dataprovider.DongKetNoi(con);
            return kq;
        }
        public static List<HoaDon_DTO> TimHDTheoTen(string ten)
        {
            string sTruyVan = string.Format(@"select * from hoadon where mahd like'%{0}%'", ten);
            con = Dataprovider.MoKetNoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDon_DTO> dslp = new List<HoaDon_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDon_DTO p = new HoaDon_DTO();
                p.Mahd = dt.Rows[i]["mahd"].ToString();
                p.Makh = dt.Rows[i]["makh"].ToString();
                p.Ngaylap = Convert.ToDateTime(dt.Rows[i]["ngaylap"].ToString());
                p.Songaytro = int.Parse(dt.Rows[i]["songaytro"].ToString());
                p.Tienphong = double.Parse(dt.Rows[i]["tienphong"].ToString());
                p.Thanhtien = double.Parse(dt.Rows[i]["thanhtien"].ToString());
                p.Maphong = dt.Rows[i]["maphong"].ToString();


                dslp.Add(p);

            }
            return dslp;
        }
        public static List<HoaDon_DTO> TimHDTheoMaKH(string ten)
        {
            string sTruyVan = string.Format(@"select * from hoadon where makh like'%{0}%'", ten);
            con = Dataprovider.MoKetNoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDon_DTO> dslp = new List<HoaDon_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDon_DTO p = new HoaDon_DTO();
                p.Mahd = dt.Rows[i]["mahd"].ToString();
                p.Makh = dt.Rows[i]["makh"].ToString();
                p.Ngaylap = Convert.ToDateTime(dt.Rows[i]["ngaylap"].ToString());
                p.Songaytro = int.Parse(dt.Rows[i]["songaytro"].ToString());
                p.Tienphong = double.Parse(dt.Rows[i]["tienphong"].ToString());
                p.Thanhtien = double.Parse(dt.Rows[i]["thanhtien"].ToString());
                p.Maphong = dt.Rows[i]["maphong"].ToString();


                dslp.Add(p);

            }
            return dslp;
        }
        public static List<HoaDon_DTO> TimHDTheoMaphong(string ma)
        {
            string sTruyVan = string.Format(@"select * from hoadon where maphong like'%{0}%'", ma);
            con = Dataprovider.MoKetNoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDon_DTO> dslp = new List<HoaDon_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDon_DTO p = new HoaDon_DTO();
                p.Mahd = dt.Rows[i]["mahd"].ToString();
                p.Makh = dt.Rows[i]["makh"].ToString();
                p.Ngaylap = Convert.ToDateTime(dt.Rows[i]["ngaylap"].ToString());
                p.Songaytro = int.Parse(dt.Rows[i]["songaytro"].ToString());
                p.Tienphong = double.Parse(dt.Rows[i]["tienphong"].ToString());
                p.Thanhtien = double.Parse(dt.Rows[i]["thanhtien"].ToString());
                p.Maphong = dt.Rows[i]["maphong"].ToString();


                dslp.Add(p);

            }
            return dslp;
        }
        public static List<HoaDon_DTO> TimHDTheoNgay(DateTime ngay)
        {
            string sTruyVan = string.Format(@"select * from hoadon where ngaylap='{0}'", ngay);
            con = Dataprovider.MoKetNoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDon_DTO> dslp = new List<HoaDon_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDon_DTO p = new HoaDon_DTO();
                p.Mahd = dt.Rows[i]["mahd"].ToString();
                p.Makh = dt.Rows[i]["makh"].ToString();
                p.Ngaylap = Convert.ToDateTime(dt.Rows[i]["ngaylap"].ToString());
                p.Songaytro = int.Parse(dt.Rows[i]["songaytro"].ToString());
                p.Tienphong = double.Parse(dt.Rows[i]["tienphong"].ToString());
                p.Thanhtien = double.Parse(dt.Rows[i]["thanhtien"].ToString());
                p.Maphong = dt.Rows[i]["maphong"].ToString();


                dslp.Add(p);

            }
            return dslp;
        }
    }
}
