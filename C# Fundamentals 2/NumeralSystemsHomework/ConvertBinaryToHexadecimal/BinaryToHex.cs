/* Write a program to convert binary numbers to hexadecimal numbers (directly).*/

using System;
using System.Collections.Generic;
using System.Text;

class BinaryToHex
{
    static string ConvertToHexNumber(string binNumber)
    {
        List<string> hexNumber = new List<string>();

        int startIndex = 0;
        int count = 1;
        string sub = string.Empty;

        while (count <= 8)
        {
            sub = binNumber.Substring(startIndex, 4);
            hexNumber.Add(FindHexElement(sub));

            startIndex += 4;
            count++;
        }

        string hexNumToStr = string.Join("", hexNumber);
        
        return hexNumToStr;
    }

    static string FindHexElement(string binSequence)
    {
        switch (binSequence)
        {
            case "0000": return "";
            case "0001": return "1";
            case "0010": return "2";
            case "0011": return "3";
            case "0100": return "4";
            case "0101": return "5";
            case "0110": return "6";
            case "0111": return "7";
            case "1000": return "8";
            case "1001": return "9";
            case "1010": return "A";
            case "1011": return "B";
            case "1100": return "C";
            case "1101": return "D";
            case "1110": return "E";
            default: return "F";
        }
    }

    static void Main()
    {
        Console.WriteLine("Please enter the binary number you would like to convert to hexadecimal number, ");
        Console.Write("number = ");
        string number = Console.ReadLine();
        number = number.PadLeft(32, '0');

        string hexadecimal = ConvertToHexNumber(number);

        Console.WriteLine();
        Console.WriteLine("The binary number represented as hexadecimal number is: ");
        Console.WriteLine(" {0} = {1} \n", number, hexadecimal);
    }
}
