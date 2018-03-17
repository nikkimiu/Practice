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
            Console.WriteLine("Enter a Name ");
            String name = Console.ReadLine();
            if (name == "Andy" || name == "Sherry")
            {
                Console.WriteLine("Your age is 27");
            }
            if (name == "Cherry")
            {
                Console.WriteLine("Your age is 32");
            }
        }
    }
}
