namespace DealerOnProblemOne
{
    /// <summary>
    /// Interface for reading command sets.
    /// </summary>
    public interface ICommandSetReader
    {
        /// <summary>
        /// Reads the command set to a string.
        /// </summary>
        /// <returns>String containing a command set.</returns>
        string Read();
    }
}
