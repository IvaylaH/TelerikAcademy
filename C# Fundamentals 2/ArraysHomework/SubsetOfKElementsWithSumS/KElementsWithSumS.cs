/** Write a program that reads three integer numbers N, K and S and an array of N elements from the console. Find in the array a subset of K elements that have sum S or indicate about its absence.*/

using System;
using System.Collections.Generic;

class KElementsWithSumS
{
    static void Main()
    {
        Console.WriteLine("Please enter a positive integer value for the length of the array, ");
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the elements of the array followed by ',' ");
        string strNums = Console.ReadLine();
        string[] numbers = strNums.Split(',');

      /*  Console.WriteLine();  //printing the array

        foreach (var number in numbers)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine();*/

        Console.WriteLine("Please enter a positive integer number for the number of elements we'll be looking for,");
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter an int number for the sum we're looking for, ");
        Console.Write("s = ");
        int s = int.Parse(Console.ReadLine());

        int maxIterations = (int)(Math.Pow((double)2, n) - 1);
        bool possible = false;
        int countSubsets = 0;

        for (int i = 1; i < maxIterations; i++)
        {
            int count = 0; //!! 0 || 1
            int tempSum = 0;
            string printSubset = "";

            for (int j = 0; j < numbers.Length; j++)
            {
                int mask = 1 << j;
                int iAndMask = i & mask;
                int bit = iAndMask >> j;

                if (bit == 1)
                {
                    tempSum += Convert.ToInt32(numbers[j]);
                    count++;
                    if (count == 1)
                    {
                        printSubset += numbers[j];
                    }
                    else
                    {
                        printSubset += " " + numbers[j];
                    }
                }
            }
            if (count == k && tempSum == s)
            {
                possible = true;
                int j = 0;
                string[] print = printSubset.Split(' ');
                countSubsets++;

                Console.Write("Yes ");

                while (j < print.Length)
                {
                    if (j != print.Length - 1)
                    {
                        Console.Write(print[j] + " + ");
                    }
                    else
                    {
                        Console.Write(print[j] + " = " + s);
                    }
                    j++;
                }

                Console.WriteLine();
            }
        }

        if (!possible)
        {
            Console.WriteLine();
            Console.WriteLine("In the present array there is a subset of {0} elements with sum equal to {1}: {2}", k, s, possible);
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("The number of subsets with {0} elements and sum equal to {1} is {2}", k, s, countSubsets);
        }
    }
}