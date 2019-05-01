namespace DealerOnProblemOne
{
    /// <summary>
    /// Factory interface to create ICommandSetDispatcher objects.
    /// </summary>
    public class LocalCommandSetDispatcherFactory : ICommandSetDispatcherFactory
    {
        /// <summary>
        /// Creates an ICommandSetDispatcher object.
        /// </summary>
        /// <returns>The created object.</returns>
        public ICommandSetDispatcher Create()
        {
            return new LocalCommandSetDispatcher(new LocalRoverGuidance(), new ConsoleCommandSetListener());
        }
    }
}
