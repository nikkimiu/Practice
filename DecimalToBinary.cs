using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// project euler problem 1
    /// https://projecteuler.net/problem=1
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            String number = Console.ReadLine();
            int num = int.Parse(number);
            string answer = "";
            while (num != 0)
            {
                int remainder = num % 2;
                num = num / 2;
                answer = answer + remainder;
            }
            answer = new string(answer.Reverse().ToArray());
            Console.WriteLine(answer);            
        }
        
    }
}
