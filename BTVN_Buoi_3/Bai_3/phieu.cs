using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    public class phieu
    {
        private String maPhieu { get; set; }
        private kiemKe kiemKe { get; set; }
        private phong phong { get; set; }
        private int n { get; set; }
        private taiSan[] taiSan { get; set; }
        public phieu()
        {
        }

        public void nhap()
        {
            Console.WriteLine("Nhap ma phieu: ");
            maPhieu = Console.ReadLine();
        }

        public void xuat()
        {
            Console.Write("Ma phieu: " + maPhieu + "\t\t\t\t");
        }

    }
}
