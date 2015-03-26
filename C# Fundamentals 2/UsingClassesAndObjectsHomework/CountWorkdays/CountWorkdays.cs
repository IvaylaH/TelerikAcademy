/* Write a method that calculates the number of workdays between today and given date, passed as parameter. Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.*/

using System;
using System.Collections.Generic;
using System.Text;

class CountWorkdays
{
    static int CalculateWorkDays(DateTime startDate, DateTime endDate)
    {
        int count = 0;
                                        //I have used http://почивнидни.com/ to find the official holidays and working Saturdays

        string[] officialHolidays = { "3/3/2014", "4/18/2014", "5/1/2014", "5/2/2014", "5/5/2014", "5/6/2014" };
        string[] workingSaturdays = { "5/10/2014", "5/31/2014" };

        string holidaysList = string.Join(" ", officialHolidays);

        while (startDate != endDate)
        {
            DayOfWeek today = startDate.DayOfWeek;
            bool isHoliday = holidaysList.Contains(startDate.ToShortDateString());

            if (!isHoliday && today != DayOfWeek.Saturday && today != DayOfWeek.Sunday)
            {
                count++;
            }

            startDate = startDate.AddDays(1);
        }

        count += workingSaturdays.Length;

        return count;
    }
    static void Main()
    {
        DateTime day = DateTime.Now.Date;
        DateTime endDate = new DateTime(2014, 6, 01);

        int daysCount = CalculateWorkDays(day, endDate);

        Console.WriteLine("There are {2} working days between {0} and {1} ", day.ToShortDateString(), endDate.ToShortDateString(), daysCount);
        Console.WriteLine();
    }
}
