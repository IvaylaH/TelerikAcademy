/*Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.*/

using System;

    class IntegerDivision
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number of your choice.");
            int number = int.Parse(Console.ReadLine());
            int divisionByFive = number % 5;
            int divisionBySeven = number % 7;
            bool remainder = ((divisionByFive == 0) && (divisionBySeven == 0));

            Console.WriteLine(remainder == true ? "The number {0} can be divided by both 5 and 7 without remainder" : "The number {0} cannot be divided by both 5 and 7 without remainder", number);
            
            //Since 5 * 7 = 35, this is the first number that can be divided by both 5 and 7. Any number multiplied by 35 would give as a result a number that can be divided by both 5 and 7. So we can run only one test.

            Console.WriteLine("Please enter a second number.");
            int secondNumber = int.Parse(Console.ReadLine());
            int divisionByThirtyFive = secondNumber % 35;
            bool secondRemainder = (divisionByThirtyFive == 0);

            Console.WriteLine(secondRemainder == true ? " The number {0} can be divided by 35 without remainder, therefore it can be divided by both 5 and 7!" : "The number {0} cannot be divided by 35 without remainder, therefore it cannot be divided by both 5 and 7!", secondNumber);
        }
    }
