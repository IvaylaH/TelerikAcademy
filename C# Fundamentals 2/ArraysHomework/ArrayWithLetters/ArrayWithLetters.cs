/*Write a program that creates an array containing all letters from the alphabet (A-Z). Read a word from the console and print the index of each of its letters in the array.*/

using System;
using System.Collections.Generic;
using System.Text;

class ArrayWithLetters
{
    static void Main()
    {
        char[] lowerCase = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        char[] upperCase = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        Console.Write("Please enter the word you would like me to check for you: ");
        string word = Console.ReadLine();

        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < 26; j++)
            {
                if (word[i] == upperCase[j] || word[i] == lowerCase[j])
                {
                    Console.WriteLine(word[i] + "is at position {0} in the latin alphabet.", j + 1);
                }
            }
        }
    }
}
