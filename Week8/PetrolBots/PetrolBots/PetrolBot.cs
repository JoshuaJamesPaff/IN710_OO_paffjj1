using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolBots
{

    // class for petrol bot which is a colored eclipse that goes to ships to refuel them
    public class PetrolBot
    {
        private const int VERTICAL_DISTANCE_FROM_HARBOUR = 10;
        private const int DISTANCE_FROM_LEFT = 20;
        private const int BOT_SIZE = 20;

        // Properties
        private Graphics canvas;
        private Color colour;
        private Point currentLocation;
        private Point startLocation;
        private Ship shipSubject;
        private SolidBrush brush;
        private Size size;

        public PetrolBot(Graphics canvas, Color colour, Ship shipSubject, int botNumber, int harbourHeight)
        {
            this.canvas = canvas;
            this.colour = colour;
            brush = new SolidBrush(colour);
            size = new Size(BOT_SIZE, BOT_SIZE);
            startLocation = calculateStartLocation(botNumber, harbourHeight);
            currentLocation = startLocation;

            // Setup the subject
            this.shipSubject = shipSubject;
            shipSubject.OnOutOfFuelEvent += new Ship.EmptyFuelEventHandler(FillShip);
            shipSubject.OnFullOfFuelEvent += new EventHandler(FinishFillingShip);
        }

        private Point calculateStartLocation(int botNumber, int harbourHeight)
        {
            int distanceFromLeft = (DISTANCE_FROM_LEFT + BOT_SIZE) * botNumber;
            int distanceFromTop = harbourHeight + VERTICAL_DISTANCE_FROM_HARBOUR;

            return new Point(distanceFromLeft, distanceFromTop);
        }

        public void Draw()
        {
            Rectangle rectangle = new Rectangle(currentLocation, size);
            canvas.FillEllipse(brush, rectangle);
        }

        public void FillShip(object o, ShipEventArgs args)
        {
            currentLocation = args.Location;
        }

        public void FinishFillingShip(object o, EventArgs args)
        {
            currentLocation = startLocation;
        }
    }
}
