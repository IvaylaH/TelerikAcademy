/* Write a program to convert hexadecimal numbers to their decimal representation.*/

using System;
using System.Collections.Generic;
using System.Text;

class HexToDecimal
{   //the problem has 2 different solutions
    static int ConvertToDecimal(string hexNumber)
    {
        int decNumber = 0;

        for (int i = 0; i < hexNumber.Length; i++)
        {
            decNumber += UseHexDigit((char)hexNumber[hexNumber.Length - 1 - i]) * (int)(Math.Pow(16, i));
        }

        return decNumber;
    }
    static int UseHexDigit(char currentElement)
    {
        int hexValue = 0;

        switch (currentElement)
        {
            case 'A': return hexValue = 10;
            case 'B': return hexValue = 11;
            case 'C': return hexValue = 12;
            case 'D': return hexValue = 13;
            case 'E': return hexValue = 14;
            case 'F': return hexValue = 15;
            default: return hexValue = currentElement - '0';
        }
    }

    static void Main()
    {
        Console.WriteLine("Please enter the number in hexadecimal numeral system that you would like to convert to decimal numeral system, ");
        Console.Write("number = ");
        string hexNumber = Console.ReadLine();
        hexNumber = hexNumber.ToUpper();

        //first solution using my own method

        int decimalNumber = ConvertToDecimal(hexNumber);

        Console.WriteLine();
        Console.WriteLine(new string('-', 15) + " First solution using my own method " + new string('-', 15));
        Console.WriteLine("The decimal representation of the hex number {0} is: {1} ", hexNumber, decimalNumber);

        //second solution using Convert.ToInt32

        int decNumber = Convert.ToInt32(hexNumber, 16);

        Console.WriteLine();
        Console.WriteLine(new string ('-', 15) + " Second solution using Convert.ToInt32 " + new string ('-', 15));
        Console.WriteLine("The decimal representation of the hex number {0} is: {1} ", hexNumber, decNumber);
    }
}
