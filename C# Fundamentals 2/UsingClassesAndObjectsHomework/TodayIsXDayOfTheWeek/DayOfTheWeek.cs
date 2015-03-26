/* Write a program that prints to the console which day of the week is today. Use System.DateTime.*/

using System;
using System.Collections.Generic;
using System.Text;

class DayOfTheWeek
{
    static void Main()
    {
        DayOfWeek today = new DayOfWeek();
        today = DateTime.Today.DayOfWeek;

        Console.Write("Today is: ");

        Console.BackgroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine(today);

        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine();
    }
}
