using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    public class phong
    {
        private String maPhong { get; set; }
        private String tenPhong { get; set; }
        private String truongPhong { get; set; }

        public phong()
        {
        }

        public void nhap()
        {
            Console.WriteLine("Nhap ma phong: ");
            maPhong = Console.ReadLine();
            Console.WriteLine("Nhap ten phong: ");
            tenPhong = Console.ReadLine();
            Console.WriteLine("Nhap truong phong: ");
            truongPhong = Console.ReadLine();
        }

        public void xuat()
        {
            Console.WriteLine("Kiem ke tai phong: " + tenPhong + "\t\t" + "Ma phong: " + maPhong);
            Console.WriteLine("Truong phong: " + truongPhong);
        }
    }
}
