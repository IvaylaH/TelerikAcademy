/*Write a program that, depending on the user's choice inputs int, double or string variable. If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. The program must show the value of that variable as a console output. Use switch statement.*/

using System;

    class IntDoubleStringVars
    {
        static void Main()
        { //The problem is solved in two different ways.
            Console.WriteLine("Please enter 1 if your input is an integer number;");
            Console.WriteLine("             2 if your input is a real number;");
            Console.WriteLine("             3 if you want to enter a string.");

          //This is the first way using ReadKey and 4 if-else statements:
            ConsoleKeyInfo key = Console.ReadKey(); 
            char pressedKey = key.KeyChar;
            char one = '\u0031';
            char two = '\u0032';
            char three = '\u0033';
            bool charCheck = ((pressedKey == one) || (pressedKey == two) || (pressedKey == three));

            if (charCheck == true)
            {
                if (pressedKey == one)
                {
                    Console.Write("\nPlease enter an integer number for n, n = ");
                    int n = int.Parse(Console.ReadLine());
                    int newN = n + 1;

                    Console.WriteLine("\nYou have enter the number {0}. {0} + 1 = {1}", n, newN);
                }
                else if (pressedKey == two)
                {
                    Console.Write("\nPlease enter a real number for d, d = ");
                    double d = double.Parse(Console.ReadLine());
                    double newD = d + 1;

                    Console.WriteLine("\nYou have enter the number {0}. {0} + 1 = {1}", d, newD);
                }
                else
                {
                    Console.Write("\nPlease enter a string: ");
                    string str = Console.ReadLine();
                    string newStr = str + "*";

                    Console.WriteLine("\nYou have enter the string {0}. The new string is: {1}.", str, newStr);
                }
            }
            else
            {
                Console.WriteLine("\nInvalid input. Please start over.");
            }

            //This is the second way. The logic is the same, only using switch statements as requested in the problem:
            Console.WriteLine("Second way using switch statements:");
            int choiceNum = int.Parse(Console.ReadLine());

            switch(choiceNum)
            {
                case 1:
                    Console.Write("\nPlease enter an integer number for x, x = ");
                    int x = int.Parse(Console.ReadLine());

                    Console.WriteLine("You have enter the number {0}. {0} + 1 = {1}", x, x + 1);
                    break;
                case 2:
                    Console.Write("\nPlease enter a real number for y, y = ");
                    double y = double.Parse(Console.ReadLine());

                    Console.WriteLine("You have enter the number {0}. {0} + 1 = {1}", y, y + 1);
                    break;
                case 3:
                    Console.Write("\nPlease enter a string: ");
                    string yourStr = Console.ReadLine();

                    Console.WriteLine("You have enter the string {0}. The new string is {1}.", yourStr, yourStr + "*");
                    break;
                default:
                    Console.WriteLine("\nInvalid input. Please start over.");
                    break;
            }

        }
    }
