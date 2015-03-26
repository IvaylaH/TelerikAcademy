using System;
using System.Text;

namespace SoftwareAcademy
{
 /*   public class LocalCourse : Course, ILocalCourse
    {
        // fields
        private string lab;

        // constructors
        public LocalCourse(string coursesName, string coursesLab)
            : base(coursesName)
        {
            this.Lab = coursesLab;
        }

        public LocalCourse(string coursesName, ITeacher coursesTeacher, string coursesLab)
            : base(coursesName, coursesTeacher)
        {
            this.Lab = coursesLab;
        }

        // properties
        public string Lab
        {
            get { return this.lab; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The value we set for the lab cannot be null or empty!");
                }

                this.lab = value;
            }
        }

        public override string ToString()
        {
            StringBuilder coursesInfo = new StringBuilder();

            coursesInfo.Append(string.Format("{0}: ", this.GetType().Name)); // or just Local
            coursesInfo.Append(base.ToString());
            coursesInfo.AppendLine(string.Format("Lab={0}", this.Lab));

            return coursesInfo.ToString();
        }
    }*/
}
