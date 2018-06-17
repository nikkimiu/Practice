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
            string line = Console.ReadLine();
            string[] numbers = line.Split(' ');
            int N = int.Parse(numbers[0]);
            int A = int.Parse(numbers[1]);
            int B = int.Parse(numbers[2]);
            Console.WriteLine(N * A * B * 2);
        }
    }
}

