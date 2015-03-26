/*Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.*/

using System;

    class GreaterThanTwoNumbers
    {
        static void Main()
        {
            Console.Write("Please enter a number of your choice: ");
            double firstNum = double.Parse(Console.ReadLine());
            Console.Write("Please enter a second number of your choice: ");
            double secondNum = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("First method using Math.Max property: ");
            double greaterNum = Math.Max(firstNum, secondNum);
            Console.WriteLine(greaterNum);

            Console.WriteLine();
            Console.Write("Second method using ternary operator: ");
            double difference = (firstNum - secondNum > 0 ? firstNum : secondNum);
            Console.WriteLine("The greater number is: " + difference);
        }
    }
