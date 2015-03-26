using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem1
{
    public class Student : Person
    {
        // fields
        private int uniqueClassNumber;

        // constructors
        public Student(string studentName, int classNumber)
            : base(studentName)
        {
            this.UniqueClassNumber = classNumber;
        }

        // properties
        public int UniqueClassNumber 
        {
            get { return this.uniqueClassNumber; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The class number of the student cannot be '0' or a negative number!");
                }

                this.uniqueClassNumber = value;
            }
        }

        // methods 
        public override string ToString()
        {
            return string.Format("Name: {0}; Class number: {1}", this.Name, this.UniqueClassNumber);
        }
    }
}
