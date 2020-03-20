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
            float a;
            int x, n, k;
            nhap(out a, out x, out n);
            tinh(x, out k);
            tinhS(x, n, k);
            Console.ReadKey();

        }

        static void nhap(out float a, out int x, out int n)
        {
            Console.WriteLine("Nhap a: ");
            a = float.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Nhap x: ");
                x = int.Parse(Console.ReadLine());
            } while (x <= 0);
            do
            {
                Console.WriteLine("Nhap n: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 5 || n > 20);
        }

        static void tinh(int x, out int k)
        {
            Console.WriteLine("Nhap k: ");
            k = int.Parse(Console.ReadLine());
            int t = 1;
            for(int i = 0; i < k; i++)
            {
                t *= x;
            }

            Console.WriteLine("can bac 2 x mu k = " + Math.Sqrt(t));
        }

        static void tinhS(int x, int n, float a)
        {
            double s = a;
            int ms = n;
            for(int i = 1; i <= n; i++)
            {
                s += (Math.Pow(-1, n) * Math.Sqrt(Math.Pow(x, i)))/ms;
                ms--;
            }
            Console.WriteLine("S = " + s);
        }
    }
}
