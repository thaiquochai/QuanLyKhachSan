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
   public class TaiKhoan_DAO
    {
       static SqlConnection con;
       public static List< TaiKhoan_DTO> DSTaiKhoan()
       {
           string sTruyVan = "select * from taikhoan";
           con = Dataprovider.MoKetNoi();
           DataTable dt = Dataprovider.TruyVanLayDuLieu(sTruyVan, con);
           if (dt.Rows.Count == 0)
           {
               return null;
           }
           List<TaiKhoan_DTO> dslp = new List<TaiKhoan_DTO>();
           for (int i = 0; i < dt.Rows.Count; i++)
           {
               TaiKhoan_DTO p = new TaiKhoan_DTO();
               p.Tentk = dt.Rows[i]["tentk"].ToString();
               p.Matkhau = dt.Rows[i]["matkhau"].ToString();
               p.Quyen = int.Parse(dt.Rows[i]["quyen"].ToString());
               p.Manv = dt.Rows[i]["manv"].ToString();
               dslp.Add(p);

           }
           return dslp;
       }
       public static TaiKhoan_DTO GetAccount(string User, string Pass)
       {
           string sTruyVan = string.Format(@"select * from taikhoan where tentk='{0}' and matkhau='{1}'", User, Pass);
           con = Dataprovider.MoKetNoi();
           DataTable dt = Dataprovider.TruyVanLayDuLieu(sTruyVan, con);
           
           TaiKhoan_DTO acc = new TaiKhoan_DTO();
           if (dt.Rows.Count > 0)
           {
               acc.Tentk = dt.Rows[0]["tentk"].ToString();
               acc.Matkhau = dt.Rows[0]["matkhau"].ToString();
               acc.Quyen = int.Parse(dt.Rows[0]["quyen"].ToString());
               acc.Manv = dt.Rows[0]["manv"].ToString();
           }
           Dataprovider.DongKetNoi(con);
           return acc;
       }
       public static TaiKhoan_DTO GetPassByUser(string User)
       {
           string sTruyVan = string.Format(@"select * from taikhoan where tentk='{0}'", User);
           con = Dataprovider.MoKetNoi();
           DataTable dt = Dataprovider.TruyVanLayDuLieu(sTruyVan, con);

           TaiKhoan_DTO acc = new TaiKhoan_DTO();
           if (dt.Rows.Count > 0)
           {
               acc.Tentk = dt.Rows[0]["tentk"].ToString();
               acc.Matkhau = dt.Rows[0]["matkhau"].ToString();
               acc.Quyen = int.Parse(dt.Rows[0]["quyen"].ToString());
               acc.Manv = dt.Rows[0]["manv"].ToString();
           }
           Dataprovider.DongKetNoi(con);
           return acc;
       }
       public static bool ThemTK(TaiKhoan_DTO p)
       {
           string sTruyVan = string.Format(@"insert into taikhoan values(N'{0}',N'{1}',N'{2}',N'{3}')", p.Tentk, p.Matkhau, p.Quyen,p.Manv);
           con = Dataprovider.MoKetNoi();
           bool kq = Dataprovider.TruyVanKhongLayDL(sTruyVan, con);
           Dataprovider.DongKetNoi(con);
           return kq;
       }
       public static bool SuaTK(TaiKhoan_DTO p)
       {
           string sTruyVan = string.Format(@"Update taikhoan set tentk=N'{0}',matkhau=N'{1}',quyen=N'{2}',manv=N'{3}'where tentk=N'{4}'", p.Tentk, p.Matkhau, p.Quyen, p.Manv,p.Tentk);
           con = Dataprovider.MoKetNoi();
           bool kq = Dataprovider.TruyVanKhongLayDL(sTruyVan, con);
           Dataprovider.DongKetNoi(con);
           return kq;
       }
       public static bool SuaPass(TaiKhoan_DTO p)
       {
           string sTruyVan = string.Format(@"Update taikhoan set matkhau=N'{0}'where tentk=N'{1}'", p.Matkhau, p.Tentk);
           con = Dataprovider.MoKetNoi();
           bool kq = Dataprovider.TruyVanKhongLayDL(sTruyVan, con);
           Dataprovider.DongKetNoi(con);
           return kq;
       }
       public static bool XoaTK(TaiKhoan_DTO p)
       {
           string sTruyVan = string.Format(@"Delete from taikhoan where tentk=N'{0}'", p.Tentk);
           con = Dataprovider.MoKetNoi();
           bool kq = Dataprovider.TruyVanKhongLayDL(sTruyVan, con);
           Dataprovider.DongKetNoi(con);
           return kq;
       }
       public static List<TaiKhoan_DTO> TimKTheoTen(string ten)
       {
           string sTruyVan = string.Format(@"select * from taikhoan where tentk like'%{0}%'", ten);
           con = Dataprovider.MoKetNoi();
           DataTable dt = Dataprovider.TruyVanLayDuLieu(sTruyVan, con);
           if (dt.Rows.Count == 0)
           {
               return null;
           }
           List<TaiKhoan_DTO> dslp = new List<TaiKhoan_DTO>();
           for (int i = 0; i < dt.Rows.Count; i++)
           {
               TaiKhoan_DTO p = new TaiKhoan_DTO();
               p.Tentk = dt.Rows[i]["tentk"].ToString();
               p.Matkhau = dt.Rows[i]["matkhau"].ToString();
               p.Quyen = int.Parse(dt.Rows[i]["quyen"].ToString());
               p.Manv = dt.Rows[i]["manv"].ToString();
               dslp.Add(p);

           }
           return dslp;
       }
    }
}
