using System;
using System.Text;

namespace Problem4_Define_Class_Person
{
    public class Person
    {
        // fields
        private string name;
        private int? age;

        // constructors
        public Person(string inputName, int? inputAge = null)
        {
            this.Name = inputName;
            this.Age = inputAge;
        }

        // properties
        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
	            {
                    throw new ArgumentNullException("The name of the person cannot be null or empty!");
	            }

                if (value.Length < 2)
                {
                    throw new ArgumentException("The name of the person must have at least 2 characters!");
                }

                this.name = value;
            }
        }
        public int? Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The age of the person cannot be a negative number!");
                }

                this.age = value;
            }
        }

        // methods
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine("Info:");
            result.AppendLine(string.Format("Name: {0}", this.Name));

            string ageInfo = age == null ? "Not specified" : string.Format("{0}", this.Age);
            result.AppendLine(string.Format("Age: {0}", ageInfo));

            return result.ToString();
        }
    }
}
