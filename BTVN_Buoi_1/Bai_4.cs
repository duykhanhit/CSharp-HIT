using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap n:");
            int n = int.Parse(Console.ReadLine());

            int s1 = 0, s2 = 1, s3 = 0;

            for(int i = 1; i <= n; i++)
            {
                s1 += i;
                s2 *= i;
                if(i < n)
                {
                    s3 = s3 + i * (i + 1);
                }
            }
            Console.WriteLine("S1 = "+s1);
            Console.WriteLine("S2 = " + s2);
            Console.WriteLine("S3 = " + s3);

            Console.ReadKey();
        }
    }
}
