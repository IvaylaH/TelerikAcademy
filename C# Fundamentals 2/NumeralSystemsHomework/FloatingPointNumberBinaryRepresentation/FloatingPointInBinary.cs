/* *Write a program that shows the internal binary representation of given 32-bit signed floating-point number in IEEE 754 format (the C# type float). Example: -27,25  sign = 1, exponent = 10000011, mantissa = 10110100000000000000000.*/

using System;
using System.Collections.Generic;
using System.Text;

class FloatingPointInBinary
{
    static string GetBits(char hexValue)   //finding the bits representation corresponding to the hex numbers we have found
    {
        string bits = string.Empty;

        switch (hexValue)
        {
            case '0': return bits = "0000";
            case '1': return bits = "0001";
            case '2': return bits = "0010";
            case '3': return bits = "0011";
            case '4': return bits = "0100";
            case '5': return bits = "0101";
            case '6': return bits = "0110";
            case '7': return bits = "0111";
            case '8': return bits = "1000";
            case '9': return bits = "1001";
            case 'A': return bits = "1010";
            case 'B': return bits = "1011";
            case 'C': return bits = "1100";
            case 'D': return bits = "1101";
            case 'E': return bits = "1110";
            case 'F': return bits = "1111";
            default: return bits = "";
        }
    }

    static string GetBytes(float number)            //find the bytes of the number represented as numbers in hexadecimal numeral
    {                                                                                                           //system
        byte[] bytesArr = BitConverter.GetBytes(number);
        Array.Reverse(bytesArr);
        string bytesToStr = BitConverter.ToString(bytesArr);

        return bytesToStr;
    }
    static void Main()
    {
        Console.WriteLine("PLease enter a 32-bit signed floating-point number of your choice, ");
        Console.Write("number = ");
        float number = float.Parse(Console.ReadLine());

        string bytesInHex = GetBytes(number);
        List<string> bits = new List<string>();

        for (int i = 0; i < bytesInHex.Length; i++)
        {
            bits.Add(GetBits(bytesInHex[i]));
        }

        string bitsToStr = string.Join("", bits);

        Console.WriteLine("\nThe binary representation of number {0} has the following elements: ", number);

        for (int i = 0; i < bitsToStr.Length; i++) //printing the result; each element printed of separate line
        {
            if (i == 0)
            {
                Console.WriteLine("sign = {0}", bitsToStr[i]);
                Console.Write("exponent = ");
            }
            else if (i == 9)
            {
                Console.WriteLine();
                Console.Write("mantissa = {0}", bitsToStr[i]);
            }
            else
            {
                Console.Write(bitsToStr[i]);
            }
        }

        Console.WriteLine();
    }
}
