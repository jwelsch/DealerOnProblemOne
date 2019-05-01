namespace DealerOnProblemOne
{
    /// <summary>
    /// Factory interface to create ICommandSetDispatcher objects.
    /// </summary>
    public interface ICommandSetDispatcherFactory
    {
        /// <summary>
        /// Creates an ICommandSetDispatcher object.
        /// </summary>
        /// <returns>The created object.</returns>
        ICommandSetDispatcher Create();
    }
}
