namespace DealerOnProblemOne
{
    /// <summary>
    /// Interface for an individual command.
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Gets the raw instructions of the command.
        /// </summary>
        string Instructions
        {
            get;
        }
    }
}
