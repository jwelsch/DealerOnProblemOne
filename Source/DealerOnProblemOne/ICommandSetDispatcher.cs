namespace DealerOnProblemOne
{
    /// <summary>
    /// Interface for dispatching a command set.
    /// </summary>
    public interface ICommandSetDispatcher
    {
        /// <summary>
        /// Dispatches instructions to be executed.
        /// </summary>
        /// <param name="instructions">Instructions to be executed.</param>
        void Dispatch(string instructions);
    }
}