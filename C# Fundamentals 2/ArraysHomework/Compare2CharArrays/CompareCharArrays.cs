/*Write a program that compares two char arrays lexicographically (letter by letter) and checks, which one is first in the lexicographical order.*/

using System;

class CompareCharArrays
{
    static void Main()
    {
        Console.Write("Please enter an integer number for the length of the first array, n = ");
        int n = int.Parse(Console.ReadLine());
        char[] firstArr = new char[n];

        //initializing the first char array
        for (int i = 0; i < firstArr.Length; i++)
        {
            Console.Write("Please enter the element with index {0}: ", i);
            firstArr[i] = char.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        Console.Write("Please enter an integer number for the length of the second array, k = ");
        int k = int.Parse(Console.ReadLine());
        char[] secondArr = new char[k];

        //initializing the second char array
        for (int i = 0; i < secondArr.Length; i++)
        {
            Console.Write("Please enter the element with index {0}: ", i);
            secondArr[i] = char.Parse(Console.ReadLine());
        }

        bool equal = true;
        int checkValue = Math.Min(n, k); // I accept that the 2 arrays can have different lengths; therefore the number of iterations of the for loop should be equal to the smaller length **

        for (int i = 0; i < checkValue; i++)
        {
            if ((int)firstArr[i] != (int)secondArr[i])
            {
                equal = false;
                if ((int)firstArr[i] > (int)secondArr[i])
                {
                    Console.WriteLine();
                    Console.WriteLine("The second char array is first in the lexicographical order.");
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("The first char array is first in the lexicographical order.");
                    break;
                }
            }
        }
        if ((n == k) && equal)
        {
            Console.WriteLine();
            Console.WriteLine("The 2 char arrays are equal: {0}", equal);
        }
        else if (n != k && equal)
        {
            if (n > k)
            {
                Console.WriteLine();
                Console.WriteLine("The second char array is first in the lexicographical order.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("The first char array is first in the lexicographical order.");
            }
        }

       //second way of solving the problem
        Console.WriteLine();
        Console.WriteLine("Second solution - initializing the arrays using strings");

        Console.Write("Enter the first string: ");
        string firstStr = Console.ReadLine();
        Console.Write("Enter the second string: ");
        string secondStr = Console.ReadLine();

        char[] firstCharArr = new char[firstStr.Length];
        for (int i = 0; i < firstStr.Length; i++)
        {
            firstCharArr[i] = firstStr[i];
        }

        char[] secondCharArr = new char [secondStr.Length];
        for (int i = 0; i < secondStr.Length; i++)
		{
			secondCharArr[i]  = secondStr[i];
		}

        int minNumberOfIterations = Math.Min(firstStr.Length, secondStr.Length);
        equal = true;

        for (int i = 0; i < minNumberOfIterations; i++)
        {
            if ((int)firstCharArr[i] != (int)secondCharArr[i])
            {
                equal = false;

                if ((int)firstCharArr[i] > (int)secondCharArr[i])
                {
                    Console.WriteLine();
                    Console.WriteLine("The second char array is first in the lexicographical order.");
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("The first char array is first in the lexicographical order.");
                    break;
                }
            }
        }
        if (equal && (firstStr.Length == secondStr.Length))
        {
            Console.WriteLine();
            Console.WriteLine("The 2 char arrays are equal: {0}", equal);
        }
        else if (equal && (firstStr.Length != secondStr.Length))
        {
            if (firstStr.Length > secondStr.Length)
            {
                Console.WriteLine();
                Console.WriteLine("The second char array is first in the lexicographical order.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("The first char array is first in the lexicographical order.");
            }
        }
    }
}