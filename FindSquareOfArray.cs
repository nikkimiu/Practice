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
            //square of each number
            int[] numbers = { 34, -1, 5, 24, -222, -90, 7879 };
            
            for (int i = 0; i < numbers.Length; i++)
            {
                int a = numbers[i] * numbers[i];
                Console.WriteLine(a);
            }

        }
    }
}
