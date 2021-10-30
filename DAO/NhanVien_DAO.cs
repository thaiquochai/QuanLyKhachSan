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
   public class NhanVien_DAO
    {
        static SqlConnection con;
        public static List<NhanVien_DTO> GetNhanVien()
        {
            string sTruyVan = "select * from nhanvien";
            con = Dataprovider.MoKetNoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhanVien_DTO> dslp = new List<NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO p = new NhanVien_DTO();
                p.Manv = dt.Rows[i]["manv"].ToString();
                p.Tennv = dt.Rows[i]["tennv"].ToString();
                p.Ngaysinhnv = Convert.ToDateTime(dt.Rows[i]["ngaysinhnv"].ToString());
                p.Gioitinhnv = dt.Rows[i]["gioitinhnv"].ToString();
                p.Diachinv = dt.Rows[i]["diachinv"].ToString();
                p.Sdtnv = dt.Rows[i]["sdtnv"].ToString();
                p.Email = dt.Rows[i]["email"].ToString();
                p.Chucvu = dt.Rows[i]["chucvu"].ToString();
                
                dslp.Add(p);

            }
            return dslp;
        }
        public static bool ThemNV(NhanVien_DTO p)
        {
            string sTruyVan = string.Format(@"insert into nhanvien values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}')",
             p.Manv, p.Tennv, p.Ngaysinhnv, p.Gioitinhnv, p.Diachinv, p.Sdtnv, p.Email, p.Chucvu );
            con = Dataprovider.MoKetNoi();
            bool kq = Dataprovider.TruyVanKhongLayDL(sTruyVan, con);
            Dataprovider.DongKetNoi(con);
            return kq;
        }
        public static bool SuaNV(NhanVien_DTO p)
        {
            string sTruyVan = string.Format(@"Update nhanvien set manv=N'{0}',tennv=N'{1}',ngaysinhnv=N'{2}',gioitinhnv=N'{3}',diachinv=N'{4}',sdtnv=N'{5}',email=N'{6}',chucvu=N'{7}'where manv=N'{8}'",
             p.Manv, p.Tennv, p.Ngaysinhnv, p.Gioitinhnv, p.Diachinv, p.Sdtnv, p.Email, p.Chucvu, p.Manv);
            con = Dataprovider.MoKetNoi();
            bool kq = Dataprovider.TruyVanKhongLayDL(sTruyVan, con);
            Dataprovider.DongKetNoi(con);
            return kq;
        }
        public static bool XoaNV(NhanVien_DTO p)
        {
            string sTruyVan = string.Format(@"Delete from nhanvien where manv=N'{0}'", p.Manv);
            con = Dataprovider.MoKetNoi();
            bool kq = Dataprovider.TruyVanKhongLayDL(sTruyVan, con);
            Dataprovider.DongKetNoi(con);
            return kq;
        }
        public static List<NhanVien_DTO> TimNVTheoTen(string ten)
        {
            string sTruyVan = string.Format(@"select * from nhanvien where manv like'%{0}%'", ten);
            con = Dataprovider.MoKetNoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhanVien_DTO> dslp = new List<NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO p = new NhanVien_DTO();
                p.Manv = dt.Rows[i]["manv"].ToString();
                p.Tennv = dt.Rows[i]["tennv"].ToString();
                p.Ngaysinhnv = Convert.ToDateTime(dt.Rows[i]["ngaysinhnv"].ToString());
                p.Gioitinhnv = dt.Rows[i]["gioitinhnv"].ToString();
                p.Diachinv = dt.Rows[i]["diachinv"].ToString();
                p.Sdtnv = dt.Rows[i]["sdtnv"].ToString();
                p.Email = dt.Rows[i]["email"].ToString();
                p.Chucvu = dt.Rows[i]["chucvu"].ToString();

                dslp.Add(p);

            }
            return dslp;
        }
    }
}
