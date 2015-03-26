using System;
using System.Collections.Generic;
using System.Text;

namespace SelectTheStudentsFromGroup2
{
    public class Student
    {
        // constructors
        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Student(string firstName, string lastName, string facultyNumber)
            : this(firstName, lastName)
        {
            this.FN = facultyNumber;
        }

        public Student(int groupNumber, string firstName, string lastName)
            : this(firstName, lastName)
        {
            this.GroupNumber = groupNumber;
        }

        public Student(string firstName, string lastName, int groupNumber, string email)
            : this(groupNumber, firstName, lastName)
        {
            this.Email = email;
        }

        public Student(string firstName, string lastName, string facultyNumber, List<int> marks, Group group)
            : this(firstName, lastName, facultyNumber)
        {
            this.Marks = marks;
            this.Group = group;
        }

        public Student(string firstName, string lastName, string facultyNumber, string telNumber, string email, List<int> marks, Group group)
            : this(firstName, lastName, facultyNumber, marks, group)
        {
            this.Tel = telNumber;
            this.Email = email;
        }

        // properties
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FN { get; set; }

        public string Tel { get; set; }

        public string Email { get; set; }

        public List<int> Marks { get; set; }

        public int GroupNumber { get; set; }

        public Group Group { get; set; }

        // methods

        // check if a certain mark is found exactly x times in the Mark property of the instance
        public bool CountMarks(int searchedMark, int count)
        {
            int counter = 0;

            foreach (var mark in this.Marks)
            {
                if (mark == searchedMark)
                {
                    counter++;
                }
            }

            return counter == count ? true : false;
        }

        // using the returned string for problem 13. so I can print the makrs of the students
        public string GetMarks()
        {
            return string.Join(" ", this.Marks);
        }

        public override string ToString()
        {
            StringBuilder studentSb = new StringBuilder();

            studentSb.AppendFormat("Name: {0} {1}; ", this.FirstName, this.LastName);
            studentSb.AppendFormat("FN: {0}; ", this.FN);
            studentSb.AppendFormat("Tel: {0}; ", this.Tel);
            studentSb.AppendFormat("Email: {0}; ", this.Email);
            studentSb.Append("Marks: ");

            foreach (var mark in this.Marks)
            {
                studentSb.AppendFormat("{0} ", mark);
            }

            studentSb.AppendFormat("Group number: {0}; ", this.Group.GroupNumber);
            studentSb.AppendFormat("Department name: {0}.", this.Group.DepartmentName);
            studentSb.Append(Environment.NewLine);

            return studentSb.ToString();
        }
    }
}
