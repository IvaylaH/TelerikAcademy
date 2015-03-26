/*Write a program that prints an isosceles triangle of 9 copyright symbols ©. Use Windows Character Map to find the Unicode code of the © symbol. Note: the © symbol may be displayed incorrectly.*/

using System;

class CopyrightTriangle
{
    static void Main()
    {
        // I have used 2 different ways of priting the triangle. This is the first one:
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        char copySym = '\u00A9';

        Console.WriteLine(" " + "   {0}   ", copySym);
        Console.WriteLine(" " + "  {0} {0}  ", copySym);
        Console.WriteLine(" " + " {0} {0} {0} ", copySym);
        Console.WriteLine(" " + "{0}  {0}  {0}\n", copySym);

        // This is the second one:
        Console.WriteLine("Please enter a symbol of your choice.");
        string symbol = Console.ReadLine();
        char copySymbol = char.Parse(symbol);

        Console.WriteLine("  " + "  {0}", copySymbol);
        Console.WriteLine("  " + " {0}{0}{0}", copySymbol);
        Console.WriteLine("  " + "{0}{0}{0}{0}{0} ", copySymbol);
    }
}
