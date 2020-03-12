using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nguyen: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 2; i <= n; i++)
            {
                while(n % i == 0)
                {
                    n /= i;
                    Console.Write(i + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
