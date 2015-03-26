using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
    public class School
    {
        // fields
        private ICollection<ClassOfStudents> classes; // using ICollection<T> we ensure higher level of abstraction
        // since in a school there could be more than one class, we have a collection to keep all the classes of the current school

        // consturctors
        public School()
        {
            this.classes = new List<ClassOfStudents>();
        }

        // properties
        
        // the property will return a copy of our classes field, but the user won't be able to make any changes on the field itself
        public ICollection<ClassOfStudents> Classes
        {
            get { return new List<ClassOfStudents>(this.classes); }
        }

        public ClassOfStudents ClassOfStudents
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

        // this method allow us to add new classes to the collection of classes
        public void AddClass(ClassOfStudents newClass)
        {
            this.classes.Add(newClass);
        }

        public override string ToString()
        {
            StringBuilder schoolSb = new StringBuilder();

            foreach (var currentClass in classes)
            {
                schoolSb.Append(currentClass);
                schoolSb.Append(Environment.NewLine);
            }

            return schoolSb.ToString();
        }
    }
}
