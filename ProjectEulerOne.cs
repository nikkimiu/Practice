using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// project euler problem 1
    /// https://projecteuler.net/problem=1
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int sum = 0;
            while (x < 1000)
            {               
                if (x % 3 == 0||x % 5==0)
                {
                    sum = x+sum;
                }
                x = x + 1;
            }
            Console.WriteLine(sum);

        }
    }
}
