using System;

namespace DealerOnProblemOne
{
    /// <summary>
    /// Dispatches a command set locally.
    /// </summary>
    public class LocalCommandSetDispatcher : ICommandSetDispatcher
    {
        /// <summary>
        /// The rover guidance logic to use.
        /// </summary>
        private readonly IRoverGuidance guidance;

        /// <summary>
        /// Listener to use.
        /// </summary>
        private readonly ICommandSetListener listener;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="guidance">Rover guidance to use.</param>
        /// <param name="listener">Listener to use.</param>
        public LocalCommandSetDispatcher(IRoverGuidance guidance, ICommandSetListener listener)
        {
            this.guidance = guidance ?? throw new ArgumentNullException(nameof(guidance));
            this.listener = listener ?? throw new ArgumentNullException(nameof(listener));
        }

        /// <summary>
        /// Dispatches commands to be executed.
        /// </summary>
        /// <param name="commandSet">Command set to dispatch.</param>
        public void Dispatch(CommandSet commandSet)
        {
            if (commandSet == null)
            {
                throw new ArgumentNullException(nameof(commandSet));
            }

            this.guidance.Move(commandSet);

            this.listener?.Transmit($"{this.guidance.Coordinates.X} {this.guidance.Coordinates.Y} {InstructionHelper.ConvertHeadingToString(this.guidance.Heading)}");
        }
    }
}
