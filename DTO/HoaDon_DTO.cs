using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class HoaDon_DTO
    {
        string mahd;

        public string Mahd
        {
            get { return mahd; }
            set { mahd = value; }
        }
        string makh;

        public string Makh
        {
            get { return makh; }
            set { makh = value; }
        }

        
        DateTime ngaylap;

        public DateTime Ngaylap
        {
            get { return ngaylap; }
            set { ngaylap = value; }
        }
        int songaytro;

        public int Songaytro
        {
            get { return songaytro; }
            set { songaytro = value; }
        }
        double tienphong;

        public double Tienphong
        {
            get { return tienphong; }
            set { tienphong = value; }
        }
        double thanhtien;

        public double Thanhtien
        {
            get { return thanhtien; }
            set { thanhtien = value; }
        }
        string maphong;

        public string Maphong
        {
            get { return maphong; }
            set { maphong = value; }
        }
       

    }
}
