using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CSDL_DAO
    {
        static SqlConnection con;
        // Backup
        public static bool SaoLuuDuLieu(string sDuongDan)
        {
            string sTen = "\\QuanLyKS(" + DateTime.Now.Day.ToString() + "_" +
                DateTime.Now.Month.ToString() + "_" +
                DateTime.Now.Year.ToString() + "_" +
                DateTime.Now.Hour.ToString() + "_" +
                DateTime.Now.Minute.ToString() + ").bak";
            string sql = "BACKUP DATABASE QuanLyKS TO DISK = N'" + sDuongDan + sTen + "'";
            con = Dataprovider.MoKetNoi();
            bool kq = Dataprovider.TruyVanKhongLayDL(sql, con);
            return kq;
        }
        public static bool PhucHoi(string strPath)
        {
            con = Dataprovider.MoKetNoi();
            strPath = strPath.Substring(0, strPath.Length - 2);
            string stRestore = "ALTER DATABASE QuanLyKS SET SINGLE_USER WITH ROLLBACK IMMEDIATE ";
            stRestore += " RESTORE DATABASE QuanLyKS FROM DISK = N'" + strPath + "'";
            stRestore += " WITH FILE = 1, NOUNLOAD, REPLACE, STATS = 10";
            stRestore += " ALTER DATABASE QuanLyKS SET MULTI_USER ";
            bool kq = Dataprovider.TruyVanKhongLayDL(stRestore, con);

           // con.Close();
            return kq;

        }
    }
}
