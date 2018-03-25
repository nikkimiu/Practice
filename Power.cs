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
            string a = Console.ReadLine();
            double x = double.Parse(a);
            string b = Console.ReadLine();
            double y = double.Parse(b);
            int i = 0;
            double store = x * 1;
            while (i < y - 1)
            {
                store = x * store;
                i = i + 1;
            }
            Console.WriteLine(store);
        }
    }
}
