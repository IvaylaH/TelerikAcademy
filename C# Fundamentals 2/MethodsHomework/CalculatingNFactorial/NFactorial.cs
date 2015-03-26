/*Write a program to calculate n! for each n in the range [1..100]. Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. */

using System;
using System.Collections.Generic;
using System.Numerics;

class NFactorial
{
    static BigInteger CalculateNFactorial(int n)
    {
        BigInteger factorial = 1;

        for (int i = 2; i <= n; i++)
        {
            factorial *= i;
        }

        return factorial;
    }

    static int CheckN(string number)
    {
        int num = 0;
        bool checkValue = int.TryParse(number, out num);

        while (!checkValue || (num < 1 || num > 100)) //!!!!!!!!!!!!!!!
        {
            Console.WriteLine("Invalid input!");
            Console.WriteLine("In order to proceed, for n, please enter a number in the range [1 ... 100], ");
            Console.Write("number = ");

            number = Console.ReadLine();
            checkValue = int.TryParse(number, out num);
        }

        return num;
    }

    static void Main()
    {
        int[] numsArr = new int[100];

        for (int i = 0; i < 100; i++)
        {
            numsArr[i] = i + 1;
        }

        string arrToStr = string.Join(" ", numsArr);
        Console.WriteLine(arrToStr);

        Console.WriteLine("This program will calculate the factorial of a number of your choice, ");
        Console.WriteLine("such that 1 <= number <= 100, ");
        Console.Write("number = ");
        int n = CheckN(Console.ReadLine());

        BigInteger nFactorial = CalculateNFactorial(n);

        Console.WriteLine("\n{0}! is: {1}", n, nFactorial);
    }
}
