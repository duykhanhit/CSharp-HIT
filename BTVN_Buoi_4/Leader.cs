using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySinhVien
{
    class Leader:SinhVien
    {
        private String position;

        public string Position { get => position; set => position = value; }

        public override void input()
        {
            base.input();
            Console.WriteLine("Nhap chuc vu cua leader: ");
            this.position = Console.ReadLine();
        }
        public override void output()
        {
            base.output();
            Console.WriteLine("\t"+this.position);
        }
        public void inputList(out Leader[] ld,out int n)
        {
            ld = new Leader[1000];
            Console.WriteLine("Nhap so luong leader: ");
            n = int.Parse(Console.ReadLine());
            ld = new Leader[n];
            Console.WriteLine("=====NHAP THONG TIN LEADER=====");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("======Nhap thong tin leader thu " + (i + 1) + "======");
                ld[i] = new Leader();
                ld[i].input();
            }
        }
        public void outputList(Leader[] ld,int n)
        {
            Console.WriteLine("=====THONG TIN LEADER=====");
            Console.WriteLine("Ten\t\tGioiTinh\tDiaChi\tNY?\tChucVu");
            for (int i = 0; i < n; i++)
            {
                ld[i].output();
            }
        }
    }
}
