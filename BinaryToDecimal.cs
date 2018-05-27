using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   
    class Program
    {
        static void Main(string[] args)
        {
            String binary = Console.ReadLine();
            int answer = 0;
            for (int x = 0; x < binary.Length; x = x + 1)
            {
                int digit = binary[x] - 48; // '1' or '0'
                int power = binary.Length - 1 - x;
                int result = (int)Math.Pow(2, power);
                 answer = answer+digit * result;
            }
            Console.WriteLine(answer);
        }
    }
}
