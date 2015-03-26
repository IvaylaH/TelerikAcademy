/*Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.*/

using System;

class PBetweenTwoIntegers
{
    static void Main()
    { //The proble is solved in two different ways
        Console.Write("Please enter 2 positive integer numbers of your choice.\nThe first number is: ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("The second number is: ");
        int secondNum = int.Parse(Console.ReadLine());
        int p = 0;
        int difference = 0;

        //this is the first way:
        Console.WriteLine("\nSolving the problem using for loop");
        if (firstNum < secondNum)
        {
            for (int i = firstNum; i <= secondNum; i++)
            {
                if (i % 5 == 0)
                {
                    p++;
                }
            }
            Console.WriteLine("There are {0} numbers between {1} and {2} that can be divided by 5 without remainder.", p, firstNum, secondNum);
        }
        else
        {
            firstNum += secondNum;
            secondNum = firstNum - secondNum;
            firstNum = firstNum - secondNum;

            for (int i = firstNum; i <= secondNum; i++)
            {
                if (i % 5 == 0)
                {
                    p++;
                }
            }
            Console.WriteLine("There are {0} numbers between {1} and {2} that can be divided by 5 without remainder.", p, firstNum, secondNum);

        }
        
        //this is the second one
        Console.WriteLine();
        Console.WriteLine("Solving the problem using a math trick:");

        difference = Math.Abs(secondNum - firstNum);

        if (difference != 10)
        {
            p = difference / 5;
        }
        else
        {
            p = (difference / 5) - 1;
        }

        if (firstNum % 5 == 0)
        {
            p++;
            if (secondNum % 5 == 0)
            {
                p++;
                Console.WriteLine("There are {0} numbers between {1} and {2} that can be divided by 5 without remainder.", p, firstNum, secondNum);
            }
            else
            {
                Console.WriteLine("There are {0} numbers between {1} and {2} that can be divided by 5 without remainder.", p, firstNum, secondNum);
            }
        }
        else
        {
            Console.WriteLine("There are {0} numbers between {1} and {2} that can be divided by 5 without remainder.", p, firstNum, secondNum);
        }
    }
}
  