using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldSim
{
    public partial class Form1 : Form
    {
        private Graphics canvas;
        private Random randGen;

        public Form1()
        {
            InitializeComponent();

            randGen = new Random();

            //sets canvas to panel and its inital color
            canvas = panelAnimalGraphics.CreateGraphics();
            canvas.Clear(Color.Green);
        }

        private void buttonAfrica_Click(object sender, EventArgs e)
        {
            listBoxAnimalOutput.Items.Clear();
            canvas.Clear(Color.LimeGreen);
            //creates and simulates africa
            Continent africa = new Africa(listBoxAnimalOutput, randGen, 4, canvas);
            africa.runSimulation();
        }

        private void buttonStraya_Click(object sender, EventArgs e)
        {
            listBoxAnimalOutput.Items.Clear();
            canvas.Clear(Color.SandyBrown);
            //creates and simulates straya
            Continent straya = new Australia(listBoxAnimalOutput, randGen, 4, canvas);
            straya.runSimulation();
        }

        private void buttonAmerica_Click(object sender, EventArgs e)
        {
            listBoxAnimalOutput.Items.Clear();
            canvas.Clear(Color.DarkGreen);
            //creates and simulates murica
            Continent murica = new NorthAmerica(listBoxAnimalOutput, randGen, 4, canvas);
            murica.runSimulation();
        }
    }
}
