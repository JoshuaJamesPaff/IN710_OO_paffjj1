using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolBots
{
    public class Ship
    {
        //conastants for ship size fuel and fuel usage
        private const int SIZE = 30;
        private const int FUEL = 100;
        private const int FUEL_USE = 5;

        //delegate for event and events for empty fuel and full fuel
        public delegate void EmptyFuelEventHandler(Object o, ShipEventArgs args);
        public event EmptyFuelEventHandler OnOutOfFuelEvent;
        public event EventHandler OnFullOfFuelEvent;

        //graphics and random properties
        private Graphics canvas;
        private SolidBrush brush;
        private Random rand;

        //so ship knows where harbour is
        private Rectangle harbour;

        //ships current state
        public EShipState State { get; set; }     
        private int currentFuel;
        private Point currentLocation;        
        private Size size;
        private int fuelUsage;

        public Ship(Graphics canvas, Rectangle harbour, Random rand)
        {
            this.rand = rand;
            this.canvas = canvas;
            this.harbour = harbour;

            brush = new SolidBrush(generateColour());
            currentLocation = new Point(rand.Next(0, harbour.Width - SIZE), rand.Next(0, harbour.Height - SIZE));
            State = EShipState.WANDERING;
            
            size = new Size(SIZE, SIZE);
            currentFuel = FUEL;
            fuelUsage = FUEL_USE;
        }

        public void Move()
        {
            if (State == EShipState.WANDERING)
                moveShip();
            else
                refuel();

            // Set the new colour of the ship
            brush.Color = generateColour();
        }

        public void Draw()
        {
            canvas.FillRectangle(brush, new Rectangle(currentLocation, size));
        }

        private void moveShip()
        {
            // Calculate the new location
            Point newLocation = new Point();
            newLocation.X = currentLocation.X + velocity.X;
            newLocation.Y = currentLocation.Y + velocity.Y;

            while (!(harbour.Contains(new Rectangle(newLocation, size))))
            {
                // Generate new velocity (direction)
                velocity.GenerateNewVelocity();

                // Set the new location to the location + the velocity
                newLocation.X = currentLocation.X + velocity.X;
                newLocation.Y = currentLocation.Y + velocity.Y;
            }

            // Set the location to the new location
            currentLocation = newLocation;

            useFuel();
        }

        private void useFuel()
        {
            // Use some fuel
            currentFuel -= fuelUsage;

            // Never have less than 0 fuel
            if (currentFuel < 0)
                currentFuel = 0;

            // Check we aren't out of fuel
            checkFuelLevel();
        }

        private void checkFuelLevel()
        {
            if (currentFuel == 0)
            {
                // Change our state
                State = EShipState.REFUELING;

                // Fire the Out Of Fuel event
                if (OnOutOfFuelEvent != null)
                    OnOutOfFuelEvent(this, new ShipEventArgs(currentLocation));
            }
        }

        private void refuel()
        {
            // Refill
            currentFuel += FUEL_REFILL_RATE;

            if (currentFuel >= FUEL)
            {
                // Make sure we don't have more than MAX_FUEL
                currentFuel = FUEL;

                // Change state
                State = EShipState.WANDERING;

                // Fire the Full Of Fuel event
                if (OnFullOfFuelEvent != null)
                    OnFullOfFuelEvent(this, new EventArgs());
            }
        }

        private Color generateColour()
        {
            double amountOfRed = (currentFuel / (double)FUEL) * 255;
            return Color.FromArgb((int)amountOfRed, 0, 0);
        }
    }
}
