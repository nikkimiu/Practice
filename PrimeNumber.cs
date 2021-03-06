using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikki
{

    class Program
    {
        static bool Prime(int num)
        {
            if (num == 0 || num == 1)
            {
                return false;
            }
            int b = (int)Math.Sqrt(num);
            int remainder = -1;
            for (int x = 2; x < b + 1; x = x + 1)
            {
                remainder = num % x;
                if (remainder == 0)
                {
                    return false;
                }
            }

            return true;

        }

        static void Main(string[] args)
        {
            String b = Console.ReadLine();
            int c = int.Parse(b);
            bool result = Prime(c);
            if (result == true)
            {
                Console.WriteLine("It is prime number.");
            }
            else
            {
                Console.WriteLine("It is not a prime number");
            }
        }
    }
}
