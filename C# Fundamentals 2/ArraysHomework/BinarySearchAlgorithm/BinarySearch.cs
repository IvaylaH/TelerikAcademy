/*Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).*/

using System;
using System.Collections.Generic;
using System.Text;

    class BinarySearch
    {
     /*   static string PerformBinarySearch(int n, int searchFor, i)
        {
            
        }*/
        static void Main()
        {
            Console.WriteLine("Please enter a positive integer number for the length fo the array, ");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            int[] myArr = new int[n];
            for (int i = 0; i < n; i++)
            {
                myArr[i] = int.Parse(Console.ReadLine());
            }

            string arrBeforeSorting = string.Join(" ", myArr);
            Console.WriteLine();
            Console.WriteLine(arrBeforeSorting);

            //sorting the array using "selection sort"

            for (int i = 0; i < myArr.Length - 1; i++)
            {
                int min = myArr[i];
                int swap = 0;

                for (int j = i + 1; j < myArr.Length; j++)
                {
                    if (min > myArr[j])
                    {
                        min = myArr[j];

                        swap = myArr[i];
                        myArr[i] = myArr[j];
                        myArr[j] = swap;
                    }
                }
            }
            string arrAfterSorting = string.Join(" ", myArr);
            Console.WriteLine();
            Console.WriteLine(arrAfterSorting);

            Console.WriteLine();
            Console.WriteLine("Please enter the number we'll be searching for in the array.");
            int searchFor = int.Parse(Console.ReadLine());

            //first Solution using the Binary Search algorithm

            Console.WriteLine();
            Console.WriteLine(new string('*', 5) + " Solving the problem using the Binary search algorithm: " + new string('*', 5));

            int iMin = 0;
            int iMax = n - 1;
            int iMid = iMin + ((iMax - iMin) / 2);
            StringBuilder message = new StringBuilder();
            message.Append("The number " + searchFor + " we've been looking for was");

            if (iMax < iMin)
            {
                message.Append(" not found!");
            }
            else
            {
                if (myArr[iMid] > searchFor)
                {
                    for (int i = iMin; i < iMid; i++)
                    {
                        if (myArr[i] == searchFor)
                        {
                            message.Append(" found at position " + i + "!");
                        }
                    }
                }
                else if (myArr[iMid] < searchFor)
                {
                    for (int i = iMid; i <= iMax; i++)
                    {
                        if (myArr[i] == searchFor)
                        {
                            message.Append(" found at position " + i + "!");
                        }
                    }
                }
                else
                {
                    message.Append(" found at position " + iMid + "!");
                }
            }

            Console.WriteLine();
            Console.WriteLine(message);

            //Second solution using the property BinarySearch

            Console.WriteLine();
            Console.WriteLine(new string('*', 5) + " Solving the problem using Array.BinarySearch() " + new string('*', 5));

            int position = (Array.BinarySearch(myArr, searchFor));
            if (position >= 0)
            {
                Console.WriteLine();
                Console.WriteLine("The number {0} that we've been looking for was found at position {1}!", searchFor, position);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("There is no such number in the present array!");
            }
        }
    }