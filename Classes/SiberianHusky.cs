using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Classes
{
    internal class SiberianHusky(bool haveFur = true, bool isPredator = true, int amountOfLegs = 4, string foodConsumption = "Dogfood", string typeOfAnimal = "Dog", string breed = "Siberian Husky", int goofyLevel = 5)
        : Dog(haveFur, isPredator, amountOfLegs, foodConsumption, typeOfAnimal, breed)
    {
        int GoofyLevel = goofyLevel;

        public void Goofy()
        {
            if (GoofyLevel < 5)
            {
                Console.WriteLine("Husky is kinda goofy");
            }
            else
            {
                Console.WriteLine("Husky is very goofy! :)");
            }
        }
    }
}
