/*Create console application that prints your first and last name.*/

using System;
   class FirstAndLastName
    {
        static void Main()
        {
            string firstName = "Peter";
            string lastName = "Petrov";
            string fullName = firstName + " " + lastName;

            Console.WriteLine(firstName + ". " + fullName + ". " + "Nice to meet you!" );
        }
    }
