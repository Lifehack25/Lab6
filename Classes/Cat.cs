using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Classes
{
    internal class Cat(bool haveFur = true, bool isPredator = true, int amountOfLegs = 4, string foodConsumption = "Meat", string typeOfAnimal = "Cat", string furColor = "Black")
        : Animal(haveFur, isPredator, amountOfLegs, foodConsumption, typeOfAnimal)
    {
        public string FurColor = furColor;
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
        public override void Eat()
        {
            Console.WriteLine("The kitty is eating");
        }
        public override void Sleep()
        {
            Console.WriteLine("The kitty is sleeping");
        }
        public void Purr()
        {
            Console.WriteLine("The kitty is purring");
        }
    }
}
