/*Write a program that calculates the greatest common divisor (GCD) of given two numbers. Use the Euclidean algorithm (find it in Internet).*/

using System;

    class GreatestCommonDivisor
    {
        static void Main()
        {
            Console.Write("Please enter a number of your choice: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Please enter a second number: ");
            int secondNum = int.Parse(Console.ReadLine());
            int remainder = 0;
            int greatestCommonDivisor;

            int maxNum = Math.Max(firstNum, secondNum);
            int minNum = Math.Min(firstNum, secondNum);
               
            do
            {
                remainder = maxNum % minNum;
                maxNum = minNum;
                minNum = remainder;
            }
            while (remainder != 0);
            greatestCommonDivisor = maxNum;
  
            Console.WriteLine();
            Console.WriteLine("The greatest common divisor of {0} and {1} is {2}", firstNum, secondNum, greatestCommonDivisor);
            }
        }

