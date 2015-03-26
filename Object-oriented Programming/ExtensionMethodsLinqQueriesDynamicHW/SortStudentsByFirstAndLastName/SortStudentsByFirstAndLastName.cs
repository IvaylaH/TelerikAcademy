/* Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order. Rewrite the same with LINQ.*/

using System;
using System.Linq;

namespace SortStudentsByFirstAndLastName
{
    class SortStudentsByFirstAndLastName
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[] 
            {
                new Student ("Petar", "Petrov"),
                new Student ("Dragan", "Tsankov"),
                new Student ("Georgi", "Angelov"),
                new Student ("Petya", "Marinova"),
                new Student ("George", "Washington"),
                new Student ("Parvan", "Aprilov"),
                new Student ("Staman", "Borisov"),
                new Student ("Asparuh", "Nikolov"),
                new Student ("Nikodim", "Mechkov"),
                new Student ("Strashimir", "Qnev")
            };

            Console.WriteLine("Sorted in descending order using the extension methods OrderBy() and ThenBy() and lambdaExpressions: ");
            Console.Write(Environment.NewLine);

            SortUsingExtensionAndLambdaExp(students);

            Console.WriteLine("Sorted in ascending order using Linq:");
            Console.Write(Environment.NewLine);

            SortUsingLinq(students);
        }

        public static void SortUsingExtensionAndLambdaExp(Student[] students)
        {
            var sortedStudents = students.
            OrderByDescending(st => st.FirstName).
            ThenByDescending(st => st.LastName);

            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
        }

        public static void SortUsingLinq(Student[] students)
        {
            var sortedStudents =
                from student in students
                orderby student.FirstName ascending
                select student;

            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
        }
    }
}
