using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2
{
    public class ptBac2
    {
        private float a { get; set; }
        private float b { get; set; }
        private float c { get; set; }

        public ptBac2(float a, float b, float c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public ptBac2() { }

        public void xuat()
        {
            Console.Write(a + "x^2 ");
            if(b < 0)
            {
                Console.Write(b + "x ");
                if(c < 0)
                {
                    Console.WriteLine(c + " = 0");
                }
                else
                {
                    Console.WriteLine("+" + c + " = 0");
                }
            }
            else
            {
                Console.Write("+" + b + "x ");
                if (c < 0)
                {
                    Console.WriteLine(c + " = 0");
                }
                else
                {
                    Console.WriteLine("+" + c + " = 0");
                }
            }
        }

        public static ptBac2 operator--(ptBac2 pt)
        {
            ptBac2 pt2 = new ptBac2();
            pt2.a = -1 * pt.a;
            pt2.b = -1 * pt.b;
            pt2.c = -1 * pt.c;
            return pt2;
        }

        public static ptBac2 operator+(ptBac2 pt1, ptBac2 pt2)
        {
            ptBac2 ptTong = new ptBac2();
            ptTong.a = pt1.a + pt2.a;
            ptTong.b = pt1.b + pt2.b;
            ptTong.c = pt1.c + pt2.c;
            return ptTong;
        }

        public static ptBac2 operator -(ptBac2 pt1, ptBac2 pt2)
        {
            ptBac2 ptTong = new ptBac2();
            ptTong.a = pt1.a - pt2.a;
            ptTong.b = pt1.b - pt2.b;
            ptTong.c = pt1.c - pt2.c;
            return ptTong;
        }
    }
}
