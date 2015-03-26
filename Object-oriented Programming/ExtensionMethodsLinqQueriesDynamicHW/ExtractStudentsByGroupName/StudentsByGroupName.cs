/* Create a program that extracts all students grouped by GroupName and then prints them to the console. Use LINQ.*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtractStudentsByGroupName
{
    public class StudentsByGroupName
    {
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student("Petar Petrov", 20, new Group (3, "The Cool Group", "The Cool Department")),
                new Student("Ivan Georgiev", 25, new Group (2, "Boy's Group", "Common Department")),
                new Student("Georgi Ivanov", 19, new Group (1, "The NewComer's Group", "NewComers Department")),
                new Student("Valya Atanasova", 23, new Group (4, "Girl's Group", "Uncommon Department")),
                new Student("Valeri Valchev", 29, new Group (2, "Boy's Group", "Common Department")),
                new Student("Anna Apostolova", 18, new Group (4, "Girl's Group", "Uncommon Department"))
            };

            Console.WriteLine("Problem 18. solved using Linq: ");
            GroupUsingLinq(students);

            Console.WriteLine("Problem 19. solved using extension methods and lambda expressions: ");
            GroupUsingExtMethodsAndLambdaExp(students);
        }

        public static void GroupUsingExtMethodsAndLambdaExp(List<Student> students)
        {
            var foundGroups =
                from student in students
                group student by student.Group.GroupName into stGroup
                orderby stGroup.Key
                select stGroup;
           
            foreach (var group in foundGroups)
            {
                Console.Write(group.Key);

                foreach (var student in group)
                {
                    Console.Write(" " + student.FullName + " ");
                }

                Console.WriteLine();
            }
        }

        public static void GroupUsingLinq(List<Student> students)
        {
            var foundGroups = students.GroupBy(st => st.Group.GroupName).OrderBy(st => st.Key);

            foreach (var group in foundGroups)
            {
                Console.WriteLine(group.Key);

                foreach (var student in group)
                {
                    Console.Write(student.FullName + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
