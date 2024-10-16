using Lab6.Classes;

namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Skapar instanser av djuren
            Lion lion = new();
            Dog dog = new(true, false, 4, "Chicken & Rice", "Dog", "Chihuahua");
            SiberianHusky husky = new(true, false, 4, "Hotdogs", "Dog", "Siberian Husky", 10);
            Bulldog bulldog = new(true, false, 4, "Donuts", "Dog", "Bulldog", 7);
            Cat cat = new();

            // Skapar en array av djuren
            Animal[] animals = [lion, dog, husky, bulldog, cat];

            // Skapar delegater för att kunna anropa de specifika djurfunktionerna
            Delegate bulldogFunction = bulldog.Grumpy;
            Delegate huskyFunction = husky.Goofy;

            // Loopar igenom djuren och anropar deras funktioner
            foreach (var animal in animals)
            {
                animal.MakeSound();
                animal.Eat();
                animal.Sleep();

                if (animal is Bulldog || animal is SiberianHusky)
                {
                    Delegate playFunction = animal is Bulldog ? bulldogFunction : huskyFunction;
                    playFunction.DynamicInvoke();
                }
                Console.WriteLine();
            }

        }
    }
}
