/* Write a program to convert binary numbers to their decimal representation.*/

using System;
using System.Collections.Generic;
using System.Text;

class BinaryToDecimal
{
     //the problem is solved in 2 different ways:

    static int ConvertToDecimal(string number)
    {
        int decNumber = 0;

        int[] binNumber = new int[number.Length];

        for (int i = 0; i < binNumber.Length; i++)          //reversing the bits of the string so that the bit at position
        {                                                   //'0' of the array would be equal to the last element of the string
            binNumber[i] = number[number.Length - 1 - i] - '0';

            if (binNumber[i] == 1)
            {
                decNumber += binNumber[i] * (int)(Math.Pow(2, i));        //calculating the decimal number
            }
        }

        return decNumber;
    }

    static void Main()
    {
        Console.WriteLine("Please enter the binary number whose decimal representation you would like to find, ");
        Console.Write("number = ");
        string number = Console.ReadLine();
        int decNumber = ConvertToDecimal(number);

        //first solution using my own method

        Console.WriteLine();
        Console.WriteLine(new string('-', 15) + " First solution - using my own method " + new string('-', 15));
        Console.WriteLine("The decimal representation of the binary number ");
        Console.WriteLine("{0} is: {1}", number.PadLeft (32, '0'), decNumber);

        //second solution using Convert.ToInt32

        int decimalNum = Convert.ToInt32(number, 2);

        Console.WriteLine();
        Console.WriteLine(new string('-', 15) + " Second solution - using Convert.ToInt32 " + new string('-', 15));
        Console.WriteLine("The decimal representation of the binary number ");
        Console.WriteLine("{0} is {1}", number.PadLeft (32, '0'), decimalNum);

    }
}
