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
            Console.WriteLine("Enter 2 numbers");
            String firstNumber = Console.ReadLine();
            int first = int.Parse(firstNumber);
            String secondNumber = Console.ReadLine();
            int second = int.Parse(secondNumber);
            int sum = first + second;
            Console.WriteLine(sum);
            int difference = first - second;
            Console.WriteLine(difference);
            int product = first * second;
            Console.WriteLine(product);
            int divide = first / second;
            Console.WriteLine(divide);


        }
    }
}
