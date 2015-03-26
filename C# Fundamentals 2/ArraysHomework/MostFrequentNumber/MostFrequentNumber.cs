/*Write a program that finds the most frequent number in an array. Example:
	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)*/

using System;
using System.Collections.Generic;

class MostFrequentNumber
{
    static void Main()
    {
        Console.WriteLine("Please enter a postive integer number for the length of the array, ");
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int[] myArr = new int[n];

        for (int i = 0; i < n; i++)
        {
            myArr[i] = int.Parse(Console.ReadLine());
        }

        string arrToString = string.Join(" ", myArr);
        Console.WriteLine();
        Console.WriteLine(arrToString);

        int mostFrequent = 0;
        int currentElement = 0;
        int count = 0;
        int currentCount = 1;

        Console.WriteLine();
        Console.WriteLine(new string('-', 10) + " First solution using nested for loops " + new string('-', 10));

        for (int i = 0; i < myArr.Length - 1; i++)
        {
            currentElement = myArr[i];

            for (int j = i + 1; j < myArr.Length; j++)
            {
                if (currentElement == myArr[j])
                {
                    currentCount++;
                }
            }

            if (currentCount > count)
            {
                count = currentCount;
                mostFrequent = myArr[i];
            }
            currentCount = 1;
        }

        Console.WriteLine();
        Console.WriteLine("The most frequent element in the array is: {0}", mostFrequent);
        Console.WriteLine("It occures {0} times in the array.", count);

        //second solution using the "selection sort" algorithm

        Console.WriteLine();
        Console.WriteLine(new string('-', 10) + " Second solution using \"selection sort\" algorithm " + new string('-', 10));

        int swap = 0;
        int min = 0;

        for (int i = 0; i < myArr.Length - 1; i++)
        {
            min = myArr[i];

            for (int j = i + 1; j < myArr.Length; j++)
            {
                if (min > myArr[j])
                {
                    min = myArr[j];

                    swap = myArr[i];
                    myArr[i] = min;
                    myArr[j] = swap;
                }
            }
        }

        string sortedArr = string.Join(" ", myArr);
        Console.WriteLine();
        Console.WriteLine("After sorting the array we get: {0}", sortedArr);

        count = 0;
        currentCount = 1;

        for (int i = 0; i < myArr.Length; i++)
        {
            currentElement = myArr[i];
            int j = i + 1;

            while (j < myArr.Length)
            {
                if (currentElement == myArr[j])
                {
                    currentCount++;
                }
                j++;
            }

            if (currentCount > count)
            {
                count = currentCount;
                mostFrequent = currentElement;
            }
            currentCount = 1;
        }

        Console.WriteLine();
        Console.WriteLine("The most frequent element in the array is: {0}", mostFrequent);
        Console.WriteLine("It occures {0} times in the array.", count);
    }
}
