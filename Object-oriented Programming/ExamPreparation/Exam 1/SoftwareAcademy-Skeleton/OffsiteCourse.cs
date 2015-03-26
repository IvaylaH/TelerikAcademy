using System;
using System.Text;

namespace SoftwareAcademy
{
  /*  public class OffsiteCourse : Course, IOffsiteCourse
    {
        // fields
        private string town;

        // constructors
        public OffsiteCourse(string coursesName, string coursesTown)
            : base(coursesName)
        {
            this.Town = coursesTown;
        }

        public OffsiteCourse(string coursesName, ITeacher coursesTeacher, string coursesTown)
            : base(coursesName, coursesTeacher)
        {
            this.Town = coursesTown;
        }

        // properties
        public string Town
        {
            get { return this.town; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The value we set for town cannot be null or empty!");
                }

                this.town = value;
            }
        }

        // methods
        public override string ToString()
        {
            StringBuilder coursesInfo = new StringBuilder();

            coursesInfo.Append(string.Format("{0}: ", this.GetType().Name));
            coursesInfo.Append(base.ToString());
            coursesInfo.AppendLine(string.Format("Town={0}", this.Town));

            return coursesInfo.ToString();
        }
    }*/
}
