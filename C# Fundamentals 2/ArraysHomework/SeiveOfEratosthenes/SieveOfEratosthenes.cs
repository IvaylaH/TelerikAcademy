/*Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm (find it in Wikipedia).*/

using System;
using System.Collections.Generic;

class SieveOfEratosthenes
{
    public const string notPrime = "*"; //after that I should try with the bool[]
    static void Main()
    {
        int n = 10000000;
       // int n = 100;
        string[] numbers = new string[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = Convert.ToString(i + 1);
        }

   //   string arrToString = string.Join(" ", numbers);
   //   Console.WriteLine(arrToString);
  //    Console.WriteLine(numbers[n - 1]);

        int maxCheck = (int)Math.Sqrt(n);

        Console.WriteLine("First solution using string[]");

        int j = int.Parse(numbers[1]);
        while (j < maxCheck)
        {
            if (numbers[j - 1] != notPrime)
            {
                int squareJ = j * j;
                for (int i = squareJ; i <= n; i += j)
                {
                    if (numbers[i - 1] != notPrime)
                    {
                        numbers[i - 1] = notPrime; //!!   
                    }
                }
            }
            j++;
        }

        List<int> primeNums = new List<int>();

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] != notPrime)
            {
                primeNums.Add(int.Parse(numbers[i]));
            }
        }

        foreach (int num in primeNums)
        {
            Console.Write(num + " ");
        }

        bool[] boolArr = new bool[n + 1];

        for (int i = 0; i < n; i++)
        {
            boolArr[i] = true;
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Second solution using bool[]:");

        for (int i = 2; i < maxCheck; i++)
        {
            if (boolArr[i])
            {
                int squareI = i * i;
                for (int k = squareI; k <= boolArr.Length; k += i)
                {
                    if (boolArr[k])
                    {
                        boolArr[k] = false;
                    }
                }
            }
        }

        for (int i = 2; i < boolArr.Length; i++)
        {
            if (boolArr[i])
            {
                Console.Write(i + " ");
            }
        }

        Console.WriteLine();
        Console.WriteLine();

    }
}
