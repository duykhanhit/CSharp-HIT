using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bai_1;

namespace Bai_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Nhap so mat hang: ");
            int n = int.Parse(Console.ReadLine());
            hangHoa[] listHangHoa = new hangHoa[n];

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Thong tin mat hang thu " +(i+1));
                listHangHoa[i] = new hangHoa();
                listHangHoa[i].nhap();
            }
            sapXep(listHangHoa, n);
            Console.WriteLine("maHang\t tenHang\t donGia\t\t soLuong\t thanhTien");
            foreach(hangHoa item in listHangHoa)
            {
                item.xuat();
            }
            Console.ReadKey();
        }

        public static void sapXep(hangHoa[] listHangHoa, int n)
        {
            for(int i = 0; i < n - 1; i++)
            {
                for(int j = 0; j < n - i - 1; j++)
                {
                    if (listHangHoa[j].thanhTien() < listHangHoa[j + 1].thanhTien())
                    {
                        hangHoa temp = listHangHoa[j];
                        listHangHoa[j] = listHangHoa[j+1];
                        listHangHoa[j+1] = temp;
                    }
                }
            }
        }
    }
}
