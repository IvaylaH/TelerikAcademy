/* Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintNumbersDivisibleBy7And3
{
    class PrintNumbersDivisibleBy7And3
    {
        static void Main()
        {
            int[] numbers = new int[] { 1, 15, 3, 6, 7, 21, 35, 9, 27, 42, 100, 121, 147, 90, 63, 18, 5, 0 };

            Console.WriteLine("Sollution using extension methods and lambda expressions: ");
            FindNumbersUsingExtMethodsAndLambdaExp(numbers);

            Console.Write(Environment.NewLine);

            Console.WriteLine("Solution using Linq");
            FindNumbersUsingLinq(numbers);
        }

        public static void FindNumbersUsingExtMethodsAndLambdaExp(int[] numbers)
        {
            // using 21 because this is the first number divisible by both 3 and 7, so all numbers divisible by 21 without remainder will be divisible by both 7 and 3 
            var foundNumbers = numbers.
                Where(num => num % 21 == 0 && num != 0);

            Console.WriteLine("All numbers divisible by both 7 and 3:");

            foreach (var number in foundNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            Console.WriteLine("All numbers divisible by 7");

            foundNumbers = numbers.
                Where(num => num % 7 == 0 && num != 0);

            foreach (var number in foundNumbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
            Console.WriteLine("All numbers divisible by 3:");

            foundNumbers = numbers.
                Where(num => num % 3 == 0 && num != 0);

            foreach (var number in foundNumbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }

        public static void FindNumbersUsingLinq(int[] numbers)
        {
            // using 21 because this is the first number divisible by both 3 and 7, so all numbers divisible by 21 without remainder will be divisible by both 7 and 3 
            Console.WriteLine("All numbers divisible by both 7 and 3:");

            var foundNumbers =
                from num in numbers
                where num % 21 == 0 && num != 0
                select num;

            foreach (var number in foundNumbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
            Console.WriteLine("All numbers divisible by 7");

            foundNumbers =
                from num in numbers
                where num % 7 == 0 && num != 0
                select num;

            foreach (var number in foundNumbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
            Console.WriteLine("All numbers divisible by 3:");

            foundNumbers =
                from num in numbers
                where num % 3 == 0 && num != 0
                select num;

            foreach (var number in foundNumbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }
    }
}
