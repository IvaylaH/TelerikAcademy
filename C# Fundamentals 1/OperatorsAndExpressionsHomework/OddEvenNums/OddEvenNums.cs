/*Write an expression that checks if given integer is odd or even.*/

using System;

    class OddEvenNums
    {
        static void Main()
        {
            Console.WriteLine("Please enter a Number");
            int number = int.Parse(Console.ReadLine());
            int result = number % 2;

            Console.WriteLine(result == 0 ? "The number {0} is even!" : "The number {0} is odd!", number);

            // Second solution using bitwise operators and mask

            Console.WriteLine("Please enter a second number");
            int secondNumber = int.Parse(Console.ReadLine());
            int mask = 1;
            int maskAndSecondNumber = secondNumber & mask;

            Console.WriteLine(maskAndSecondNumber);
            Console.WriteLine(maskAndSecondNumber == 0 ? "The second number {0} is even!" : "The second number {0} is odd!", secondNumber);
        }
    }
