/*Write a program that reads 3 integer numbers from the console and prints their sum.*/

using System;

    class ReadThreeIntegers
    {
        static void Main()
        {
            Console.Write("This program reads 3 integer numbers from the console.\nPlease enter the first number: ");
            int firstInt = int.Parse(Console.ReadLine());
            Console.Write("Please enter the second number: ");
            int secondInt = int.Parse(Console.ReadLine());
            Console.Write("Please enter the third number: ");
            int thirdInt = int.Parse(Console.ReadLine());
            int sum = firstInt + secondInt + thirdInt;

            Console.WriteLine("Sum: {0} + {1} + {2} = {3}.", firstInt, secondInt, thirdInt, sum);
        }
    }
