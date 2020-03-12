using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2
{
    class Program
    {
        static void Main(string[] args)    
        {
            float a, b, c;
            do
            {
                Console.WriteLine("Nhap canh thu nhat: ");
                a = float.Parse(Console.ReadLine());
            } while (a <= 0);
            do
            {
                Console.WriteLine("Nhap canh thu hai: ");
                b = float.Parse(Console.ReadLine());
            } while (b <= 0);
            do
            {
                Console.WriteLine("Nhap canh thu ba: ");
                c = float.Parse(Console.ReadLine());
            } while (c <= 0);

            if(a + b < c || a + c < b || c + b < a)
            {
                Console.WriteLine("Khong phai la do dai 3 canh tam giac.");
            }
            else
            {
                if(a == b && a == c)
                {
                    Console.WriteLine("Tam giac deu");
                }
                if(a == b || c == b || c == a)
                {
                    Console.WriteLine("Tam giac can");
                }
                if( a*a == b*b + c*c || b * b == a * a + c * c || c * c == b * b + a * a)
                {
                    Console.WriteLine("Tam giac vuong");
                }
                else
                {
                    Console.WriteLine("Tam giac thuong");
                }
            }

            Console.ReadKey();
        }
    }
}
