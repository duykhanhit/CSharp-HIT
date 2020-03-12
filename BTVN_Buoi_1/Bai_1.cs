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
            Console.WriteLine("Nhap 5 so:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());

            int max = a;
            if (max < b) max = b;
            if (max < c) max = c;
            if (max < d) max = d;
            if (max < e) max = e;

            int max2 = a;
            if (max > b && max2 < b) max2 = b;
            if (max > c && max2 < c) max2 = c;
            if (max > d && max2 < d) max2 = d;
            if (max > e && max2 < e) max = e;

            Console.WriteLine("Gia tri lon thu 2 la: " + max2);
            Console.ReadKey();
        }
    }
}
