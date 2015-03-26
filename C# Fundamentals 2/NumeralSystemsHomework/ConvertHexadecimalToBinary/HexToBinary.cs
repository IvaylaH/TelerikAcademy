/* Write a program to convert hexadecimal numbers to binary numbers (directly).*/

using System;
using System.Collections.Generic;
using System.Text;

class HexToBinary
{
    static string FindBitsInNumber(char element)
    {
        switch(element)
        {
            case '0': return "0000";
            case '1': return "0001";
            case '2': return "0010";
            case '3': return "0011";
            case '4': return "0100";
            case '5': return "0101";
            case '6': return "0110";
            case '7': return "0111";
            case '8': return "1000";
            case '9': return "1001";
            case 'A': return "1010";
            case 'B': return "1011";
            case 'C': return "1100";
            case 'D': return "1101";
            case 'E': return "1110";
            default: return "1111";
        }
    }

    static string ConvertToBinary(string hexadecimal)
    {

        List<string> binNumber = new List<string>();

        for (int i = 0; i < hexadecimal.Length; i++)
        {
            binNumber.Add(FindBitsInNumber((char)hexadecimal[i]));   
        }

        string binNumToStr = string.Join(" ", binNumber);

        return binNumToStr;
    }
    static void Main()
    {
        Console.WriteLine("Please enter the hexadecimal number you would like to convert to binary number, ");
        Console.Write("number = ");
        string hexNumber = Console.ReadLine();

        hexNumber = hexNumber.ToUpper();
        string binaryNumber = ConvertToBinary(hexNumber);

        Console.WriteLine("The binary representation of the hexadecimal number is: ");
        Console.Write(" {0} = ", hexNumber);

        int leadingZeros = 32 - (4 * hexNumber.Length + 1); //finding the leading zeros to add to the binary number
        int count = 1;

        while (leadingZeros > -1)   //printing the leading zeros in groups for 4 so it would be easier to read the binary number
        {
            if (count != 4)
            {
                Console.Write("0");
                count++;
            }
            else
            {
                Console.Write("0 ");
                count = 1;
            }

            leadingZeros--;
        }
        Console.Write(binaryNumber);        //finally printing the '1' and '0' of the converted number
        Console.WriteLine("\n");
    }
}
