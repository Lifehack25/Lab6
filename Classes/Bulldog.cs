using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Classes
{
    internal class Bulldog(bool haveFur = true, bool isPredator = true, int amountOfLegs = 4, string foodConsumption = "Dogfood", string typeOfAnimal = "Dog", string breed = "Siberian Husky", int grumpylevel = 5)
        : Dog(haveFur, isPredator, amountOfLegs, foodConsumption, typeOfAnimal, breed)
    {
        public int GrumpyLevel = grumpylevel;

        public void Grumpy()
        {
            if (GrumpyLevel < 5)
            {
                Console.WriteLine("Bulldog is kinda grumpy");
            }
            else
            {
                Console.WriteLine("Bulldog is super grumpy, watch out");
            }
        }
    }
}
