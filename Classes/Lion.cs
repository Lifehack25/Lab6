using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Classes
{
    internal class Lion(bool haveFur = true, bool isPredator = true, int amountOfLegs = 4, string foodConsumption = "Meat", string typeOfAnimal = "Lion", string sizeOfMane = "Big") 
        : Animal(haveFur, isPredator, amountOfLegs, foodConsumption, typeOfAnimal)
    {
        public string SizeOfMane = sizeOfMane;
        public override void MakeSound()
        {
            Console.WriteLine("Roar");
        }
        public override void Eat()
        {
            Console.WriteLine("The lion is eating");
        }
        public override void Sleep()
        {
            Console.WriteLine("The lion is sleeping");
        }
        public void Hunt()
        {
            Console.WriteLine("The lion is hunting");
        }
    }
}
