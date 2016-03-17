using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSim
{
    public class AfricanAnimalFactory : IAnimalFactory
    {
        public Animal createAnimal(int animalCode)
        {
            Animal newAnimal = null;

            switch (animalCode)
            {
                case 0:
                    newAnimal = new Gorilla();
                    break;
                case 1:
                    newAnimal = new Lion();
                    break;
                case 2:
                    newAnimal = new Elephant();
                    break;
                case 3:
                    newAnimal = new Hippo();
                    break;
                case 4:
                    newAnimal = new Hyena();
                    break;
            }
            return newAnimal;
        }
    }
}
