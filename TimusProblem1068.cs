using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikki
{

    class Program
    {
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            int x = int.Parse(input);
            int sum = 0;
            if (x > 0)
            {
                for (int a = 0; a <= x; a = a + 1)
                {
                    sum = a + sum;
                }
                Console.WriteLine(sum);
            }

            else if (x < 0)
            {
                for (int b = 1; b >= x; b = b - 1)
                {
                    sum = b + sum;
                }
                Console.WriteLine(sum);
            }
            else if (x == 0)
            {
                Console.WriteLine(1);
            }

        }
    }
}

