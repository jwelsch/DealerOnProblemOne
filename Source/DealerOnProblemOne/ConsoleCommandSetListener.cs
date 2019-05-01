using System;

namespace DealerOnProblemOne
{
    /// <summary>
    /// Listens for command set results and writes them to the console.
    /// </summary>
    public class ConsoleCommandSetListener : ICommandSetListener
    {
        /// <summary>
        /// Sends a message to the listener.
        /// </summary>
        /// <param name="message">Message to send.</param>
        public void Transmit(string message)
        {
            Console.WriteLine(message);
        }
    }
}
