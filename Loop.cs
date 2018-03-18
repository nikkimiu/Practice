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
            Console.WriteLine("N 10*N 100*N 1000*N");
            int x = 0;
            while (x < 5)
            {
                x = x + 1;
                Console.WriteLine(x + "  " + x * 10 + "  " + x * Math.Pow(10, 2) + "  " + x * Math.Pow(10, 3));
            }
        }
    }
}
