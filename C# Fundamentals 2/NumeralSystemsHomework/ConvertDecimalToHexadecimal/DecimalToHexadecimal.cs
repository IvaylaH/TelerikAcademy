/* Write a program to convert decimal numbers to their hexadecimal representation.*/

using System;
using System.Collections.Generic;
using System.Text;

class DecimalToHexadecimal
{
    //the problem is solved in 2 different ways
    static string ConvertToHex(int decNumber)
    {
        List<string> hexDigits = new List<string>();

        int remainder = decNumber % 16;
        decNumber /= 16;

        hexDigits.Add(FindHexDigits(remainder));

        while (decNumber != 0)
        {
            remainder = decNumber % 16;
            decNumber /= 16;

            hexDigits.Add(FindHexDigits(remainder));
        }

        for (int i = 0; i < hexDigits.Count / 2; i++)     //reversing the elements of the list
        {
            string swap = hexDigits[i];

            hexDigits[i] = hexDigits[hexDigits.Count - 1 - i];
            hexDigits[hexDigits.Count - 1 - i] = swap;
        }

        string hexValue = string.Join("", hexDigits);

        return hexValue;
    }

    static string FindHexDigits(int remainder)      //finding the digit in the hexadecimal numeral system that corresponds to 
    {                                               //the remainder we have and returning it as a string
        string hexDigit = "";

        switch (remainder)
        {
            case 10: return hexDigit = "A";
            case 11: return hexDigit = "B";
            case 12: return hexDigit = "C";
            case 13: return hexDigit = "D";
            case 14: return hexDigit = "E";
            case 15: return hexDigit = "F";
            default: return hexDigit = Convert.ToString(remainder);
        }
    }

    static void Main()
    {
        Console.WriteLine("Please enter the decimal number whose hexadecimal value you would like to find, ");
        Console.Write("number = ");
        int number = int.Parse(Console.ReadLine());
        string hexNumber = ConvertToHex(number);

        //first solution using my own method

        Console.WriteLine();
        Console.WriteLine(new string('-', 15) + " First solution using my own method " + new string('-', 15));
        Console.WriteLine("The hexadecimal representation of the decimal number {0} is: {1}", number, hexNumber);

        //second solution using Convert.ToString

        string hexValue = Convert.ToString(number, 16);
        hexValue = hexValue.ToUpper();

        Console.WriteLine();
        Console.WriteLine(new string('-', 15) + " Second solution using Convert.ToString " + new string('-', 15));
        Console.WriteLine("The hexadecimal representation of the decimal number {0} is: {1}", number, hexValue);
    }
}
