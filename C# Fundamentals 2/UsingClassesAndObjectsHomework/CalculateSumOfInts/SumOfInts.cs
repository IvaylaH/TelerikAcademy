/* You are given a sequence of positive integer values written into a string, separated by spaces. Write a function that reads these values from given string and calculates their sum. Example:
		string = "43 68 9 23 318"  result = 461*/

using System;
using System.Collections.Generic;
using System.Text;

class SumOfInts
{
    static void Main()
    {
        Console.WriteLine("Please enter a sequence of positive integers separating them with space, ");
        Console.Write("sequence = ");
        string sequence = Console.ReadLine();

        string[] sequenceArr = sequence.Split(' ');
        int sum = 0;

        for (int i = 0; i < sequenceArr.Length; i++)
        {
            sum += Convert.ToInt32(sequenceArr[i]);
        }

        Console.WriteLine("\nThe sum of the elements of the sequence is: {0}", sum);
    }
}
