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
            String s = Console.ReadLine();
            int number = int.Parse(s);
            int sum = 0;
            for(int i = 0; i < number; i=i+1)
            {
                string name = Console.ReadLine();
                int length = name.Length;
                sum = sum + length;
                
            }
            Console.WriteLine("The total characters are " + sum);
        }
    }
}

