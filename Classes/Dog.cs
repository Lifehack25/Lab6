using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Classes
{
    internal class Dog(bool haveFur = true, bool isPredator = true, int amountOfLegs = 4, string foodConsumption = "Dogfood", string typeOfAnimal = "Dog", string breed = "Siberian Husky")
        : Animal(haveFur, isPredator, amountOfLegs, foodConsumption, typeOfAnimal)
    {
        public string Breed = breed;
        public override void MakeSound()
        {
            Console.WriteLine("Woff!");
        }
        public override void Eat()
        {
            Console.WriteLine("The dog is eating");
        }
        public override void Sleep()
        {
            Console.WriteLine("The dog is sleeping");
        }
        public void Fetch()
        {
            Console.WriteLine("The dog is fetching");
        }
    }
}
