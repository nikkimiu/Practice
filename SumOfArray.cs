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
            //find the sum of the array
            int[] numbers = { 34, -1, 5, 24, 222, 90 };
            int sum = 0;
            for (int i = 0; i < numbers.Length; i = i + 1)
            {
                sum = numbers[i] + sum;
            }
            Console.WriteLine(sum);
        }
    }
}
