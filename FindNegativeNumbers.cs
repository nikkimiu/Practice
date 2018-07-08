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
            int[] numbers = { 34, -1, 5, 24, -222, -90, 787 };
            int negative = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    negative = negative + 1;
                }
            }
            Console.WriteLine("The total of negative numbers is " + negative);
        }
    }
}
