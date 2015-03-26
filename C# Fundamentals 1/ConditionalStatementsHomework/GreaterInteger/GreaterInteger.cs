/*Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.*/

using System;

    class GreaterInteger
    {
        static void Main()
        {
            Console.Write("Enter a number of your choice: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Enter a second number: ");
            int secondNum = int.Parse(Console.ReadLine());

            if (firstNum > secondNum)
            {
                firstNum += secondNum;
                secondNum = firstNum - secondNum;
                firstNum -= secondNum;

                Console.WriteLine();
                Console.WriteLine("After the exchange, the first number is: {0} and the second number is: {1}", firstNum, secondNum);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("The second number is greater, therefore the values of the 2 numbers remain the same.");
            }
        }
    }
