using System;
using System.Collections.Generic;

namespace Aslan
{
    class Program
    {
        public static List<Animal> AnimalList = new List<Animal>();
        private static readonly Random getrandom = new Random();

        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Hello");
                Console.WriteLine("1: Add animal");
                Console.WriteLine("2: See animal list");
                String tempStrAns = Console.ReadLine();

                // if user wants to see the animal list
                switch (tempStrAns)
                {
                    case "1":
                        AddAnimal();
                        break;
                    case "2":
                        foreach (var animal in AnimalList)
                        {
                            animal.Show();
                        }
                        Console.ReadLine();
                        break;
                }
            }


        }

        public static void AddAnimal()
        {
            Console.WriteLine("name of animal");
            string animalName = Console.ReadLine();
            Console.WriteLine("what animal type is it? Dog, Cat or Bird ");
            string animalType = Console.ReadLine();
            Animal animal = new Animal();

            if (animalType == "dog" && animalType == "Dog")
            {
                AnimalList.Add(new Dog(animalName));
            }
            else if (animalType == "cat" && animalType == "Cat")
            {
                AnimalList.Add(new Cat(animalName));
            }
            else if (animalType == "bird" && animalType == "Bird")
            {
                AnimalList.Add(new Dog(animalName));
            }


        }
    }

}
