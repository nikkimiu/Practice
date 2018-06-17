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
            int longestNameLength = 0;
            string longestName = "";
            for (int i = 0; i < number; i = i + 1)
            {
                string name = Console.ReadLine();
                int length = name.Length;
                if (length > longestNameLength)
                {
                    longestNameLength = length;
                    longestName = name;
                }


            }
            Console.WriteLine("The longest name is " + longestName);

        }
    }
}

