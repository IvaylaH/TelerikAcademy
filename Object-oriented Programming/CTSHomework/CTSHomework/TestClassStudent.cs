using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_1To3
{
    public class TestClassStudent
    {
        static void Main()
        {
            Student firstStudent = new Student("Ivan", "Draganov", "Petkov", "639251780", "home address", "1020324020", "myEmail@gbg.bg", 3, Specialties.ASP_NET_Web_Developer, Faculties.Informatics, Universities.Telerik_Academy);

            Console.WriteLine(firstStudent);

            Student secondStudent = new Student("Petar", "Ivanov", "Petrov", "1478529631", "private address", "3698521470", "student@gbg.bg", 5, Specialties.Web_Designer, Faculties.Arts, Universities.NBU);

            int equalityValue = firstStudent.CompareTo(secondStudent);

            if (equalityValue == 0)
            {
                Console.WriteLine("The 2 students are equal!");
            }
            else if (equalityValue < 0)
            {
                Console.WriteLine("The first student is before the second one!");
            }
            else
            {
                Console.WriteLine("The second student is before the first one!");
            }

            Student clonedStudent = secondStudent.Clone() as Student;
            clonedStudent.LastName = "Shishkov";

            Console.WriteLine();
            Console.WriteLine(clonedStudent);
            Console.WriteLine("{0} {1} {2}", secondStudent.FirstName, secondStudent.MiddleName, secondStudent.LastName);
        }
    }
}
