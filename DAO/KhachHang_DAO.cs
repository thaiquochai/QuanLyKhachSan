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
   public class KhachHang_DAO
    {
        static SqlConnection con;
        public static List<KhachHang_DTO> GetKhachHang()
        {
            string sTruyVan = "select * from khachhang";
            con = Dataprovider.MoKetNoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<KhachHang_DTO> dslp = new List<KhachHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhachHang_DTO p = new KhachHang_DTO();
                p.Makh = dt.Rows[i]["makh"].ToString();
                p.Tenkh = dt.Rows[i]["tenkh"].ToString();
                p.Ngaysinhkh=Convert.ToDateTime(dt.Rows[i]["ngaysinhkh"].ToString());
                p.Gioitinhkh = dt.Rows[i]["gioitinhkh"].ToString();
                p.Diachikh = dt.Rows[i]["diachikh"].ToString();
                p.Sdtkh = dt.Rows[i]["sdtkh"].ToString();
                p.Cmnd = dt.Rows[i]["cmnd"].ToString();
                p.Quoctich = dt.Rows[i]["quoctich"].ToString();
                p.Ngaydangky=Convert.ToDateTime(dt.Rows[i]["ngaydangky"].ToString());
                p.Ngaynhan = Convert.ToDateTime(dt.Rows[i]["ngaynhan"].ToString());
                p.Ngaytra = Convert.ToDateTime(dt.Rows[i]["ngaytra"].ToString());
                p.Maphong = dt.Rows[i]["maphong"].ToString();
                p.Tinhtrang = dt.Rows[i]["tinhtrang"].ToString();
                dslp.Add(p);

            }
            return dslp;
        }
        public static List<KhachHang_DTO> GetKhachHangByTinhTrang()
        {
            string sTruyVan = "select * from khachhang where tinhtrang=N'Đã nhận'";
            con = Dataprovider.MoKetNoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<KhachHang_DTO> dslp = new List<KhachHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhachHang_DTO p = new KhachHang_DTO();
                p.Makh = dt.Rows[i]["makh"].ToString();
                p.Tenkh = dt.Rows[i]["tenkh"].ToString();
                p.Ngaysinhkh = Convert.ToDateTime(dt.Rows[i]["ngaysinhkh"].ToString());
                p.Gioitinhkh = dt.Rows[i]["gioitinhkh"].ToString();
                p.Diachikh = dt.Rows[i]["diachikh"].ToString();
                p.Sdtkh = dt.Rows[i]["sdtkh"].ToString();
                p.Cmnd = dt.Rows[i]["cmnd"].ToString();
                p.Quoctich = dt.Rows[i]["quoctich"].ToString();
                p.Ngaydangky = Convert.ToDateTime(dt.Rows[i]["ngaydangky"].ToString());
                p.Ngaynhan = Convert.ToDateTime(dt.Rows[i]["ngaynhan"].ToString());
                p.Ngaytra = Convert.ToDateTime(dt.Rows[i]["ngaytra"].ToString());
                p.Maphong = dt.Rows[i]["maphong"].ToString();
                p.Tinhtrang = dt.Rows[i]["tinhtrang"].ToString();
                dslp.Add(p);

            }
            return dslp;
        }
        public static List<KhachHang_DTO> GetKhachHangByMaPhong(string mp)
        {
            string sTruyVan =string.Format(@"select * from khachhang where maphong=N'{0}'",mp);
            con = Dataprovider.MoKetNoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<KhachHang_DTO> dslp = new List<KhachHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhachHang_DTO p = new KhachHang_DTO();
                p.Makh = dt.Rows[i]["makh"].ToString();
                p.Tenkh = dt.Rows[i]["tenkh"].ToString();
                p.Ngaysinhkh = Convert.ToDateTime(dt.Rows[i]["ngaysinhkh"].ToString());
                p.Gioitinhkh = dt.Rows[i]["gioitinhkh"].ToString();
                p.Diachikh = dt.Rows[i]["diachikh"].ToString();
                p.Sdtkh = dt.Rows[i]["sdtkh"].ToString();
                p.Cmnd = dt.Rows[i]["cmnd"].ToString();
                p.Quoctich = dt.Rows[i]["quoctich"].ToString();
                p.Ngaydangky = Convert.ToDateTime(dt.Rows[i]["ngaydangky"].ToString());
                p.Ngaynhan = Convert.ToDateTime(dt.Rows[i]["ngaynhan"].ToString());
                p.Ngaytra = Convert.ToDateTime(dt.Rows[i]["ngaytra"].ToString());
                p.Maphong = dt.Rows[i]["maphong"].ToString();
                p.Tinhtrang = dt.Rows[i]["tinhtrang"].ToString();
                dslp.Add(p);

            }
            return dslp;
        }
        public static List<KhachHang_DTO> LoadMaPhongByMaKH(string ten)
        {
            string sTruyVan =string.Format( "select * from khachhang where makh=N'{0}'",ten);
            con = Dataprovider.MoKetNoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<KhachHang_DTO> dslp = new List<KhachHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhachHang_DTO p = new KhachHang_DTO();
                p.Makh = dt.Rows[i]["makh"].ToString();
                p.Tenkh = dt.Rows[i]["tenkh"].ToString();
                p.Ngaysinhkh = Convert.ToDateTime(dt.Rows[i]["ngaysinhkh"].ToString());
                p.Gioitinhkh = dt.Rows[i]["gioitinhkh"].ToString();
                p.Diachikh = dt.Rows[i]["diachikh"].ToString();
                p.Sdtkh = dt.Rows[i]["sdtkh"].ToString();
                p.Cmnd = dt.Rows[i]["cmnd"].ToString();
                p.Quoctich = dt.Rows[i]["quoctich"].ToString();
                p.Ngaydangky = Convert.ToDateTime(dt.Rows[i]["ngaydangky"].ToString());
                p.Ngaynhan = Convert.ToDateTime(dt.Rows[i]["ngaynhan"].ToString());
                p.Ngaytra = Convert.ToDateTime(dt.Rows[i]["ngaytra"].ToString());
                p.Maphong = dt.Rows[i]["maphong"].ToString();
                p.Tinhtrang = dt.Rows[i]["tinhtrang"].ToString();
                dslp.Add(p);

            }
            return dslp;
        }
        public static List<KhachHang_DTO> LoadNgayByMaPhong(string ten)
        {
            string sTruyVan = string.Format("select * from khachhang where maphong=N'{0}'", ten);
            con = Dataprovider.MoKetNoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<KhachHang_DTO> dslp = new List<KhachHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhachHang_DTO p = new KhachHang_DTO();
                p.Makh = dt.Rows[i]["makh"].ToString();
                p.Tenkh = dt.Rows[i]["tenkh"].ToString();
                p.Ngaysinhkh = Convert.ToDateTime(dt.Rows[i]["ngaysinhkh"].ToString());
                p.Gioitinhkh = dt.Rows[i]["gioitinhkh"].ToString();
                p.Diachikh = dt.Rows[i]["diachikh"].ToString();
                p.Sdtkh = dt.Rows[i]["sdtkh"].ToString();
                p.Cmnd = dt.Rows[i]["cmnd"].ToString();
                p.Quoctich = dt.Rows[i]["quoctich"].ToString();
                p.Ngaydangky = Convert.ToDateTime(dt.Rows[i]["ngaydangky"].ToString());
                p.Ngaynhan = Convert.ToDateTime(dt.Rows[i]["ngaynhan"].ToString());
                p.Ngaytra = Convert.ToDateTime(dt.Rows[i]["ngaytra"].ToString());
                p.Maphong = dt.Rows[i]["maphong"].ToString();
                p.Tinhtrang = dt.Rows[i]["tinhtrang"].ToString();
                dslp.Add(p);

            }
            return dslp;
        }
        public static bool ThemKH(KhachHang_DTO p)
        {
            string sTruyVan = string.Format(@"insert into khachhang values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}',N'{9}',N'{10}',N'{11}',N'{12}') update phong set tinhtrang= N'{13}' where maphong='{14}' ",
             p.Makh, p.Tenkh, p.Ngaysinhkh, p.Gioitinhkh,p.Diachikh,p.Sdtkh,p.Cmnd,p.Quoctich,p.Ngaydangky,p.Ngaynhan,p.Ngaytra,p.Maphong,p.Tinhtrang,p.Tinhtrang,p.Maphong);
            con = Dataprovider.MoKetNoi();
            bool kq = Dataprovider.TruyVanKhongLayDL(sTruyVan, con);
            Dataprovider.DongKetNoi(con);
            return kq;
        }
        public static bool SuaKH(KhachHang_DTO p)
        {
            string sTruyVan = string.Format(@"Update khachhang set makh=N'{0}',tenkh=N'{1}',ngaysinhkh=N'{2}',gioitinhkh=N'{3}',diachikh=N'{4}',sdtkh=N'{5}',cmnd=N'{6}',quoctich=N'{7}',ngaydangky=N'{8}',ngaynhan=N'{9}',ngaytra=N'{10}',maphong=N'{11}',tinhtrang=N'{12}'where makh=N'{13}' update phong set tinhtrang= N'{14}' where maphong='{15}'",
                p.Makh, p.Tenkh, p.Ngaysinhkh, p.Gioitinhkh, p.Diachikh, p.Sdtkh, p.Cmnd, p.Quoctich, p.Ngaydangky, p.Ngaynhan, p.Ngaytra, p.Maphong,p.Tinhtrang,p.Makh,p.Tinhtrang,p.Maphong);
            con = Dataprovider.MoKetNoi();
            bool kq = Dataprovider.TruyVanKhongLayDL(sTruyVan, con);
            Dataprovider.DongKetNoi(con);
            return kq;
        }
        public static bool XoaKH(KhachHang_DTO p)
        {
            string sTruyVan = string.Format(@"Delete from khachhang where makh=N'{0}'", p.Makh);
            con = Dataprovider.MoKetNoi();
            bool kq = Dataprovider.TruyVanKhongLayDL(sTruyVan, con);
            Dataprovider.DongKetNoi(con);
            return kq;
        }
        public static List<KhachHang_DTO> TimKHTheoTen(string ten)
        {
            string sTruyVan = string.Format(@"select * from khachhang where makh like'%{0}%'", ten);
            con = Dataprovider.MoKetNoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<KhachHang_DTO> dslp = new List<KhachHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhachHang_DTO p = new KhachHang_DTO();
                p.Makh = dt.Rows[i]["makh"].ToString();
                p.Tenkh = dt.Rows[i]["tenkh"].ToString();
                p.Ngaysinhkh = Convert.ToDateTime(dt.Rows[i]["ngaysinhkh"].ToString());
                p.Gioitinhkh = dt.Rows[i]["gioitinhkh"].ToString();
                p.Diachikh = dt.Rows[i]["diachikh"].ToString();
                p.Sdtkh = dt.Rows[i]["sdtkh"].ToString();
                p.Cmnd = dt.Rows[i]["cmnd"].ToString();
                p.Quoctich = dt.Rows[i]["quoctich"].ToString();
                p.Ngaydangky = Convert.ToDateTime(dt.Rows[i]["ngaydangky"].ToString());
                p.Ngaynhan = Convert.ToDateTime(dt.Rows[i]["ngaynhan"].ToString());
                p.Ngaytra = Convert.ToDateTime(dt.Rows[i]["ngaytra"].ToString());
                p.Maphong = dt.Rows[i]["maphong"].ToString();
                p.Tinhtrang = dt.Rows[i]["tinhtrang"].ToString();
                dslp.Add(p);

            }
            return dslp;
        }
        public static List<KhachHang_DTO> TimKHTheoNam(string ten)
        {
            string sTruyVan = string.Format(@"select * from khachhang where tenkh like'%{0}%'", ten);
            con = Dataprovider.MoKetNoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<KhachHang_DTO> dslp = new List<KhachHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhachHang_DTO p = new KhachHang_DTO();
                p.Makh = dt.Rows[i]["makh"].ToString();
                p.Tenkh = dt.Rows[i]["tenkh"].ToString();
                p.Ngaysinhkh = Convert.ToDateTime(dt.Rows[i]["ngaysinhkh"].ToString());
                p.Gioitinhkh = dt.Rows[i]["gioitinhkh"].ToString();
                p.Diachikh = dt.Rows[i]["diachikh"].ToString();
                p.Sdtkh = dt.Rows[i]["sdtkh"].ToString();
                p.Cmnd = dt.Rows[i]["cmnd"].ToString();
                p.Quoctich = dt.Rows[i]["quoctich"].ToString();
                p.Ngaydangky = Convert.ToDateTime(dt.Rows[i]["ngaydangky"].ToString());
                p.Ngaynhan = Convert.ToDateTime(dt.Rows[i]["ngaynhan"].ToString());
                p.Ngaytra = Convert.ToDateTime(dt.Rows[i]["ngaytra"].ToString());
                p.Maphong = dt.Rows[i]["maphong"].ToString();
                p.Tinhtrang = dt.Rows[i]["tinhtrang"].ToString();
                dslp.Add(p);

            }
            return dslp;
        }
        public static List<KhachHang_DTO> TimKHTheoNgaDat(DateTime ngay)
        {
            string sTruyVan = string.Format(@"select * from khachhang where ngaydangky='{0}'", ngay);
            con = Dataprovider.MoKetNoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<KhachHang_DTO> dslp = new List<KhachHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhachHang_DTO p = new KhachHang_DTO();
                p.Makh = dt.Rows[i]["makh"].ToString();
                p.Tenkh = dt.Rows[i]["tenkh"].ToString();
                p.Ngaysinhkh = Convert.ToDateTime(dt.Rows[i]["ngaysinhkh"].ToString());
                p.Gioitinhkh = dt.Rows[i]["gioitinhkh"].ToString();
                p.Diachikh = dt.Rows[i]["diachikh"].ToString();
                p.Sdtkh = dt.Rows[i]["sdtkh"].ToString();
                p.Cmnd = dt.Rows[i]["cmnd"].ToString();
                p.Quoctich = dt.Rows[i]["quoctich"].ToString();
                p.Ngaydangky = Convert.ToDateTime(dt.Rows[i]["ngaydangky"].ToString());
                p.Ngaynhan = Convert.ToDateTime(dt.Rows[i]["ngaynhan"].ToString());
                p.Ngaytra = Convert.ToDateTime(dt.Rows[i]["ngaytra"].ToString());
                p.Maphong = dt.Rows[i]["maphong"].ToString();
                p.Tinhtrang = dt.Rows[i]["tinhtrang"].ToString();
                dslp.Add(p);

            }
            return dslp;
        }
        public static List<KhachHang_DTO> TimKHTheoMaphong(string ten)
        {
            string sTruyVan = string.Format(@"select * from khachhang where maphong like '{0}'", ten);
            con = Dataprovider.MoKetNoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<KhachHang_DTO> dslp = new List<KhachHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhachHang_DTO p = new KhachHang_DTO();
                p.Makh = dt.Rows[i]["makh"].ToString();
                p.Tenkh = dt.Rows[i]["tenkh"].ToString();
                p.Ngaysinhkh = Convert.ToDateTime(dt.Rows[i]["ngaysinhkh"].ToString());
                p.Gioitinhkh = dt.Rows[i]["gioitinhkh"].ToString();
                p.Diachikh = dt.Rows[i]["diachikh"].ToString();
                p.Sdtkh = dt.Rows[i]["sdtkh"].ToString();
                p.Cmnd = dt.Rows[i]["cmnd"].ToString();
                p.Quoctich = dt.Rows[i]["quoctich"].ToString();
                p.Ngaydangky = Convert.ToDateTime(dt.Rows[i]["ngaydangky"].ToString());
                p.Ngaynhan = Convert.ToDateTime(dt.Rows[i]["ngaynhan"].ToString());
                p.Ngaytra = Convert.ToDateTime(dt.Rows[i]["ngaytra"].ToString());
                p.Maphong = dt.Rows[i]["maphong"].ToString();
                p.Tinhtrang = dt.Rows[i]["tinhtrang"].ToString();
                dslp.Add(p);

            }
            return dslp;
        }
    }
}
