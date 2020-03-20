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
            int n;
            Student[] students = new Student[100];
            input(students, out n);
            Console.WriteLine("Ma SV" + "\t" + "Ten SV" + "\t\t\t" + "Ngay sinh");
            sortStudents(students, n);
            Console.ReadKey();
        }

        struct Date
        {
            public int day;
            public int month;
            public int year;
        };

        struct Student
        {
            public int id;
            public String name;
            public Date dateOfBirth;
        };

        static void input(Student[] students, out int n)
        {
            Console.Write("Nhap so sinh vien: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thong tin cac sinh vien");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Thong tin sinh vien thu " + (i + 1));
                Console.Write("Nhap ma sinh vien: ");
                students[i].id = int.Parse(Console.ReadLine());
                Console.Write("Nhap ten sinh vien: ");
                students[i].name = Console.ReadLine();
                Console.Write("Nhap ngay sinh: ");
                students[i].dateOfBirth.day = int.Parse(Console.ReadLine());
                Console.Write("Nhap thang sinh: ");
                students[i].dateOfBirth.month = int.Parse(Console.ReadLine());
                Console.Write("Nhap nam sinh: ");
                students[i].dateOfBirth.year = int.Parse(Console.ReadLine());
            }
        }

        static void showList(Student[] students, int n)
        {
            for (int i = 0; i < n; i++)
                Console.WriteLine(students[i].id + "\t" + students[i].name + "\t\t\t" + students[i].dateOfBirth.day + "/" + students[i].dateOfBirth.month + "/" + students[i].dateOfBirth.year);
        }

        static void sortStudents(Student[] students, int n)
        {
            for(int i = 0; i < n - 1; i++)
            {
                for(int j = 0; j < n - i - 1; j++)
                {
                    if(students[j].dateOfBirth.year > students[j + 1].dateOfBirth.year)
                    {
                        Student temp = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = temp;
                    }
                }
            }
            showList(students, n);
        }
    }
}
