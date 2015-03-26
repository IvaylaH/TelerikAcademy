using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareAcademy
{
   /* public abstract class Course : ICourse
    {
        // fields
        private string name;
        private ITeacher teacher;
        private IList<string> topics;

        // constructors
        protected Course(string coursesName, ITeacher inputTeacher = null)
        {
            this.Name = coursesName;
            this.Teacher = inputTeacher;
            this.topics = new List<string>();
        }

        // properties
        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name of the course cannot be null or empty!");
                }

                this.name = value;
            }
        }

        public ITeacher Teacher
        {
            get { return this.teacher; }
            set
            {
                this.teacher = value;
            }
        }

        public IList<string> Topics
        {
            get { return new List<string>(this.topics); }
        }

        // methods
        public void AddTopic(string topic)
        {
            if (string.IsNullOrEmpty(topic))
            {
                throw new ArgumentNullException("The topic cannot be null or empty!");
            }

            this.topics.Add(topic);
        }

        public override string ToString()
        {
            StringBuilder coursesInfo = new StringBuilder();

            coursesInfo.Append(string.Format("Name={0}", this.Name));
            if (this.Teacher != null)
	        {
                coursesInfo.Append(string.Format("; Teacher={0}", this.Teacher.Name));
	        }
            if (this.topics.Count != 0)
            {
                string topicsToStr = string.Join(", ", this.topics);
                coursesInfo.Append(string.Format("; Topics=[{0}]; ", topicsToStr));
            }

            return coursesInfo.ToString();
        }
    }*/
}
