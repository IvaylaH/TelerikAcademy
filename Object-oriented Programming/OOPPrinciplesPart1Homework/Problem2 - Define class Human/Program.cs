using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem2_Define_classHuman
{
    class Program
    {
        static void Main()
        {
            // initializing a list of students
            List<Student> students = new List<Student>(); // List<Human> students = new List<Student>(); why I cannot do that 

            // filling the list with 10 instances of the class Student
            students.Add(new Student("Dragan", " Petrov", 1));
            students.Add(new Student("Ivan", " Pavlov", 12));
            students.Add(new Student("Stamat", " Iliev", 4));
            students.Add(new Student("Unufri", " Unufriev", 6));
            students.Add(new Student("Petar", " Petrov", 7));
            students.Add(new Student("Damyan", " Gruev", 7));
            students.Add(new Student("Pavel", " Atanasov", 3));
            students.Add(new Student("Nasko", " Angelov", 4));
            students.Add(new Student("Vasil", " Ivanov", 8));
            students.Add(new Student("Ivan", " Ilchev", 3));

            // initializing a list of workers
            List<Worker> workers = new List<Worker>();

            // filling the list with 10 instances of the Worker class
            workers.Add(new Worker("Vaskata", " Aprilov", 8.50M, 10M));
            workers.Add(new Worker("Vankata", " Vasilev", 6.50M, 8M));
            workers.Add(new Worker("Andrey", " Maslinkov", 10.50M, 11M));
            workers.Add(new Worker("Valq", " Victorova", 9.50M, 6M));
            workers.Add(new Worker("Victor", " Andreev", 12.00M, 8M));
            workers.Add(new Worker("Yosif", " Nenov", 11.50M, 9M));
            workers.Add(new Worker("Atanas", " Ivanov", 5.50M, 4M));
            workers.Add(new Worker("Ivan", " Petrov", 8.50M, 8M));
            workers.Add(new Worker("Andrey", " Ivankov", 6.50M, 10M));
            workers.Add(new Worker("Petkata", " Maslinkov", 9.50M, 9M));

            // printing the ordered list of Students
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Ordering the list of students using Linq:");

            var orderedStudents = OrderStudentsUsingLinq(students);
            PrintResults(orderedStudents);

            Console.Write(Environment.NewLine);

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Ordering the list of students using Linq:");

            orderedStudents = OrderStudentsUsingOrderBy(students);
            PrintResults(orderedStudents);

            // ordering and printing the list of workers
            OrderSWorkersUsingOrderBy(workers);

            OrderSWorkersUsingLinq(workers);

            // merging the list and sorting the content 
            MergeAndPrintTheTwoLists(students, workers);
        }

        // sorting the list of students using Linq
        public static IEnumerable<Student> OrderStudentsUsingLinq(IEnumerable<Student> students) // wonder why I cannot use ICollection instead of IEnumerable
        {
            var orderedList =
                from student in students
                orderby student.Grade ascending
                select student;

            return orderedList;
        }

        // sorting the list of students using OrderBy()
        public static IEnumerable<Student> OrderStudentsUsingOrderBy(IEnumerable<Student> students)
        {
            var orderedList = students.
                OrderByDescending(st => st.Grade);

            return orderedList;
        }

        // sorting the list of workers using Linq
        public static void OrderSWorkersUsingLinq(IEnumerable<Worker> workers)
        {
            var orderedList =
                from worker in workers
                orderby worker.MoneyPerHour() ascending
                select new { Name = worker.FirstName + " " + worker.LastName, HourlyPayment = string.Format("{0:f2}", worker.HourlyPayment) };

            Console.Write(Environment.NewLine);

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Ordering the list of workers using Linq:");

            Console.ResetColor();

            foreach (var worker in orderedList)
            {
                Console.WriteLine(worker);
            }
        }

        // sorting the list of workers using OrderBy()
        public static void OrderSWorkersUsingOrderBy(IEnumerable<Worker> workers)
        {
            var orderedList = workers.
                OrderByDescending(worker => worker.MoneyPerHour()).
                Select(worker => new { Name = worker.FirstName + " " + worker.LastName, HourlyPayment = string.Format("{0:f2}", worker.HourlyPayment) });

            Console.Write(Environment.NewLine);

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Ordering the list of workers using OrderBy():");

            Console.ResetColor();

            foreach (var worker in orderedList)
            {
                Console.WriteLine(worker);
            }
        }

        // merging the 2 lists and printing the result
        public static void MergeAndPrintTheTwoLists(List<Student> students, List<Worker> workers)
        {
            var mergedList = (students.Concat<Human>(workers).
                OrderBy(person => person.FirstName + person.LastName).
                Select(person => new { Name = person.FirstName + " " + person.LastName }));

            Console.Write(Environment.NewLine);

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Printing the merged and sorted list:");

            Console.ResetColor();

            foreach (var person in mergedList)
            {
                Console.WriteLine(person);
            }
        }

        // printing the results
        public static void PrintResults(IEnumerable<Human> collectionOfPeople)
        {
            Console.ResetColor();

            foreach (var person in collectionOfPeople)
	        {
                Console.WriteLine(person);
	        }
        }
    }
}
