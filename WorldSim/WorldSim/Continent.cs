using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldSim
{
    public abstract class Continent
    {
        //number of animals displayed at one time
        public const int ANIMAL_SIM_COUNT = 5;

        protected ListBox displayBox;
        protected Random randGen;
        protected int numAnimals;
        protected Graphics canvas;
        protected IAnimalFactory animalFactory;

        //constructor sets everything ecept for animal factory (defined in child classes)
        public Continent(ListBox displayBox, Random randGen, int numAnimals, Graphics canvas)
        {
            this.displayBox = displayBox;
            this.randGen = randGen;
            this.numAnimals = numAnimals;
            this.canvas = canvas;
        }

        public void runSimulation(){

            Animal currentAnimal;

            for (int i = 0; i < ANIMAL_SIM_COUNT; i++)
            {
                //gets a random animal from animal factory
                int randAnimal = randGen.Next(ANIMAL_SIM_COUNT);

                currentAnimal = animalFactory.createAnimal(randAnimal);

                //displays animal tostring
                displayBox.Items.Add(currentAnimal.ToString());

                //draws each animals picture 120 pixels below each other
                canvas.DrawImage(currentAnimal.Image, 20, 20 + (i * 150));
            }

        }
    }
}
