using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    public class kiemKe
    {
        private String ngayKiemKe { get; set; }
        private String nvKiemKe { get; set; }
        private String chucVu { get; set; }
        public kiemKe()
        { 
        }

        public void nhap()
        {
            Console.WriteLine("Nhap ngay kiem ke(dd/mm/yyy):");
            this.ngayKiemKe = Console.ReadLine();
            Console.WriteLine("Nhap ten nhan vien kiem ke: ");
            this.nvKiemKe = Console.ReadLine();
            Console.WriteLine("Nhap chuc vu:");
            this.chucVu = Console.ReadLine();
        }

        public void xuat()
        {
            Console.WriteLine("Ngay kiem ke: " + ngayKiemKe);
            Console.WriteLine("Nhan vien kiem ke: " + nvKiemKe + "\t\t" + "Chuc vu: " + chucVu);
        }
    }
}
