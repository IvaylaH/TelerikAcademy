using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractStudentsByGroupName
{
    public class Student
    {
        // constructors
        public Student(string name, int age, Group group)
        {
            this.FullName = name;
            this.Age = age;
            this.Group = group;
        }

        // properties
        public string FullName { get; set; }

        public int Age { get; set; }

        public Group Group { get; set; }


    }
}
