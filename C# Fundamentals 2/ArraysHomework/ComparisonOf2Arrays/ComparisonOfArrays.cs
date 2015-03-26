/*Write a program that reads two arrays from the console and compares them element by element.*/

using System;

class ComparisonOfArrays
{
    static void Main()
    {
        Console.Write("Enter an integer number for the length of the first array, n = ");
        int n = int.Parse(Console.ReadLine());
        int[] firstArr = new int[n];

       //initialization of the first array
        Console.WriteLine("Enter the elements of the first array: ");
        for (int i = 0; i < firstArr.Length; i++)
        {
            firstArr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        Console.Write("Enter an integer number for the length of the second array, k = ");
        int k = int.Parse(Console.ReadLine());
        int[] secondArr = new int[k];

        //initialization of the second array
        Console.WriteLine("Enter the elements of the second array: ");
        for (int i = 0; i < secondArr.Length; i++)
        {
            secondArr[i] = int.Parse(Console.ReadLine());
        }

        bool areEqual = false;
        int elementsCount = 0;

        if (n == k)
        {
            for (int i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    elementsCount++;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("The two arrays are equal: {0}", areEqual);
                    break;
                }
            }
            if (n == elementsCount)
            {
                areEqual = true;
                Console.WriteLine();
                Console.WriteLine("The two arrays are equal: {0}", areEqual);
            }
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("The two arrays are equal: {0}", areEqual);
        }
    }
}
