using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// My First Program

namespace Nikki
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Write two Numbers");
            int first = 0;
            int second = 0;
            String firstNumber = Console.ReadLine();
            first = int.Parse(firstNumber);
            String secondNumber = Console.ReadLine();
            second = int.Parse(secondNumber);
            int third = 0;
            third = first + second;
            Console.WriteLine("The sum of " + firstNumber + " and " + secondNumber + " is " + third);
        }
    }
}
