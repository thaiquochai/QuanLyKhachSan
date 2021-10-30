using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class TaiKhoan_DTO
    {
        string tentk;

        public string Tentk
        {
            get { return tentk; }
            set { tentk = value; }
        }
        string matkhau;

        public string Matkhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }
        int quyen;

        public int Quyen
        {
            get { return quyen; }
            set { quyen = value; }
        }

        
        string manv;

        public string Manv
        {
            get { return manv; }
            set { manv = value; }
        }
    }
}
