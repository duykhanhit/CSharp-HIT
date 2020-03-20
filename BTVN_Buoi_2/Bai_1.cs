using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] a = new int[100];
            Console.WriteLine("Nhap so nguyen n:");
            input(out n);
            inputArray(n, a);
            Console.WriteLine("Cac so nguyen to trong mang vua nhap:");
            show(n, a);
            Console.ReadKey();

        }

        static void input(out int n)
        {
            n = int.Parse(Console.ReadLine());
        }

        static void inputArray(int n,int[] a)
        {
            for(int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "] = ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        static int checkPrime(int x)
        {
            if(x < 2)
            {
                return 0;
            }
            for(int i = 2; i <= Math.Sqrt(x); i++)
            {
                if(x % i == 0)
                {
                    return 0;
                }
            }
            return 1;
        }

        static void show(int n, int[] a)
        {
            for(int i = 0; i < n; i++)
            {
                if(checkPrime(a[i]) == 1) {
                    Console.Write("a[" + i + "] = " + a[i] + "\t");
                }
            }
        }
    }
}
