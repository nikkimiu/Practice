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
            String line = Console.ReadLine(); // 56 67
            string[] numbers = line.Split(' ');
            int a = int.Parse(numbers[0]);
            int b = int.Parse(numbers[1]);
            Console.WriteLine(a + b);
        }
    }
}

