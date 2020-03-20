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
            String str;
            String[] s;
            inputString(out str);
            cut(str, out s);
            show(s);
            Console.ReadKey();
        }

        static void inputString(out String str)
        {
            Console.Write("Nhap chuoi: ");
            str = Console.ReadLine();
        }

        static void cut(String str, out String[] s)
        {
            s = str.Split(new char[]{' '});
        }

        static void show(String[] s)
        {
            Console.WriteLine("Ho: "+s[0]);
            Console.WriteLine("Ten dem: " + s[1]);
            Console.WriteLine("Ten: " + s[2]);
            Console.WriteLine("Nam sinh: " + s[3]);
        }
    }
}
