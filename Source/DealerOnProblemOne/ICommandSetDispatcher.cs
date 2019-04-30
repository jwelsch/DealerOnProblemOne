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
        /// <param name="establishGrid">Command to establish the grid.</param>
        /// <param name="confirmPosition">Command to confirm position.</param>
        /// <param name="move">Command to move.</param>
        void Dispatch(ICommand establishGrid, ICommand confirmPosition, ICommand move);
    }
}