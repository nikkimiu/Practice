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
            double pi = 3.14;
            double radius = 0;
            string radiusNumber = Console.ReadLine();
            radius = double.Parse(radiusNumber);
            double diameter = 2 * radius;
            Console.WriteLine(diameter);
            double circumference = diameter * pi;
            Console.WriteLine(circumference);
            double area = pi * radius * radius;
            Console.WriteLine(area);
        }
    }
}
