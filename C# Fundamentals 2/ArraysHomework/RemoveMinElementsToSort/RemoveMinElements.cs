/** Write a program that reads an array of integers and removes from it a minimal number of elements in such way that the remaining array is sorted in increasing order. Print the remaining sorted array. Example:
	{6, 1, 4, 3, 0, 3, 6, 4, 5}  {1, 3, 3, 4, 5}*/

using System;
using System.Collections.Generic;
using System.Text;

class RemoveMinElements
{
    public const char removedNums = '\u002A';

    static void Main()
    {
        Console.WriteLine("Please enter a number for the length of the array/list, ");
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        int[] numsArr = new int[n];

        Console.WriteLine("Please enter the elements of the array");

        for (int i = 0; i < n; i++)
        {
            numsArr[i] = int.Parse(Console.ReadLine());
        }

        int maxNum = int.MinValue;
        int minNum = int.MinValue;
        int count = 0;
        List<string> counters = new List<string>();
        StringBuilder subsets = new StringBuilder();

        for (int i = 0; i < numsArr.Length - 1; i++)
        {
            int currentNum = numsArr[i];

            for (int j = i + 1; j < numsArr.Length; j++)
            {
                if (currentNum <= numsArr[j] && numsArr[j] >= numsArr[j + 1] && currentNum <= numsArr[j + 1])
                {
                    count++;
                    subsets.Append(numsArr[j + 1]);
                    j++;
                }
                else if (currentNum <= numsArr[j] && numsArr[j] >= numsArr[j + 1] && currentNum > numsArr[j + 1])
                {
                    count++;
                    subsets.Append(numsArr[j]);
                }
                else if (currentNum <= numsArr[j] && numsArr[j] <= numsArr[j + 1] && currentNum <= numsArr[j + 1]) //<= || <
                {
                    if (numsArr[j + 1] <= numsArr[j + 2])
                    {
                        count += 2;      //???????
                        subsets.Append(numsArr[j]);
                        subsets.Append(numsArr[j + 1]);
                        j++; //?????????????
                    }
                    else if (numsArr[j] <= numsArr[j + 2] && numsArr[j + 1] > numsArr[j + 2])
                    {
                        count++;
                        subsets.Append(numsArr[j]);
                    }
                }
            }
            counters.Add(Convert.ToString(count));
            subsets.Append(';'); //!!!
        }
    }
}