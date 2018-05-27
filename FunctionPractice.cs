using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   
    class Program
    {
        //static void PrintCharacter(int side, string s)
        //{
        //    for (int x = 0; x < side; x = x + 1)
        //    {
        //        for (int y = 0; y < side; y = y + 1)
        //        {
        //            Console.Write(s);
        //        }
        //        Console.WriteLine("");
        //    }
        //}

        static void Miao()
        {
            Console.WriteLine("Cow");
        }

        static void Miao2(String a)
        {
            Console.WriteLine(a);
        }

        static void Miao3(string a,string b)
        {
            Console.WriteLine(a + " " + b);
        }

        static void Add(int c, int d)
        {
            Console.WriteLine(c+d);
        }

        static int Add2(int c, int d)
        {
            return c + d;
        }

        static double Hypotenuse(double a, double b)
        {
            Double first =Math.Pow(a,2) + Math.Pow(b,2);
            return Math.Sqrt(first);
            
        }
        static bool Triangle(int a, int b, int c)
        {
            if (a + b > c)
            {
                if (b + c> a)
                {
                    if (a+c > b)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        static bool Triangle2(int a, int b, int c)
        {
            if (a + b <= c)
            {
                return false;
            }
            if (b+c<= a)
            {
                return false;
            }
            if (a + c <= b)
            {
                return false;
            }

            return true;
        }

        static void Circle(double r)
        {
            double circumference = 2 * Math.PI * r;
            Console.WriteLine(circumference);
            double area = Math.PI * r * r;
            Console.WriteLine(area);
        }

        static void Main(string[] args)
        {
            Miao();
            Miao2("Nikki");
            Miao3("Nikki","Shao");
            Add(4, 6);
            int answer = Add2(25, 50);
            Console.WriteLine(answer);
            double result = Hypotenuse(3, 4);
            Console.WriteLine(result);

            bool result2=Triangle(3,4,5);
            Console.WriteLine(result2);
            bool result3 = Triangle2(1, 2, 1);
            Console.WriteLine(result3);
            Circle(3);
            
        }
        
    }
}
