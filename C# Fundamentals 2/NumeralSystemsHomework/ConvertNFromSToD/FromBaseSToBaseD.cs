/* Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).*/

using System;
using System.Collections.Generic;
using System.Text;
   
class FromBaseSToBaseD
{ 
    static int ReturnDecimalValue(char value)
    {
        int hexValue = 0;

        switch (value)
        {
            case 'A': return hexValue = 10;
            case 'B': return hexValue = 11;
            case 'C': return hexValue = 12;
            case 'D': return hexValue = 13;
            case 'E': return hexValue = 14;
            case 'F': return hexValue = 15;
            default: return hexValue = value - '0';
        }
    }

    static string ReturnHexValue(int value)
    {
        string hexValue = string.Empty;

        switch (value)
        {
            case 10: return hexValue = "A";
            case 11: return hexValue = "B";
            case 12: return hexValue = "C";
            case 13: return hexValue = "D";
            case 14: return hexValue = "E";
            case 15: return hexValue = "F";
            default: return hexValue = Convert.ToString(value);
        }
    }

    static int ConvertToDecimal(string number, int baseFrom)
    {
        int decimalNum = 0;

        if (baseFrom > 10)
        {
            for (int i = 0; i < number.Length; i++)
            {
                decimalNum += (ReturnDecimalValue(number[i]) * (int)Math.Pow(baseFrom, number.Length - 1 - i));
            }
        }
        else
        {
            for (int i = 0; i < number.Length; i++)
            {
                decimalNum += Convert.ToInt32(number[i] - '0') * (int)Math.Pow(baseFrom, number.Length - 1 - i);
            }
        }

        return decimalNum;
    }

    static string ConvertFromDecimal(int decNumber, int baseTo)
    {
        List<string> remainders = new List<string>();
        string convertedNum = string.Empty;

        while (decNumber > 0)
        {
            remainders.Add(Convert.ToString(decNumber % baseTo));
            decNumber /= baseTo;
        }

        remainders.Reverse();

        if (baseTo > 10)
        {
            for (int i = 0; i < remainders.Count; i++)
            {
                remainders[i] = ReturnHexValue(Convert.ToInt32(remainders[i]));
            }

            convertedNum = string.Join("", remainders);
        }
        else
        {
            convertedNum = string.Join("", remainders);
        }

        return convertedNum;
    }

    static void Main()
    {
        Console.WriteLine("PLease enter the number you would like to convert, ");
        Console.Write("n = ");
        string number = Console.ReadLine();
        number = number.ToUpper();

        Console.WriteLine("Please enter a positive int number for the base you would like to Convert FROM, ");
        Console.Write("s = ");
        int s = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter a positive int number for the base you would like to Convert TO, ");
        Console.Write("d = ");
        int d = int.Parse(Console.ReadLine());

        if (s < 2 || s > 16 && d < 2 || d > 16)
        {
            Console.WriteLine();
            Console.WriteLine("Incorrect input data!");
            Console.WriteLine("In order for the program to work, the input for the numeral systems have to be in the range [2, 16].");
            Console.WriteLine("Please start over!");

        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Number {0} converted to base {1} is: {2}", number, d, ConvertFromDecimal(ConvertToDecimal(number, s), d));
        }
    }
}
