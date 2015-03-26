using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
    public class ClassOfStudents : OptionalComments
    {
        // fields
        private string uniqueTextID;
        private ICollection<Teacher> teachers;
        private ICollection<Student> students;

        // constructors
        public ClassOfStudents(string textId)
        {
            this.uniqueTextID = textId;
            this.teachers = new List<Teacher>();
            this.students = new List<Student>();
        }

        //properties
        public string UniqueTextId
        {
            get { return this.uniqueTextID; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Disciplines' unique text identifier cannot be empty!");
                }

                this.uniqueTextID = value;
            }
        }

        // using the 2 properties make sure that no one will be able to change the values in our Collection
        public ICollection<Teacher> Teachers 
        {
            get { return new List<Teacher>(this.teachers); }
        }

        public ICollection<Student> Students 
        {
            get { return new List<Student>(this.students); }
        }

        public Teacher Teacher
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Student Student
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        // methods

        // using these 2 methods we can easily add new elements of type Student and/or Teacher to their respective sets 
        public void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }

        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }

        public override string ToString()
        {
            StringBuilder classSb = new StringBuilder();

            classSb.AppendFormat("{0} info", this.UniqueTextId);
            classSb.Append(Environment.NewLine);

            classSb.AppendFormat("Class teachers: ");
            classSb.Append(Environment.NewLine);

            foreach (var teacher in teachers)
            {
                classSb.AppendFormat("{0}", teacher);
                classSb.Append(Environment.NewLine);
            }

            classSb.AppendFormat("Students: ");
            classSb.Append(Environment.NewLine);

            foreach (var student in students)
            {
                classSb.AppendFormat("{0}", student);
                classSb.Append(Environment.NewLine);
            }

            return classSb.ToString();
        }
    }
}
