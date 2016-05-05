using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetrolBots
{
    public partial class Form1 : Form
    {
        // Constants
        private const int NUMBER_OF_PETROL_BOTS = 5;
        private const int SHIP_SIZE = 30;
        private const int HARBOUR_WIDTH = 500;
        private const int HARBOUR_HEIGHT = 380;

        // Properties
        private List<Ship> ships;
        private List<PetrolBot> petrolBots;
        private Graphics canvas;
        private Random randomGenerator;
        private Color harbourBackgroundColour;
        private SolidBrush harbourBrush;


        public Form1()
        {
            InitializeComponent();

            canvas = CreateGraphics();
            randomGenerator = new Random();
            harbourBackgroundColour = Color.FromArgb(127, 127, 127); 
            harbourBrush = new SolidBrush(harbourBackgroundColour);
            ships = new List<Ship>();
            petrolBots = new List<PetrolBot>();

            // Create Ships and their Petrol Bots
            for (int i = 0; i < NUMBER_OF_PETROL_BOTS; i++)
            {
                Ship newShip = new Ship(canvas, new Rectangle(0, 0, HARBOUR_WIDTH, HARBOUR_HEIGHT), randomGenerator);
                PetrolBot newPretrolBot = new PetrolBot(canvas, generateRandomColour(), newShip, i, HARBOUR_HEIGHT);

                ships.Add(newShip);
                petrolBots.Add(newPretrolBot);
            }

            runTheSimulations();
        }

        private Color generateRandomColour()
        {
            return Color.FromArgb(randomGenerator.Next(100), randomGenerator.Next(100), randomGenerator.Next(100));
        }

        private void timerEngineTimer_Tick(object sender, EventArgs e)
        {
            runTheSimulations();

        }

        private void runTheSimulations()
        {
            canvas.Clear(Color.White);
            canvas.FillRectangle(harbourBrush, 0, 0, HARBOUR_WIDTH, HARBOUR_HEIGHT);

            foreach (Ship ship in ships)
            {
                ship.Move();
                ship.Draw();
            }

            foreach (PetrolBot petrolBot in petrolBots)
            {
                petrolBot.Draw();
            }
        }

        
    }
}
