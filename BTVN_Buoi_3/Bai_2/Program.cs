using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ptBac2 a = new ptBac2(-1, 2, -3);
            ptBac2 b = new ptBac2(4, -5, 6);
            Console.Write("Phuong trinh 1 co dang: ");
            a.xuat();
            Console.Write("Phuong trinh 2 co dang: ");
            b.xuat();
            ptBac2 tong = a + b;
            ptBac2 hieu = a - b;
            a--;
            b--;
            Console.Write("Phuong trinh 1 dao nguoc co dang: ");
            a.xuat();
            Console.Write("Phuong trinh 2 dao nguoc co dang: ");
            b.xuat();
            Console.Write("Phuong trinh tong co dang: ");
            tong.xuat();
            Console.Write("Phuong trinh hieu co dang: ");
            hieu.xuat();

            Console.ReadKey();
        }
    }
}
