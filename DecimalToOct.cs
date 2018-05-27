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
            string number = Console.ReadLine();
            int num = int.Parse(number);
            string answer = "";
            while (num!=0)
            {
                int remainder = num % 8;
                num = num / 8;
                answer = answer + remainder;
            }
            answer = new string(answer.Reverse().ToArray());
            Console.WriteLine(answer);

        }
        
    }
}
