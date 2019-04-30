﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerOnProblemOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to NASA's Rover Operation Command Interpreter (ROCI).");

            while (true)
            {
                Console.WriteLine();
                Console.Write("Please enter a path to a command file: ");
                var path = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(path))
                {
                    Console.WriteLine("The path cannot be empty.");
                    continue;
                }

                if (!File.Exists(path))
                {
                    Console.WriteLine($"The file does not exist at path {path}.");
                    continue;
                }


            }
        }
    }
}
