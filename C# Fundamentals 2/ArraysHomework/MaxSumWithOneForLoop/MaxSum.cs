/*Write a program that finds the sequence of maximal sum in given array. Example:
	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
	Can you do it with only one loop (with single scan through the elements of the array)?*/

using System;
using System.Collections.Generic;

class MaxSum
{
    static int checkInput (string number)   //Here I check the input for n and ensure that it is a number bigger 0
    {
       int num = 0;
       bool check = int.TryParse(number, out num);

        while (check && num <= 0)
        {
            Console.WriteLine("Invalid input!");
            Console.WriteLine("For n, please enter an integer number greater than or equal to 1.");
            number = Console.ReadLine();
            check = int.TryParse(number, out num);
        }
        return num;
    }

    static int checkElements(string number)     //Here I check whether the input for th elements of the array is a number
    {
        int num = 0;
        bool check = int.TryParse(number, out num);

        while(!check)
        {
            Console.WriteLine("Invalid input!");
            Console.WriteLine("Please try again and this time enter a number: ");
            number = Console.ReadLine();
            check = int.TryParse(number, out num);
        }
        return num;
    }

    static void Main()
    {
        Console.WriteLine("Please enter a positive integer number for the length of the array,");
        Console.Write("n = ");
        int n = checkInput(Console.ReadLine());

        int[] myArr = new int[n];

        Console.Write("Please enter the {0} elements of the array: ", n);
        for (int i = 0; i < n; i++)
        {
            myArr[i] = checkElements(Console.ReadLine());
        }

        string arrToString = string.Join(" ", (myArr));
        Console.WriteLine(arrToString);     //printing the array as a string

        int maxSum = int.MinValue;
        int currentSum = 0;         //Here I use indices for preserving the elements of the sequence 
       // int startIndex = 0;         //and print them with for loop
       // int endIndex = 0;

        Console.WriteLine();
        Console.WriteLine("Solution using the implementation of the Kadane's algorithm: ");
        Console.WriteLine();

        currentSum = 0;
        List<int> sequence = new List<int>();   //I am using list<int> to preserve the elements of the sequence
        string printSequence = null;            //then join the elements in the printSequence string to print them

        for (int i = 0; i < myArr.Length; i++)
        {
           currentSum += myArr[i];
           sequence.Add(myArr[i]);
           if (maxSum < currentSum)
           {
               maxSum = currentSum;
               printSequence = string.Join(" ", sequence);
           }
           if (currentSum < 0)
           {
               currentSum = 0;
               sequence.Clear();
           }
        }

        Console.WriteLine("The elements of the sequence are: {0}", printSequence);
        Console.WriteLine("Their sum is: {0}", maxSum);
    }
}