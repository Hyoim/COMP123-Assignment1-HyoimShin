﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string consoleKey = "";

            Hero superman = new Hero("Superman");
            // Console.WriteLine("Superman");
            superman.show();


            while (consoleKey != "q")
            {
                switch (consoleKey)
                {
                    case "q":
                        break;
                    case "y":
                        superman.fight();
                        consoleKey = "";
                        break;
                    default:
                        consoleKey = checkKey(consoleKey);
                        break;
                }

            }

        }
        private static string checkKey(string consoleKey)
        {
            Console.Write("Press 'y' to attack the target or 'q' to exit : ");
            consoleKey = Console.ReadLine();
            Console.WriteLine();
            return consoleKey;
        }
    }
}