/*Write a method that returns the last digit of given integer as an English word. Examples: 512  "two", 1024  "four", 12309  "nine".*/

using System;
using System.Collections.Generic;

class PrintLastDigit

    //the problem is solved in 2 different ways - the first way uses an int[] to store the numbers we enter, we pick the last digit of the array (the units of our number) and using a switch case find the name corresponding to the digit and return the name

    //for the second way, we divide the number by 10 and the remainder is the last digit of the number (here we again use a switch case to find the English word for the digit
{
    static string PrintEnglishWordArr(int[] numArr)
    {
        int lastDigit = numArr[numArr.Length - 1];

        switch (lastDigit)
        {
            case 0: return "zero";
            case 1: return "one";
            case 2: return "two";
            case 3: return "three";
            case 4: return "four";
            case 5: return "five";
            case 6: return "six";
            case 7: return "seven";
            case 8: return "eight";
            default: return "nine";
        }
    }

    static string PrintEnglishWordRemainder(int myNum)
    {
        int remainder =  myNum % 10;
        

        switch (remainder)
        {
            case 0: return "zero";
            case 1: return "one";
            case 2: return "two";
            case 3: return "three";
            case 4: return "four";
            case 5: return "five";
            case 6: return "six";
            case 7: return "seven";
            case 8: return "eight";
            default: return "nine";
        }
    }

    static string CheckInput(string number)
    {
        int num = 0;
        string myNum = "";
        bool check = int.TryParse(number, out num);

        while (!check)
	    {
	        Console.WriteLine("Invalid input!");
            Console.WriteLine("Please enter an integer number, ");
            Console.Write("number = ");

            number = Console.ReadLine();
            check = int.TryParse(number, out num);
	    }

        myNum = Convert.ToString(num);
        return myNum;
    }
    static void Main()
    {
        Console.WriteLine("Please enter an integer number of your choice, ");
        Console.Write("number = ");

        string number = Console.ReadLine();
        string originalNumber = number;
        number = number.TrimStart('-');
        number = CheckInput(number);
        int myNum = Convert.ToInt32(number);

        Console.WriteLine("First way of solving the problem - using an int[] to store the numbers: ");

        int[] numArr = new int[number.Length];

        for (int i = 0; i < numArr.Length; i++)
        {
            numArr[i] = Convert.ToInt32(number[i] - '0');
        }

        Console.WriteLine();
        Console.WriteLine("The last digit in {0} is \"{1}\".", originalNumber, PrintEnglishWordArr(numArr));

        Console.WriteLine("Second way of solving the problem - dividing the number by 10: ");
        Console.WriteLine();
        Console.WriteLine("The last digit in {0} is \"{1}\".", originalNumber, PrintEnglishWordRemainder(myNum));
    }
}
