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
            int[] numbers = new int[101];
            int x = 0;
            for (int a = 0; a < 20; a = a + 1)
            {
                string input = Console.ReadLine();
                x = int.Parse(input);
                if (numbers[x] == 1)
                {
                    Console.WriteLine("It is duplicated.");
                }
                else
                {
                    numbers[x] = 1;
                }


            }
        }
    }
}
