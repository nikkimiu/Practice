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
            Console.WriteLine("Write a number");
            string line = Console.ReadLine();
            int num = int.Parse(line);
            Int64 x = 1;
            while (num >1)
            {
                x = x * num;
                num = num - 1;
               
            }
            Console.WriteLine(x);


        }   
    }
}
