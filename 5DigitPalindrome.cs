using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            string line = Console.ReadLine();
            int num = int.Parse(line);
            int first = num / 10000;
            int last = num % 10;
            if (first == last)
            {
                int second = num / 1000 % 10;
                int fourth = num / 10 % 10;
                if (second == fourth)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }

            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
