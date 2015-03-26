using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
    public abstract class Person : OptionalComments
        // the class is abstract because it gives only basic info; in the program we are not going to create an instance of class Person, only instances of classes Teacher and Student
    {
        // fields
        private string name;

        // constructors
        public Person(string personsName)
        {
            this.Name = personsName;
        }

        //properties
        public string Name 
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name of the person cannot be empty!");
                }

                if (value.Length < 3)
                {
                    throw new ArgumentException("The name of the person must have at least 3 characters!");
                }

                this.name = value;
            }
        }

        public override string ToString()
        {
            return this.Name.ToString();
        }
    }
}
