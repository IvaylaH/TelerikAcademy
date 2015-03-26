/* Write a program to convert decimal numbers to their binary representation.*/

using System;
using System.Collections.Generic;
using System.Text;

class DecimalToBinary
{
    static string ConvertToBinary(int decNumber)
    {
        StringBuilder binaryNum = new StringBuilder();

        int remainder = decNumber % 2;
        decNumber /= 2;

        binaryNum.Append(remainder);    //I use the StringBuilder to keep the remainders (the bits of the number)

        while (decNumber != 0)
        {
            remainder = decNumber % 2;
            decNumber /= 2;

            binaryNum.Append(remainder);
        }

        string result = binaryNum.ToString();   //convert the StringBuilder to string and return the string as a result from
                                                //the execution of the method
        return result;
    }

    static void Main()
    {
        Console.WriteLine("Please enter a decimal number of your choice, ");
        Console.Write("number = ");

        int number = int.Parse(Console.ReadLine());
        string binNumber = ConvertToBinary(number);
        int leadingZeros = 32 - binNumber.Length;       //this var will keep the number of leading zeros I need the add

        //first solution - converting the number using my own method: 

        Console.WriteLine();
        Console.WriteLine(new string('-', 15) + " First solution using my own method " + new string('-', 15));
        Console.WriteLine("The binary representation of the decimal number {0} is:", number);

        while (leadingZeros > 0)            //prints the leading zeros and then...
        {
            Console.Write("0 ");
            leadingZeros--;
        }

        for (int i = binNumber.Length - 1; i > -1; i--)
        {
            Console.Write("{0} ", binNumber[i]);        //... prints the elements of the string in reversed order 
        }

        Console.WriteLine();

        //second way - using convert.ToString

        string binaryNum = Convert.ToString(number, 2).PadLeft(32, '0');

        Console.WriteLine();
        Console.WriteLine(new string('-', 15) + " Second solution using Convert.ToString " + new string('-', 15));
        Console.WriteLine("The binary representation of the decimal number {0} is: ", number);
        Console.WriteLine("{0} ",  binaryNum);
    }
}
