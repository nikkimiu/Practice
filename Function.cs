using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   
    class Program
    {     
        static void PrintCharacter(int side, string s)
        {
            for (int x = 0; x < side; x = x + 1)
            {
                for (int y = 0; y < side; y = y + 1)
                {
                    Console.Write(s);
                }
                Console.WriteLine("");
            }
        }
        static void Main(string[] args)
        {
            String s = Console.ReadLine();
            int t = int.Parse(s);

            string character = Console.ReadLine();

            PrintCharacter(t,character);
        }
    }
}
