using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiPhong_DTO
    {
        string maLphong;

        public string MaLphong
        {
            get { return maLphong; }
            set { maLphong = value; }
        }
        string tenLphong;

        public string TenLphong
        {
            get { return tenLphong; }
            set { tenLphong = value; }
        }
        double dongia;

        public double Dongia
        {
            get { return dongia; }
            set { dongia = value; }
        }
    }
}
