/*Create a console application that prints the current date and time.*/

using System;

    class CurrentDateTime
    {
        static void Main()
        {
           string dateOnly = DateTime.Today.ToShortDateString();
           string timeOnly = DateTime.Now.ToShortTimeString();
            
            Console.WriteLine("Today is " + dateOnly + " and it is already " + timeOnly + ".");
        }
    }