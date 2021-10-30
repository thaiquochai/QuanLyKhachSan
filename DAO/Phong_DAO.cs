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
   public class Phong_DAO
    {
        static SqlConnection con;
        public static List<Phong_DTO> GetPhong()
        {
            string sTruyVan = "select * from phong";
            con = Dataprovider.MoKetNoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Phong_DTO> dslp = new List<Phong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Phong_DTO p = new Phong_DTO();
                p.Maphong = dt.Rows[i]["maphong"].ToString();
                p.Tenphong = dt.Rows[i]["tenphong"].ToString();
                p.Tinhtrang = dt.Rows[i]["tinhtrang"].ToString();
                p.MaLphong = dt.Rows[i]["maLphong"].ToString();
                dslp.Add(p);

            }
            return dslp;
        }
        public static bool ThemPhong(Phong_DTO p)
        {
            string sTruyVan = string.Format(@"insert into phong values(N'{0}',N'{1}',N'{2}',N'{3}')", p.Maphong, p.Tenphong, p.Tinhtrang,p.MaLphong);
            con = Dataprovider.MoKetNoi();
            bool kq = Dataprovider.TruyVanKhongLayDL(sTruyVan, con);
            Dataprovider.DongKetNoi(con);
            return kq;
        }
        public static bool SuaPhong(Phong_DTO p)
        {
            string sTruyVan = string.Format(@"Update phong set maphong=N'{0}',tenphong=N'{1}',tinhtrang=N'{2}',maLphong=N'{3}'where maphong=N'{4}'", p.Maphong, p.Tenphong, p.Tinhtrang, p.MaLphong,p.Maphong);
            con = Dataprovider.MoKetNoi();
            bool kq = Dataprovider.TruyVanKhongLayDL(sTruyVan, con);
            Dataprovider.DongKetNoi(con);
            return kq;
        }
       
        public static bool XoaPhong(Phong_DTO p)
        {
            string sTruyVan = string.Format(@"Delete from phong where maphong=N'{0}'", p.Maphong);
            con = Dataprovider.MoKetNoi();
            bool kq = Dataprovider.TruyVanKhongLayDL(sTruyVan, con);
            Dataprovider.DongKetNoi(con);
            return kq;
        }
        public static List<Phong_DTO> TimPhongTheoTen(string ten)
        {
            string sTruyVan = string.Format(@"select * from phong where maphong like'%{0}%'", ten);
            con = Dataprovider.MoKetNoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Phong_DTO> dslp = new List<Phong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Phong_DTO p = new Phong_DTO();
                p.Maphong = dt.Rows[i]["maphong"].ToString();
                p.Tenphong = dt.Rows[i]["tenphong"].ToString();
                p.Tinhtrang = dt.Rows[i]["tinhtrang"].ToString();
                p.MaLphong = dt.Rows[i]["maLphong"].ToString();
                dslp.Add(p);

            }
            return dslp;
        }
    }
}
