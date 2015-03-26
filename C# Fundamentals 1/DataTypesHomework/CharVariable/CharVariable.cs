/*Declare a character variable and assign it with the symbol that has Unicode code 72. Hint: first use the Windows Calculator to find the hexadecimal representation of 72.*/

using System;

class CharVariable
{
    static void Main()
    {
        int uniInt = 72;
        char chUni = (char)uniInt;
        char chHex = '\u0048';

        Console.WriteLine("The character we are looking for is: " + chUni);
        Console.WriteLine("The character we are looking for is: " + chHex);

    }
}

