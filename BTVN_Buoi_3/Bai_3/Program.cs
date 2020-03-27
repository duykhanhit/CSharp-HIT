using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            phieu phieu = new phieu();
            phieu.nhap();
            kiemKe kiemKe = new kiemKe();
            kiemKe.nhap();
            phong phong = new phong();
            phong.nhap();
            Console.WriteLine("Nhap so luong tai san: ");
            int n = int.Parse(Console.ReadLine());
            taiSan[] taiSan = new taiSan[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin tai san thu " + (i + 1));
                taiSan[i] = new taiSan();
                taiSan[i].nhap();
            }

            phieu.xuat();
            kiemKe.xuat();
            phong.xuat();
            Console.WriteLine("Ten tai san \t\t So luong \t\t Tinh trang");
            foreach(taiSan item in taiSan)
            {
                item.xuat();
            }
        }
    }
}
