/* Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).*/

using System;
using System.Collections.Generic;
using System.Text;

class BinRepresentationOfShort
{
    static string ConvertPositiveToBinary(short number)
    {
        List<short> remainders = new List<short>();

        while (number > 0)
        {
            remainders.Add((short)(number % 2));
            number /= 2;
        }

        remainders.Reverse();

        string binNumToStr = string.Join("", remainders);

        return binNumToStr;
    }
   
    static string ApplyTwosComplement(string binaryNumber)
    {
        binaryNumber = binaryNumber.PadLeft(16, '0');
        List<short> reversedBinary = new List<short>(); 

        for (int i = 0; i < 16; i++)
        {
            int mask = 1;
            int currentElement = Convert.ToInt16(binaryNumber[i] - '0');
            int bit = currentElement & mask;

            if (bit == 1)
            {
                reversedBinary.Add(0);
            }
            else
            {
                reversedBinary.Add(1);
            }
        }

        binaryNumber = string.Join("", reversedBinary);

        return binaryNumber;
    }

    static void Main()
    {
        Console.WriteLine("PLease enter a 16-bit signed number, ");
        Console.Write("number = ");
        short number = short.Parse(Console.ReadLine());
        short originalNumber = number;
        
        bool isNegative = false;

        if (number < 0)
        {
            isNegative = true;
            number *= -1;       //an alternative to does 2 lines would be: number = Math.Abs(number) - 1;
            number -= 1;
        }

        string binaryNumber = ConvertPositiveToBinary(number);

        if (isNegative)
        {
            string binNumToStr = ApplyTwosComplement(binaryNumber);

            Console.WriteLine();
            Console.WriteLine("The binary representation of number {0} is: {1} ", originalNumber, binNumToStr);
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("The binary representation of number {0} is: {1} ", originalNumber, binaryNumber.PadLeft(16, '0'));
        }
    }
}
