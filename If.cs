﻿using System;
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
            int firstNumber = user / 10;
            Console.WriteLine(firstNumber);

            
        }
    }
}
