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
            int[] numbers = { 34, -1, 5, 24, 222, 90 };
            int a = 0;
            for (int i = 0; i < 6; i = i + 1)
            {
                if (numbers[i] % 2 == 0)
                {
                    a = a + 1;
                }
            }
            Console.WriteLine("the numbers of even number is " + a);
        }
    }
}
