/*You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).*/

using System;
using System.Collections.Generic;

class SortAnArrayOfStrings
{
    static int CheckElements(string x, string y)           //Second solution - I found it at 
    {                                                       //http://msdn.microsoft.com/en-us/library/cxt053xf(v=vs.110).aspx 
        if (x == null)                                      //and decided to give it a try 
        {
            if (y == null)
            {
                return 0;                  //if both x and y are 0, then they are equal and the method will return '0'
            }
            else
            {
                return -1;                 //if x = null and y != null, then y is greater than x and the method will return '-1'
            }
        }
        else                               //x != null
        {
            if (y == null)
            {
                return 1;                  //if x != null and y == null, then x is greater than y and the method will return '1'
            }
            else                           //neigther x, nor y are null, therefore the method will compare their lengths
            {
                int value = x.Length.CompareTo(y.Length);

                if (value != 0)
                {
                    return value;          //the strings are not of equal length, therefore the longer string is greater
                }
                else
                {
                    return x.CompareTo(y); //neigther x, nor y is longer therefore we compare them lexicographically
                }
            }
        }
    }

    static void Main()
    {
        string str = "these are the elements of the array I need to sort"; //initializing the array
        string[] strArr = str.Split(' ');

        //printing the array

        Console.WriteLine("The array before the sorting: ");
        for (int i = 0; i < strArr.Length; i++)
        {
            Console.Write(strArr[i] + " ");
        }

        Console.WriteLine();

        Console.WriteLine(new string('-', 40));
        Console.WriteLine("First solution using lambda expressions and some additional checks: ");

        Array.Sort(strArr, CheckElements);

        foreach (string element in strArr)
        {
            if (element == null)
            {
                Console.Write("(null) ");
            }
            else
            {
                Console.Write(element + " ");
            }
        }
        Console.WriteLine();

        Console.WriteLine(new string('-', 40));

        Array.Sort(strArr, (x, y) => y.Length.CompareTo(x.Length));
        string reversedArr = string.Join(" ", strArr);

        Console.WriteLine("Second solution using only lambda expressions (the array is sorted in reversed order): ");
        Console.WriteLine(reversedArr);
    }
}

