/*Write a method that reverses the digits of given decimal number. Example: 256  652*/

using System;
using System.Collections.Generic;

class ReverseDigits
{
    //the problem is solved in 2 different ways - the first one uses an array to stored the digits of the reversed number
    //the second way - we divide the number by 10 (number % 10) and add the remainder to List<int> the print the list

    static int[] InitializeNumberArr(string number) //first solution using an array and for-loop
    {
        int[] numberArr = new int[number.Length];

        for (int i = 0; i < numberArr.Length; i++)
        {
            numberArr[i] = Convert.ToInt32(number[number.Length - i - 1] - '0');
        }

        return numberArr;
    }

    static string ReverseByDivision(int myNum)      //second solution using List<int> and division by 10
    {
        List<int> reversedNum = new List<int>();

        int remainder = 0;

        while (myNum != 0)
        {
            remainder = myNum % 10;
            reversedNum.Add(remainder);

            myNum /= 10;
        }
        string reversedNumToStr = string.Join("", reversedNum);

        return reversedNumToStr;
    }

    static void PrintResult(bool negativeNum, int myNum, string reversedNum)    //method for printing the final result
    {
        if (negativeNum)
        {
            Console.WriteLine();

            Console.BackgroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("The original number is: - {0}", myNum);
            Console.WriteLine("The reversed number is: - {0}", reversedNum);

            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine();
        }
        else
        {
            Console.WriteLine();

            Console.BackgroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("The original number is: {0}", myNum);
            Console.WriteLine("The reversed number is: {0}", reversedNum);

            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine();
        }
    }
    static int CheckInput(string number)        //checking the input
    {
        int num = 0;
        bool checkInput = int.TryParse(number, out num);

        while (!checkInput)
        {
            Console.WriteLine("Invalid input!");
            Console.WriteLine("Please enter an integer number!");
            Console.Write("number = ");

            number = Console.ReadLine();
            checkInput = int.TryParse(number, out num);
        }
        
        return num;
    }

    static void Main()
    {
        Console.WriteLine("Please enter a number of your choice, ");
        Console.Write("number = ");
        string number = Console.ReadLine();
        
        int myNum = CheckInput(number);
        bool negativeNum = false;   

        if (myNum < 0)      //if the user has entered a negative number, we turn it into a positive one, so that we can 
        {                   //reverse the digits; the bool negativeNum keeps the sign, we use it when printing the result
            negativeNum = true;
            myNum *= -1;
        }

        number = number.TrimStart('-');
        int[] numberArr = InitializeNumberArr(number);

        string reversedNum = string.Join("", numberArr);

        Console.WriteLine("\nFirst solution using an array and a for-loop: ");

        PrintResult(negativeNum, myNum, reversedNum);

        reversedNum = ReverseByDivision(myNum);
        Console.WriteLine("Second solution using a List<int> and division by 10: ");

        PrintResult(negativeNum, myNum, reversedNum);

    }
}
