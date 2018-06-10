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

            String word = Console.ReadLine();
            int wentToBreak = 0;

            for (int i = 0; i < word.Length; i = i + 1)
            {
                char first = word[i];
                char last = word[word.Length - 1 - i];
                if (first == last)
                {
                    continue;
                }
                else
                {
                    wentToBreak = 1;
                    break;
                }
            }

            if (wentToBreak == 0)
            {
                Console.WriteLine("It is a palindrome");
            }
            else
            {
                Console.WriteLine("It is not a palindrome");
            }
        }
    }
}
