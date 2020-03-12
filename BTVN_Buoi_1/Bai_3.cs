using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            Console.WriteLine("Cac uoc cua "+n+" la: ");
            while( i <= n)
            {
                if(n % i == 0)
                {
                    Console.WriteLine(i + "\t ");
                }
                i++;
            }
            Console.ReadKey();
        }
    }
}
