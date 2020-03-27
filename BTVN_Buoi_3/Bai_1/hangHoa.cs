using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bai_1
{
    public class hangHoa
    {
        private String maHang { get; set; }
        private String tenHang { get; set; }
        private int donGia { get; set; }
        private int soLuong { get; set; }


        public void nhap()
        {
            Console.WriteLine("Nhap ma hang: ");
            this.maHang = Console.ReadLine();
            Console.WriteLine("Nhap ten hang: ");
            this.tenHang = Console.ReadLine();
            Console.WriteLine("Nhap don gia: ");
            this.donGia = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so luong: ");
            this.soLuong = int.Parse(Console.ReadLine());
        }

        public void xuat()
        {
            Console.WriteLine(this.maHang + "\t" + this.tenHang + "\t\t" + this.donGia + "\t\t" + this.soLuong + "\t\t" + thanhTien());
        }

        public int thanhTien()
        {
            return this.soLuong * this.donGia;
        }
    }
}
