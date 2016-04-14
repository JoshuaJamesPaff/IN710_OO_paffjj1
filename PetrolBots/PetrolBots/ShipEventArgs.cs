using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolBots
{
    //custom event args class has a xy point
    public class ShipEventArgs : EventArgs
    {
        //has a point for its xy location 
        private Point location;

        public Point Location
        {
            get { return location; }
            set { location = value; }
        }

        public ShipEventArgs(Point location)
            : base()
        {
            this.location = location;
        }
    }
}
