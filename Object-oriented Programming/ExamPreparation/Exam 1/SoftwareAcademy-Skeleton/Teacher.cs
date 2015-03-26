using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SoftwareAcademy
{
 /*   public class Teacher : ITeacher
    {
        // fields
        private string name;
        private IList<ICourse> courses;

        // constructors
        public Teacher(string inputName)
        {
            this.Name = inputName;
            this.courses = new List<ICourse>();
        }

        // properties
        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name of the teacher cannot be null!");
                }

                this.name = value;
            }
        }

        public IList<ICourse> Courses // can I leave it IEnumerable<ICourse> here
        {
            get { return new List<ICourse>(this.courses); }
        }

        // methods
        public void AddCourse(ICourse course)
        {
            this.courses.Add(course);
        }

        public override string ToString()
        {
            StringBuilder teachersInfo = new StringBuilder();

            teachersInfo.Append(string.Format("Teacher: Name={0}", this.Name)); // Append or AppendLine

            if (this.courses.Count != 0)
            {
                string coursesToStr = string.Join(", ", this.courses.Select(c => c.Name));
                teachersInfo.Append(string.Format("; Courses=[{0}]", coursesToStr));
            }

            return teachersInfo.ToString();
        }
    }*/
}
