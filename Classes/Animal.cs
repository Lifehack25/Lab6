using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Classes
{
    internal abstract class Animal(bool haveFur, bool isPredator, int amountOfLegs, string foodCunsumption, string typeOfAnimal)
    {
        public bool HaveFur = haveFur;
        public bool IsPredator = isPredator;
        public int AmountOfLegs = amountOfLegs;
        public string FoodCunsumption = foodCunsumption;
        public string TypeOfAnimal = typeOfAnimal;
        public abstract void MakeSound();

        public abstract void Eat();

        public abstract void Sleep();
    }
}
