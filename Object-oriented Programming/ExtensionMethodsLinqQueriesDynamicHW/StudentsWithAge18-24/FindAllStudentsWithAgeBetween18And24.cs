/* Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.*/

using System;
using System.Linq;

namespace StudentsWithAge18_24
{
    class FindAllStudentsWithAgeBetween18And24
    {
        static void Main()
        {
            Student[] students = new Student[]
            {
                new Student ("Petar", "Petrov", 19),
                new Student ("Dragan", "Tsankov", 25),
                new Student ("Georgi", "Angelov", 23),
                new Student ("Petya", "Marinova", 18),
                new Student ("George", "Washington", 30)
            };

            var listOfStudents = students.
                Where(st => st.Age >= 18 && st.Age <= 24);

            foreach (var student in listOfStudents)
            {
                Console.WriteLine("Name: {0}; Age: {1}", student.FirstName + " " + student.LastName, student.Age );
            }
        }
    }
}
