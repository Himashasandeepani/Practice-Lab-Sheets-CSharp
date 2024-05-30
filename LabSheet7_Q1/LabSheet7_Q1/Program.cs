using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet7_Q1
{
    // Abstract class - Animal
    public abstract class Animal
    {
        // Abstract method - MakeSound
        public abstract void MakeSound();
    }

    // Child class - Dog
    public class Dog : Animal
    {
        // Override method - MakeSound
        public override void MakeSound()
        {
            Console.WriteLine("Dog sound is: Baw Baw!");
        }
    }

    // Child class - Cat
    public class Cat : Animal
    {
        // Override method - MakeSound
        public override void MakeSound()
        {
            Console.WriteLine("Cat sound is: Miaw Miaw!");
        }
    }

    // Child class - Lion
    public class Lion : Animal
    {
        // Override method - MakeSound
        public override void MakeSound()
        {
            Console.WriteLine("Lion sound is: Grr Grr!");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // List of animals
            List<Animal> animals = new List<Animal>();

            // Get input
            Console.Write("Enter animal type: ");
            string animalType = Console.ReadLine();

            
            Animal animalSound = null;

            switch (animalType.ToLower())
            {
                case "dog":
                    animalSound = new Dog();
                    break;

                case "cat":
                    animalSound = new Cat();
                    break;

                case "lion":
                    animalSound = new Lion();
                    break;

                default:
                    Console.WriteLine("Unknown animal type.");
                    break;
            }

            //exception handle
            try
            {
                // validation
                if (animalSound != null)
                {
                    // Adding animal to list
                    animals.Add(animalSound);
                    Console.WriteLine("Animal added.");

                    // Display sound of added animal
                    Console.WriteLine("The sound of the added animal:");
                    foreach (var animal in animals)
                    {
                        animal.MakeSound();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
