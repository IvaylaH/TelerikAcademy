using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem3_AnimalHierarchy
{
    class Program
    {
        static void Main()
        {
            // testing if the program works correctly
            Kitten littlekitty = new Kitten(0, "Kitty");
            // Console.WriteLine(littlekitty.IsFemale);

            Tomcat tom = new Tomcat(3, "Tom");
            // Console.WriteLine(tom.IsFemale);

            Dog doggy = new Dog(3, "Sharo", "m");
            // Console.WriteLine(doggy.IsFemale);
            // Console.WriteLine(doggy);

            Frog frog = new Frog(0, "Frogchence", "m");
            // Console.WriteLine(frog);

            Kitten[] kittens = 
            { 
                new Kitten(0, "Daisy"),
                new Kitten(1, "Mita"),
                new Kitten(3, "Katq"),
                new Kitten(2, "Spaska"),
                new Kitten(0, "Snowflower")
            };

            Frog[] frogs = 
            {
                new Frog(40, "Kermit", "male"),
                new Frog(0, "Jabche", "f"),
                new Frog(17, "Jabka", "F")
            };

            Tomcat[] tomcats =
            {
                new Tomcat(70, "Tom"),
                new Tomcat(70, "Jerry"),
                new Tomcat(4, "Ben"),
                new Tomcat(3, "Ivancho"),
                new Tomcat(10, "Oti")
            };

            Dog[] dogs = 
            {
                new Dog(24, "Rita", "female"),
                new Dog(17, "Rex", "m"),
                new Dog(120, "Sharo", "M")
            };

            // declaration and initialization of [] of different animals
            Animal[] animals = 
            {
                new Dog(24, "Rita", "female"),
                new Tomcat(10, "Oti"),
                new Kitten(1, "Mita"),
                new Frog(0, "Jabche", "f")
            };

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Printing the elements of Dog[] dogs");

            PrintELements(dogs);

            Console.Write(Environment.NewLine);

            // calculating and printing the average value for each [] of animals we have initialized and declared
            decimal averageAge = CalculateAverageAge(tomcats);
            Console.WriteLine("The average age of the elements in 'Tomcat[] tomcats' is: {0:f2}", averageAge);

            averageAge = CalculateAverageAge(kittens);
            Console.WriteLine("The average age of the elements in 'Kitten[] kittens' is: {0:f2}", averageAge);

            averageAge = CalculateAverageAge(frogs);
            Console.WriteLine("The average age of the elements in 'Forg[] frogs' is: {0:f2}", averageAge);

            averageAge = CalculateAverageAge(dogs);
            Console.WriteLine("The average age of the elements in 'Dog[] dogs' is: {0:f2}", averageAge);

            averageAge = CalculateAverageAge(animals);
            Console.WriteLine("The average age of all the animals in 'Animal[] animals' is: {0:f2}", averageAge);

            Console.Write(Environment.NewLine);

            // testing the MakeSound() for each derived class of the Animal class
            littlekitty.MakeSound();
            doggy.MakeSound();
            tom.MakeSound();
            frog.MakeSound();

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("The animals in the 'Animal[] animals' make these sounds:");

            Console.Write(Environment.NewLine);
            Console.ResetColor();

            foreach (var animal in animals)
            {
                animal.MakeSound();
            }
        }

        // calculates the average age of the animals in the current [] using Sum() and lambda expressions
        public static decimal CalculateAverageAge(ICollection<Animal> animalArr) // how can I write this with Linq
        {
            var averageAge = animalArr.Sum<Animal>(animal => (decimal)animal.Age) / animalArr.Count;

            return averageAge;
        }

        // printing the elements of the current [] of animals
        public static void PrintELements(IEnumerable<Animal> animalArr)
        {
            Console.ResetColor();
            Console.Write(Environment.NewLine);

            foreach (var animal in animalArr)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
