/* Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.*/

using System;
using System.Collections.Generic;
using System.Text;

class IfLeapYear
{  //the problem is solved in 2 different ways

    static bool CheckYear(int year)
    {
        bool isLeap = false;

        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            isLeap = true;
            return isLeap;
        }
        else
        {
            return isLeap;
        }
    }

    static void Main()
    {
        Console.WriteLine("Please enter an year of your choice and the program will check if it's leap, ");
        Console.Write("year = ");
        int year = int.Parse(Console.ReadLine());

        //first way - using DateTime.IsLeapYear()

        bool isLeap = DateTime.IsLeapYear(year);

        Console.WriteLine("\n --> First solution using DateTime.IsLeapYear(): ");
        Console.Write("Year {0} is a leap year: ", year);

        if (isLeap)            
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write(isLeap);
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write(isLeap);
        }

        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine();


        //second solution using my own method

        bool methodIsLeap = CheckYear(year);

        Console.WriteLine("\n --> Second solution using my own method: ");
        Console.WriteLine("Year {0} is a leap year: {1}", year, methodIsLeap);
        Console.WriteLine();
    }
}
