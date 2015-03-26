/*Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. Use the "selection sort" algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.*/

using System;
using System.Collections.Generic;

class SelectionSort
{
    static void Main()
    {
        // I decided to use the algorithm with both array and List<int>
        //First the solution with array

        Console.WriteLine("Please enter a positive integer number for the length of the array");
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        int[] arrToSort = new int[n];

        Console.WriteLine("Please enter the elements of the array: ");
        for (int i = 0; i < n; i++)
        {
            arrToSort[i] = int.Parse(Console.ReadLine());
        }

        string arrBeforeSorting = string.Join(" ", (arrToSort));
        Console.WriteLine();
        Console.WriteLine(arrBeforeSorting);

        int swap = 0;

        for (int i = 0; i < arrToSort.Length - 1; i++)
        {
            int min = arrToSort[i];
            for (int j = i + 1; j < arrToSort.Length; j++)
            {
                if (min > arrToSort[j])
                {
                    min = arrToSort[j];

                    swap = arrToSort[i];
                    arrToSort[i] = arrToSort[j];
                    arrToSort[j] = swap;
                }
            }
        }

        string arrAfterSorting = string.Join(" ", (arrToSort));
        Console.WriteLine(arrAfterSorting);

        //Here is the solution using List<int>

        Console.WriteLine();
        Console.WriteLine("Using the Selection sort algorithm with List<int>.");

        List<int> listToSort = new List<int>();

        Console.WriteLine();
        Console.WriteLine("Please enter a positive integer number for the length of the list, k = ");
        int k = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the elements of the list: ");
        for (int i = 0; i < k; i++)
        {
            listToSort.Add(int.Parse(Console.ReadLine()));   
        }

        string listBeforeSorting = string.Join(" ", (listToSort));
        Console.WriteLine();
        Console.WriteLine(listBeforeSorting);

        for (int i = 0; i < listToSort.Count - 1; i++)
        {
            int minNum = listToSort[i];

            for (int j = i + 1; j < listToSort.Count; j++)
            {
                if (minNum > listToSort[j])
                {
                    minNum = listToSort[j];
                    
                    listToSort.RemoveAt(j);
                    listToSort.Insert(i, minNum);
                }
            }
        }

        string listAfterSorting = string.Join(" ", listToSort);
        Console.WriteLine(listAfterSorting);
    }
}
