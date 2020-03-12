using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so nguyen: ");
            int n = int.Parse(Console.ReadLine());
            bool flag = false;

            if(n < 2)
            {
                Console.WriteLine("Khong phai so nguyen to.");
            }
            else
            {
                for(int i = 2; i <= n/2; i++)
                {
                    flag = n % i == 0;
                    if (flag)
                    {
                        Console.WriteLine("Khong phai so nguyen to.");
                        break;
                    }
                }
                if (!flag)
                {
                    Console.WriteLine(n+ " la so nguyen to.");
                }
            }
            Console.ReadKey();
        }
    }
}
