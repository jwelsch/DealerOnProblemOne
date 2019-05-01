using DealerOnProblemOne;
using System;
using System.Drawing;

namespace ApplicationTests.Mocks
{
    public class MockRoverGuidance : IRoverGuidance
    {
        private readonly Action<CommandSet> moveCheck;
        private readonly Func<Point, Point> changeCoordinates;
        private readonly Func<Heading, Heading> changeHeading;

        public MockRoverGuidance(Action<CommandSet> moveCheck = null, Func<Point, Point> changeCoordinates = null, Func<Heading, Heading> changeHeading = null)
        {
            this.moveCheck = moveCheck;
            this.changeCoordinates = changeCoordinates;
            this.changeHeading = changeHeading;
        }

        private Point coordinates;
        public Point Coordinates
        {
            get { return this.changeCoordinates == null ? this.coordinates : this.changeCoordinates.Invoke(this.coordinates); }
            set { this.coordinates = value; }
        }

        private Heading heading;
        public Heading Heading
        {
            get { return this.changeHeading == null ? this.heading : this.changeHeading.Invoke(this.heading); }
            set { this.heading = value; }
        }

        public void Move(CommandSet commandSet)
        {
            this.moveCheck?.Invoke(commandSet);
        }
    }
}
