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
            // enter a number first

            // inside the loop find if it is perfect square - 4, 25 etc.

            String a = Console.ReadLine();
            int number = int.Parse(a);
            bool perfect = false;
            for (int i = 0; true; i = i + 1)
            {
                int result = i * i;
                if (result == number)
                {
                    perfect = true;
                    break;
                }
                else if (result>number)
                {
                    break;
                }
            }
            if (perfect == true)
            {
                Console.WriteLine("It is a perfect square");
            }
            else
            {
                Console.WriteLine("It is not a perfect square");
            }

        }
    }
}

