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
            int[] numbers = new int[5];
            for(int a = 0; a < 5; a = a + 1)
            {
                String input=Console.ReadLine();
                numbers[a] = int.Parse(input);
            }

            for(int x = 0; x < 5; x = x + 1)
            {
                Console.Write(numbers[x]);
                if (x < 4)
                {
                    Console.Write(",");
                }
                
            }
            Console.WriteLine();
        }
    }
}

