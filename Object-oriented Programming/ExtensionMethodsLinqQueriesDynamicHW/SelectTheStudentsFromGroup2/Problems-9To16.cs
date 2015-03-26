using System;
using System.Collections.Generic;
using System.Linq;

namespace SelectTheStudentsFromGroup2
{
    public class Problems
    {
        static void Main()
        {
            List<Student> students = new List<Student> {
             
                new Student ("Asparuh", "Nikolov", "131451", "02 915 17", "mail@abv.bg", new List<int>{ 2, 2, 6, 4, 6, 5 }, new Group (2 , "Informatics")),
                new Student ("Penko", "Georgiev", "321406", "02 951 97", "mail@gmail.com", new List<int>{ 6, 6, 5, 3 }, new Group (1, "Applied Science")),
                new Student ("Pavla", "Petrova", "169718", "02 938 34", "mail@abv.bg", new List<int>{ 6, 2, 3, 4, 5 }, new Group (4, "Physics")),
                new Student ("Ivan", "Ivanov", "987123", "038 635 218", "mail@gbg.bg", new List<int>{ 5, 5, 6, 4, 6 }, new Group (3, "Mathematics")),
                new Student ("Qnko", "Nikiforov", "147806", "032 355 617", "mail@yahoo.co.uk", new List<int>{ 2, 3, 4, 5, 6 }, new Group (2, "Informatics")),
                new Student ("Ivan", "Borisov", "346512", "02 991 71", "mail@telerikacademy.com", new List<int>{ 5, 4, 6 }, new Group (3, "Mathematics"))
            };

            List<Group> severalGroups = new List<Group>{
                new Group (2, "Informatics"),
                new Group (3, "Mathematics"),
                new Group (1, "Applied Science"),
                new Group (4, "Physics"),
                new Group (5, "Bionlogy")
            };

            // 09. Create a class student with properties FirstName, LastName, FN, Tel, Email, Marks (a List<int>), GroupNumber. Create a List<Student> with sample students. Select only the students that are from group number 2. Use LINQ query. Order the students by FirstName.
            FindStudentsFromGroup2UsingLinq(students);

            // 10. Implement the previous using the same query expressed with extension methods.
            FindStudentsFromGroup2UsingExtMethodsAndLambdaExp(students);

            // 11. Extract all students that have email in abv.bg. Use string methods and LINQ.
            ExtractStudentsWithEmail(students);

            // 12. Extract all students with phones in Sofia. Use LINQ.
            ExtractStudentsWithPhones(students);

            // 13. Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks. Use LINQ.
            ExtractStudentsWithOneExcellentMark(students);

            // 14. Write down a similar program that extracts the students with exactly  two marks "2". Use extension methods.
            ExtractStudentsWithTwo2s(students);

            // 15. Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
            ExtractAllMarksOfStudentsEnrolledIn06(students);

            // 16. * Create a class Group with properties GroupNumber and DepartmentName. Introduce a property Group in the Student class. Extract all students from "Mathematics" department. Use the Join operator.
            ExtractStudentsFromMathDepartmentUsingLinq(students, severalGroups);
        }

        // Problem 09.
        public static void FindStudentsFromGroup2UsingLinq(List<Student> students)
        {
            var foundStudents =
                from student in students
                where student.Group.GroupNumber == 2
                orderby student.FirstName
                select student;

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Problem 09. solved using Linq: ");

            PrintResult(foundStudents);
        }

        // Problem 10.
        public static void FindStudentsFromGroup2UsingExtMethodsAndLambdaExp(List<Student> students)
        {
            var foundStudents = students.
               Where(st => st.Group.GroupNumber == 2).
               OrderBy(st => st.FirstName).
               ThenBy(st => st.LastName);

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Problem 10. solved using extension methods and lambda expressions: ");

            PrintResult(foundStudents);
        }

        // Problem 11. 
        public static void ExtractStudentsWithEmail(List<Student> students)
        {
            var foundStudents = students.
                Where(st => st.Email.Contains("@abv.bg"));

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Problem 11. solved using string.Contains(): ");

            PrintResult(foundStudents);
        }

        // I wrote this method as an exercise, it is not implemented in the Main() of the program
        public static void ExtractStudentsWithEmailUsingLinq(List<Student> students)
        {
            var foundStudents =
                from student in students
                where student.Email.Contains("@abv.bg")
                select student;
        }

        // Problem 12.
        public static void ExtractStudentsWithPhones(List<Student> students)
        {
            var foundStudents = students.
                Where(st => st.Tel.StartsWith("02"));

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Problem 12. solved using string.StartsWith(): ");

            PrintResult(foundStudents);
        }

        // I wrote this method as an exercise, it is not implemented in the Main() of the program
        public static void ExtractStudentsWithPhonesUsingLinq(List<Student> students)
        {
            var foundStudents =
                from student in students
                where student.Tel.StartsWith("02")
                select student;
        }

        // Problem 13.
        public static void ExtractStudentsWithOneExcellentMark(List<Student> students)
        {
            var foundStudents = students.
                Where(st => st.Marks.Contains(6)).
                Select(st => new { FullName = st.FirstName + " " + st.LastName, Marks = st.GetMarks() });

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Problem 13. solved using List<int>.Contains(): ");

            Console.ResetColor();
            Console.Write(Environment.NewLine);

            foreach (var student in foundStudents)
            {
                Console.WriteLine(student.ToString());
            }
        }

        // I wrote this method as an exercise, it is not implemented in the Main() of the program
        public static void ExtractStudentsWithOneExcellentMarkUsingLinq(List<Student> students)
        {
            var foundStudents =
                from student in students
                where student.Marks.Contains(6)
                select new { FullName = student.FirstName + " " + student.LastName, Marks = student.GetMarks() };
        }


        // Problem 14.
        public static void ExtractStudentsWithTwo2s(List<Student> students)
        {
            int count = 2;
            int searchedMark = 2;

            var foundStudents = students.
                Where(st => st.CountMarks(searchedMark, count) == true).
                Select(st => new { FullName = st.FirstName + " " + st.LastName, Marks = st.GetMarks() });

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Problem 14. solved using the custom method CountMarks(): ");

            Console.ResetColor();
            Console.Write(Environment.NewLine);

            foreach (var student in foundStudents)
            {
                Console.WriteLine(student.ToString());
            }
        }

        // I wrote this method as an exercise, it is not implemented in the Main() of the program
        public static void ExtractStudentsWithTwo2sUsingLinq(List<Student> students)
        {
            int count = 2;
            int searchedMark = 2;

            var foundStudents =
                from student in students
                where student.CountMarks(searchedMark, count) == true
                select new { FullName = student.FirstName + " " + student.LastName, Marks = student.GetMarks() };
        }

        // Problem 15.
        public static void ExtractAllMarksOfStudentsEnrolledIn06(List<Student> students)
        {
            var foundStudents = students.
                Where(st => st.FN.EndsWith("06")).
                Select(st => new { FullName = st.FirstName + " " + st.LastName, FN = st.FN, Marks = st.GetMarks() });

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Problem 15. solved using string.EndsWith(): ");

            Console.ResetColor();
            Console.Write(Environment.NewLine);

            foreach (var student in foundStudents)
            {
                Console.WriteLine(student.ToString());
            }
        }

        // I wrote this method as an exercise, it is not implemented in the Main() of the program
        public static void ExtractAllMarksOfStudentsEnrolledIn06UsingLinq(List<Student> students)
        {
            var foundStudents = 
                from student in students
                where student.FN.EndsWith("06")
                select new  { FullName = student.FirstName + " " + student.LastName, FN = student.FN, Marks = student.GetMarks() };
        }

        // Problem 16.
        // TODO: rewrite the problem using extension methods and lambda expressions
        public static void ExtractStudentsFromMathDepartmentUsingLinq(List<Student> students, List<Group> groups)
        {
            var foundStudents =                                     
                from student in students
                join gr in groups
                     on student.Group.DepartmentName equals gr.DepartmentName
                     where student.Group.DepartmentName == "Mathematics"
                select new { FullName = student.FirstName + " " + student.LastName, FN = student.FN, GroupNumber = gr.GroupNumber, Department = gr.DepartmentName };

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Problem 16. solved using Linq and join: ");

            Console.ResetColor();
            Console.Write(Environment.NewLine);

            foreach (var student in foundStudents)
            {
                Console.WriteLine(student.ToString());
            }
        }

        // printing the result from each method
        public static void PrintResult(IEnumerable<Student> students)
        {
            Console.ResetColor();
            Console.Write(Environment.NewLine);

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
