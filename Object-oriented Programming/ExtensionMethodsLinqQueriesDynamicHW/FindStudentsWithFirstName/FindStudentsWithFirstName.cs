/* Write a method that from a given array of students finds all students whose first name is before its last name alphabetically. Use LINQ query operators.*/

using System;
using System.Linq;

namespace FindStudentsWithFirstName
{
    public class FindStudentsWithFirstName
    {
        static void Main()
        {
            Student[] studentsArr = new Student[] 
            {
                new Student ("Petar", "Petrov"),
                new Student ("Dragan", "Tsankov"),
                new Student ("Georgi", "Angelov"),
                new Student ("Petya", "Marinova"),
                new Student ("George", "Washington")
            };

            FindAndPrintStudents(studentsArr);
        }

        public static void FindAndPrintStudents(Student[] students)
        {
            var listOfStudents = students.
                Where(st => st.FirstName.CompareTo(st.LastName) < 0);

            foreach (var student in listOfStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
        }
    }
}
