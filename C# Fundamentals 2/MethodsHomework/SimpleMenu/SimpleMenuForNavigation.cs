/* Write a program that can solve these tasks:
        - Reverses the digits of a number
        - Calculates the average of a sequence of integers
        - Solves a linear equation a * x + b = 0
	Create appropriate methods.
	Provide a simple text-based menu for the user to choose which task to solve.
	Validate the input data:
        - The decimal number should be non-negative
        - The sequence should not be empty
        - a should not be equal to 0 */

using System;
using System.Collections.Generic;

class SimpleMenuForNavigation
{
    static string LoadReverseNumber()
    {
        Console.WriteLine("\nYou have chosen to load the program for reversing the digits of a number.");
        Console.WriteLine("Please enter a positive integer number of your choice, ");
        Console.Write("number = ");

        int number = CheckInputDecimalNumber(Console.ReadLine());
        string numberStr = Convert.ToString(number);

        int[] numberDigits = new int[numberStr.Length];

        if (numberStr.Length == 1)
        {
            return numberStr;
        }
        else
        {
            for (int i = 0; i < numberDigits.Length; i++)
            {
                numberDigits[i] = Convert.ToInt32(numberStr[numberStr.Length - 1 - i] - '0');
            }

            Console.WriteLine("\nYou have entered the number: {0}", number);

            return numberStr = string.Join("", numberDigits);
        }
    }

    static int LoadCalculateAverage()
    {
        Console.WriteLine("\nYou have chosen to load the program for calculating the average of an int sequence.");
        Console.WriteLine("Please enter a positive integer number for the length of the sequence, ");
        Console.Write("length = ");

        int length = int.Parse(Console.ReadLine());
        int sum = 0;
        bool empty = CheckLengthInput(length);

        if (!empty)
        {
            Console.WriteLine("\nPlease enter the elements of the sequence");

            int[] sequence = new int[length];

            for (int i = 0; i < sequence.Length; i++)       //initializing the array with the elements of the sequence
            {
                sequence[i] = int.Parse(Console.ReadLine());
            }

            string sequenceStr = string.Join(" ", sequence);
            Console.WriteLine("\nWe have the following sequence: {0}", sequenceStr);

            foreach (var member in sequence)        //calculating the sum of all elements
            {
                sum += member;
            }

            int average = sum / length;

            return average;
        }
        else
        {
            sum = int.MinValue;
            return sum;
        }
    }

    static decimal LoadSolveEquation()
    {
        Console.WriteLine("\nYou have chosen to load the program for solving a linear equation --> a * x + b = 0 ");
        Console.WriteLine("For a, please enter a number != 0 ");
        Console.Write("a = ");

        decimal a = CheckInputA(Console.ReadLine());

        Console.WriteLine("For b, please enter a number of your choice, ");
        Console.Write("b = ");

        decimal b = int.Parse(Console.ReadLine());

        Console.WriteLine("\nWe have the following linear equation: {0} * x + ({1}) = 0 ", a, b);

        b *= -1;

        Console.WriteLine("x = {1} / {0}", a, b);

        decimal x = b / a;

        return x;
    }

    static int CheckInputDecimalNumber(string number)
    {
        int num = 0;
        bool check = int.TryParse(number, out num);

        while (!check || num < 0)
        {
            Console.WriteLine("\nInvalid input!");
            Console.WriteLine("Please entre a positive integer number, ");
            Console.Write("number = ");

            number = Console.ReadLine();
            check = int.TryParse(number, out num);
        }

        return num;
    }

    static bool CheckLengthInput(int length)
    {
        bool empty = true;

        if (length != 0)
        {
            empty = false;
            return empty;
        }
        else
        {
            return empty;
        }
    }

    static decimal CheckInputA(string inputA)
    {
        decimal num = 0;
        bool check = decimal.TryParse(inputA, out num);

        while (!check || num == 0)
        {
            Console.WriteLine("Invalid input!");
            Console.WriteLine("In order for the program to proceed, for a, please enter a number other than 0.");
            Console.Write("a = ");

            inputA = Console.ReadLine();
            check = decimal.TryParse(inputA, out num);
        }

        return num;
    }

    static int CheckInput(string input)
    {
        int num = 0;
        bool check = int.TryParse(input, out num);

        while (check && num != 1 && num != 2 && num != 3 || !check) 
        {
            Console.WriteLine("\nInvalid input!");
            Console.Write("In order for the program to proceed please enter either 1, 2 or 3 --> ");

            input = Console.ReadLine();
            check = int.TryParse(input, out num);
        }

        return num;
    }
    static void Main()
    {
        Console.WriteLine(new string('-', 15) + "Welcome to our tiny application!" + new string('-', 15));
        Console.WriteLine("\nChoose one of the options in our menu to perform the corresponding operation: ");
        Console.WriteLine("1 --> Reverse the digits of a number");
        Console.WriteLine("2 --> Calculate the average of a sequence of ints");
        Console.WriteLine("3 --> Solve the a linear equation");
        Console.WriteLine("\nPlease enter either 1, 2 or 3");
        Console.Write("The application is waiting for your input: ");

        int input = CheckInput(Console.ReadLine());
        string result = "";

        if (input == 1)
        {
            result = LoadReverseNumber();

            Console.WriteLine("The reversed number is: {0}", result);
        }
        else if (input == 2)
        {
            int sequenceAverage = LoadCalculateAverage();

            if (sequenceAverage != int.MinValue)
            {
                Console.WriteLine("The average of the sequence is: {0}", sequenceAverage);   
            }
            else
            {
                Console.WriteLine("\nIn order to find the average of a sequence, it has to have elements.");
                Console.WriteLine("Please start over and enter a positive integer number for the length!");
            }
        }
        else if (input == 3)
        {
            decimal solution = LoadSolveEquation();

            Console.WriteLine("The result from solving the equation is: x = {0:f3} ", solution);
        }
    }
}
