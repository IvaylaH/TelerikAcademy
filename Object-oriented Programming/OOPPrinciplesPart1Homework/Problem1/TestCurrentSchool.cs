using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    public class TestCurrentSchool
    {
        public static void Main()
        {
            School mySchool = new School();

            // creating some classes
            ClassOfStudents firstA = new ClassOfStudents("1A");
            ClassOfStudents firstB = new ClassOfStudents("1B");

            // adding some classes to our school
            mySchool.AddClass(firstA);
            mySchool.AddClass(firstB);
            mySchool.AddClass(new ClassOfStudents("1C"));

            // creating some teacher objects
            Teacher mathTeacher = new Teacher("Dragan Petkov");
            Teacher englishTeacher = new Teacher("MitetY Andreev");
            Teacher physicsTeacher = new Teacher("Atom Protonov");

            Student firstStudent = new Student("Pesho Ivanov", 17);
            Student secondStudent = new Student("Valeri Ivanov", 4);

            // adding some teachers and students to our class
            firstA.AddTeacher(mathTeacher);
            firstA.AddTeacher(englishTeacher);
            firstB.AddTeacher(physicsTeacher);

            firstA.AddStudent(new Student("Ivan Ivanov", 5));
            firstB.AddStudent(firstStudent);
            firstB.AddStudent(secondStudent);

            // creating a list of all the disciplines studied in the current school
            List<Discipline> allDisciplines = new List<Discipline>();
            allDisciplines.Add(new Discipline("Mathematics", 45, 15));
            allDisciplines.Add(new Discipline("English", 150, 100));
            allDisciplines.Add(new Discipline("Arts", 45, 150));
            allDisciplines.Add(new Discipline("Physics", 45, 15));
            allDisciplines.Add(new Discipline("Literature", 45, 15));

            // adding disciplines to teacher's sets
            mathTeacher.AddDiscipline(allDisciplines[0]);
            mathTeacher.AddDiscipline(allDisciplines[3]);

            physicsTeacher.AddDiscipline(allDisciplines[0]);
            physicsTeacher.AddDiscipline(allDisciplines[3]);

            englishTeacher.AddDiscipline(allDisciplines[1]);
            englishTeacher.AddDiscipline(allDisciplines[2]);
            englishTeacher.AddDiscipline(allDisciplines[4]);

            // adding some comments
            mathTeacher.AddComment("Classes, ah? I love them!");
            secondStudent.AddComment("The math teacher must be crazy?!?");
            allDisciplines[2].AddComment("Classes, why does everyone talk about classes?");
            firstB.AddComment("Classes? Did someone say classes? Wait, I am a class of students! Sir, wait, your class is coming! ");


            // printing an object of type Teacher
            Console.WriteLine(englishTeacher);

            // printing an object of type Student
            Console.WriteLine(firstStudent);

            // printing an object
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(firstA);

            // printing comment
            Console.WriteLine("Checking if the comments class is working properly: ");
            Console.BackgroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine(mathTeacher.Comment);
            Console.WriteLine(secondStudent.Comment);
            Console.WriteLine(allDisciplines[2].Comment);
            Console.WriteLine(firstB.Comment);

            Console.ResetColor();

            // printing the instance of class School

            Console.Write(Environment.NewLine);
            Console.BackgroundColor = ConsoleColor.DarkGreen;
           
            Console.WriteLine("Printing school info:");
            Console.ResetColor();
            Console.WriteLine(mySchool);

        }
    }
}
