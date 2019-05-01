using System;
using System.IO;

namespace DealerOnProblemOne
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                // No command line arguments given - prompt user for file to run.

                Console.WriteLine("Welcome to NASA's Rover Operation Command Kinetic Interpreter (ROCKI).");

                while (true)
                {
                    Console.WriteLine();
                    Console.Write("Please enter a path to a command file (Ctrl+C to quit): ");
                    var path = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(path))
                    {
                        Console.WriteLine("The path cannot be empty.");
                        continue;
                    }

                    RunFileCommandSet(path);
                }
            }
            else
            {
                // Run commands that are in the file path passed in on the command line.
                RunFileCommandSet(args[0]);
            }
        }

        /// <summary>
        /// Executes a command set from a file.
        /// </summary>
        /// <param name="path">Path to the file containing commands.</param>
        private static void RunFileCommandSet(string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine($"The file does not exist at path \"{path}\".");
                return;
            }
            
            var reader = new FileCommandSetReader(path);
            var dispatcherFactory = new LocalCommandSetDispatcherFactory();

            RunCommandSet(reader, dispatcherFactory);
        }

        /// <summary>
        /// Executes a command set.
        /// </summary>
        /// <param name="reader">Reads commands from where they are stored.</param>
        /// <param name="dispatcherFactory">Factory that creates a dispatcher to execute the commands.</param>
        private static void RunCommandSet(ICommandSetReader reader, ICommandSetDispatcherFactory dispatcherFactory)
        {
            var interpreter = new CommandSetInterpreter(reader, dispatcherFactory);

            interpreter.Interpret();
        }
    }
}
