namespace DealerOnProblemOne
{
    /// <summary>
    /// Interface for dispatching a command set.
    /// </summary>
    public interface ICommandSetDispatcher
    {
        /// <summary>
        /// Dispatches commands to be executed.
        /// </summary>
        /// <param name="commandSet">Command set to dispatch.</param>
        void Dispatch(CommandSet commandSet);
    }
}