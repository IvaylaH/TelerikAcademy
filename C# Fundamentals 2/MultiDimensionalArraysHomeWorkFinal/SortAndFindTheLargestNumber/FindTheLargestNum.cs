/*Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. */

using System;
using System.Collections.Generic;

class FindTheLargestNum
{
    public class SortComparer : IComparer<int>
    {
        public int Compare(int x, int y) //reversing the already sorted array using lambda expression
        {
            return y.CompareTo(x);
        }
    }
    public class ValuesComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return x.CompareTo(y);
        }
    }

    static int[] SortTheArray(int[] numsArr)          //sorting the array using selection sort algorithm
    {
        int iMin = 0;
        int swap = int.MinValue;

        for (int i = 0; i < numsArr.Length - 1; i++)
        {
            iMin = i;
            int currentMin = numsArr[iMin];

            for (int j = i + 1; j < numsArr.Length; j++)
            {
                int elementChecked = numsArr[j];

                if (numsArr[j] < numsArr[iMin])
                {
                    iMin = j;
                }
            }

            if (iMin != i)
            {
                swap = numsArr[iMin];
                numsArr[iMin] = numsArr[i];
                numsArr[i] = swap;
                //     Console.WriteLine(numsArr[i] + " " + numsArr[iMin]);
            }
        }

        return numsArr;
    }
    static void Main()
    {
        Console.WriteLine("Please enter a positive integer number for the length of the array, ");
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        int[] numsArr = new int[n];

        Console.WriteLine("Please enter the elements of the array: ");

        for (int i = 0; i < numsArr.Length; i++)
        {
            numsArr[i] = int.Parse(Console.ReadLine());
        }

        string arrBeforeSorting = string.Join(" ", numsArr);

        //      Console.BackgroundColor = ConsoleColor.White;
        //    Console.ForegroundColor = ConsoleColor.DarkBlue;

        Console.WriteLine(new string('-', 40));
        Console.WriteLine("This is the array we'll be working with: ");
        Console.WriteLine(arrBeforeSorting);

        numsArr = SortTheArray(numsArr);
        string sortedArr = string.Join(" ", numsArr);

        Console.WriteLine(new string('-', 40));
        Console.WriteLine("This is the array after being sorted with the selection sort algorithm: ");
        Console.WriteLine(sortedArr);                       //printing the sorted array

        int[] sortArr = new int[numsArr.Length];

        for (int i = 0; i < numsArr.Length; i++)
        {
            sortArr[i] = numsArr[i];
        }
        Array.Sort(sortArr, new SortComparer());
        string reversedArr = string.Join(" ", sortArr);

        Console.WriteLine(new string('-', 40));
        Console.WriteLine("The array after being reversed using a lambda expression: ");
        Console.WriteLine(reversedArr);                     //printing the reversed array

        Console.Write("\nPlease enter an integer number for k, k = ");
        int k = int.Parse(Console.ReadLine());

        int index = Array.BinarySearch(numsArr, k, new ValuesComparer());

        Console.WriteLine("\nBinary search for a number <= {0}", k);
        CheckIndex(numsArr, index, k);

    }

    static void CheckIndex(int[] numsArr, int index, int k)
    {
        if (index < 0)
        {
            index = ~index;

            Console.WriteLine("The largest number <= k that we found in the present array is: ");
            if (index == 0) //!!!!
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("No number was found in the array such that number <= {0} ", k);
            }
            else if (index == numsArr.Length)
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("The largest element of the array that is <= {0} was found at position {1} ", k, index);
                Console.WriteLine("The element is: {0}", numsArr[index - 1]);
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("The largest element of the array that is <= {0} was found at position {1} ", k, index);
                Console.WriteLine("The element is: {0}", numsArr[index - 1]);
            }
            Console.WriteLine();
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("The largest element of the array that is <= {0} was found at position {1} ", k, index + 1);
            Console.WriteLine("The element is: {0}", numsArr[index]);
            Console.WriteLine();
        }

    }
}
