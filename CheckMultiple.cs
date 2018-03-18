using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikki
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Write two numbers");
            int first = 0;
            int second = 0;
            String firstNumber = Console.ReadLine();
            first = int.Parse(firstNumber);
            String secondNumber = Console.ReadLine();
            second = int.Parse(secondNumber);
            int remainder = first % second;
            if (remainder == 0)
            {
                Console.WriteLine("The first number is a multiple of the second ");
            }
            if (remainder != 0)
            {
                Console.WriteLine("The first number is not a multiple of the second");
            }
      


        }
    }
}
