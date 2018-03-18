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
            Console.WriteLine("Write one Number");
            int user = 0;
            String userNumber = Console.ReadLine();
            user = int.Parse(userNumber);
            int firstNumber = user / 10000;
            Console.WriteLine(firstNumber);
            int secondNumber = user / 1000 % 10;
            Console.WriteLine(secondNumber);
            int thirdNumber = user / 100 % 100 % 10;
            Console.WriteLine(thirdNumber);
            int fourthNumber = user % 100/10; 
            Console.WriteLine(fourthNumber);
            int lastNumber = user % 10;
            Console.WriteLine(lastNumber);




        }
    }
}
