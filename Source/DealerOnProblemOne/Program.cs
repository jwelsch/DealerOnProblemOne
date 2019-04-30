using System;
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
            Console.WriteLine("Welcome to NASA's Rover Operation Command Kinetic Interpreter (ROCKI).");

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

                var reader = new FileCommandSetReader(path);
                var dispatcher = new LocalCommandSetDispatcher();

                RunCommandSet(reader, dispatcher);
            }
        }

        private static void RunCommandSet(ICommandSetReader reader, ICommandSetDispatcher dispatcher)
        {
            var interpreter = new CommandSetInterpreter(reader, dispatcher);

            interpreter.Interpret();
        }
    }
}
