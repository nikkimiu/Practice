using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikki
{

    class Program
    {

        static void Main(string[] args)
        {
            int x = 0;
            int a = 1;
            int b = 2;
            int c = 0;
            int sum = 0;
            Console.WriteLine(a);
            Console.WriteLine(b);
            while (a+b<4000000)
            {
                x = x + 1;
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
                int remainder = c % 2;
                if (remainder == 0)
                {
                    sum = c + sum;
                }
            }
            Console.WriteLine(sum+2);
        }
    }
}
