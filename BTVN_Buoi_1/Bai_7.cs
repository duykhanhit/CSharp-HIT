using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_7
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = float.Parse(Console.ReadLine());
            float e = 1, ss;
            int i = 1;
            ss = x;
            while (ss > 0.000001)
            {
                e += ss;
                i++;
                ss *= x / i;
            }
            Console.WriteLine(e);
            Console.ReadKey();
        }
    }
}
