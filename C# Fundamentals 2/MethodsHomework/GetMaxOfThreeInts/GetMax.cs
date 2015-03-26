/*Write a method GetMax() with two parameters that returns the bigger of two integers. Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().*/

using System;
using System.Collections.Generic;

class GetMax
{
    static int GetMaxNumber(int firstNumber, int secondNumber)     //this method compares the 2 numbers and finds the bigger one
    {
      //  int biggerNum = 0;
        int biggerNum = Math.Max(firstNumber, secondNumber);

        return biggerNum;
    }

    static string PrintCountInLetters(int count)        //I use this method to print the English name corresponding
    {                                                   //to the current countNums
        switch (count)
        {
            case 1: return "first";
            case 2: return "second";
            default: return "third";
        }
    }

    static int CheckInput (string number)       //checks whether the input is a number and if it is not ask for new input 
    {
        int num = 0;
        bool check = int.TryParse(number, out num);

        while (!check)
        {
            Console.WriteLine("Invalid input!");
            Console.WriteLine("In order for the program to proceed, you must enter an integer number");
            Console.Write("number = ");

            number = Console.ReadLine();
            check = int.TryParse(number, out num);
        }

        return num;
    }

    static void Main()
    {
        Console.WriteLine("This program will compare 3 numbers of your choice and as a result will print the biggest one.");
        int countNums = 1;
        int firstNum = 0;
        int secondNum = 0;
        int thirdNum = 0;

        while (countNums <= 3)      //using this cycle I check and initialize the 3 numbers
        {
            Console.Write("Please enter the {0} number, {1} =  ", PrintCountInLetters(countNums), countNums);
            string number = Console.ReadLine();

            if (countNums == 1)
            {
                firstNum = CheckInput(number);
            }
            else if (countNums == 2)
            {
                secondNum = CheckInput(number);
            }
            else
            {
                thirdNum = CheckInput(number);
            }

            countNums++;
        }

        int maxNumber = GetMaxNumber(firstNum, secondNum);
        maxNumber = GetMaxNumber(maxNumber, thirdNum);

        int[] numbers = new int[3] { firstNum, secondNum, thirdNum };

        Console.WriteLine();
        Console.WriteLine("The biggest number in the following sequence of three is colored in green: ");

        for (int i = 0; i < numbers.Length; i++)        //printing the sequence of 3 numbers that we have compared
        {                                               //the biggest number is printed in green
            if (maxNumber == numbers[i])
            {
                if (maxNumber == numbers.Length - 1)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write(" " + numbers[i] + " ");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write(" " + numbers[i] + " ");
                    Console.BackgroundColor = ConsoleColor.Black;
                }

            }
            else
            {
                if (numbers[i] == numbers.Length - 1)
                {
                    Console.Write(" " + numbers[i]);
                }
                else
                {
                    Console.Write(" " + numbers[i] + " ");
                }
            }
        }

        Console.WriteLine();

    }
}
