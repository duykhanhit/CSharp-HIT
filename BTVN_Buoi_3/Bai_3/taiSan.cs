using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    public class taiSan
    {
        private String tenTaiSan { get; set; }
        private int soLuong { get; set; }
        private String tinhTrang { get; set; }

        public taiSan()
        {
        }

        public void nhap()
        {
            Console.WriteLine("Nhap ten tai san: ");
            tenTaiSan = Console.ReadLine();
            Console.WriteLine("Nhap so luong: ");
            soLuong = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap tinh trang: ");
            tinhTrang = Console.ReadLine();
        }

        public void xuat()
        {
            Console.WriteLine(tenTaiSan + "\t\t\t" + soLuong + "\t\t\t" + tinhTrang);
        }
    }
}
