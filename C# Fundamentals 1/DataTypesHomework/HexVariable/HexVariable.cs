/*Declare an integer variable and assign it with the value 254 in hexadecimal format. Use Windows Calculator to find its hexadecimal representation.*/

using System;
class HexVariable
{
    static void Main()
    {
        int firstValue = 254;
        int secondValue = 256;
        int hexInt = 0x000FE;
        int secondHex = 0x00100;

        Console.WriteLine(hexInt);
        Console.WriteLine(secondHex + "\n");
        Console.WriteLine("0x000FE in decimal format is {0}", hexInt);
        Console.WriteLine("0x00100 in decimal format is {0}\n", secondHex);

        // here I decided to use a formatting string and check if it will convert the number from decimal to hexadecimal number
        Console.WriteLine("{0} in hexadecimal format is: {0:x5}", firstValue);
        Console.WriteLine("{0} in hexadecimal format is: {0:x5}\n", secondValue);
    }
}
