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
            int[] numbers = {0, 7, 6, 45, 4, 21, -1 };
            
            int x = numbers[0];
            int y = 0;
            for (int i = 0; i < numbers.Length; i = i + 1)
            {
                
                if (numbers[i] > x)
                {
                    x = numbers[i];
                    y = i;
                }
                
            }
            Console.WriteLine("The biggest number is " + "number " + y);
        }
    }
}
