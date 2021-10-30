using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO 
{
    public class Dataprovider
    {
        public static SqlConnection MoKetNoi()
        {
            string s = @"Data Source=DESKTOP-3SD5JI6\SQLEXPRESS;Initial Catalog=quanlikhachsan;Integrated Security=True";
            SqlConnection Kn = new SqlConnection(s);
            Kn.Open();
            return Kn;
        }
        public static DataTable TruyVanLayDuLieu(string sTruyVan, SqlConnection Kn)
        {
            SqlDataAdapter da = new SqlDataAdapter(sTruyVan, Kn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static bool TruyVanKhongLayDL(string sTruyVan, SqlConnection Kn)
        {
            try
            {
                SqlCommand cm = new SqlCommand(sTruyVan, Kn);
                cm.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool DongKetNoi(SqlConnection kn)
        {
            kn.Close();
            return true;
        }
    }
}
