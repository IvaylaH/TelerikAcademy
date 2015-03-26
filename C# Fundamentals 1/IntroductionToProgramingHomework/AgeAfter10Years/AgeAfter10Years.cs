/*Write a program to read your age from the console and print how old you will be after 10 years.*/

using System;

    class AgeAfter10Years
    {
        static void Main()
        {
            Console.WriteLine("Please enter your current age.");
            int age = int.Parse(Console.ReadLine());
            int ageAfterTenYears = age + 10;

            Console.WriteLine("Your current age is: {0}. In 10 years you will be: {1}. \nThat's All Folks!", age, ageAfterTenYears);
        }
    }
