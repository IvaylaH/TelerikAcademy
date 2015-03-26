/*A marketing firm wants to keep record of its employees. Each record would have the following characteristics – first name, family name, age, gender (m or f), ID number, unique employee number (27560000 to 27569999). Declare the variables needed to keep the information for a single employee using appropriate data types and descriptive names.*/

using System;

class FirmEmployees
{
    static void Main()
    {
        string firstName;
        string familyName;
        byte age;
        char gender;
        ulong idNum;
        uint uniEmployeeNum;

        firstName = "John";
        familyName = "Smith";
        age = 32;
        gender = 'm';
        idNum = 816235669;
        uniEmployeeNum = 27565300;

        Console.WriteLine("The current employee is: " + firstName + " " + familyName + ". Mr. " + familyName + " is " + age + " years old " + "and is male " + "(" + gender + "). His ID number is: " + idNum + " and his unique employee number is " + uniEmployeeNum + ".");
    }
}
