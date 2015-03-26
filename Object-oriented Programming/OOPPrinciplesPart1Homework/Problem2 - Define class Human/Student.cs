using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_Define_classHuman
{
    public class Student : Human
    {
        // fields
        private int grade;

        // constructors
        public Student(string firstName, string lastName, int currentGrade)
            : base(firstName, lastName)
        {
            this.Grade = currentGrade;
        }

        // properties
        public int Grade 
        {
            get { return this.grade; }
            private set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("The number entered for the class of the student must be in the range of [1, 12]!");
                }

                this.grade = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Student's name: {0}; Grade: {1}", this.FirstName + this.LastName, this.Grade);
        }
    }
}
