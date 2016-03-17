using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSim
{
    public class NorthAmericanAnimalFactory : IAnimalFactory
    {
        public Animal createAnimal(int animalCode)
        {
            Animal newAnimal = null;

            switch (animalCode)
            {
                case 0:
                    newAnimal = new Buffalo();
                    break;
                case 1:
                    newAnimal = new Bear();
                    break;
                case 2:
                    newAnimal = new Wolf();
                    break;
                case 3:
                    newAnimal = new Squirrel();
                    break;
                case 4:
                    newAnimal = new Eagle();
                    break;
            }
            return newAnimal;
        }
    }
}
