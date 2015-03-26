using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_AnimalHierarchy
{
    public abstract class Animal : ISound  // the class will only be inherited, there's no need to create instances of the class Animal so it would be an abstract class + it has an abstract method MakeSound()
    {
        // fields
        private int age;
        private string name;
        private string sex;
        private bool isFemale;

        // constructors

        // created 2 constructors so I can ensure that in the class Cat I don't have to set the value of sex
        public Animal(int currentAge, string currentName, string currentSex) 
            : this(currentAge, currentName)
        {
            this.Sex = currentSex;
        }

        public Animal(int currentAge, string currentName)
        {
            this.Age = currentAge;
            this.Name = currentName;
        }

        // properties
        public int Age 
        {
            get { return this.age; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("We cannot have a negative number for the age of the animal!");
                }

                this.age = value;
            }
        }

        public string Name 
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name of the animal cannot be empty!");
                }

                if (value.Length < 2)
                {
                    throw new ArgumentException("The name of the animal must have at least 2 characters!");
                }

                this.name = value;
            }
        }

        public string Sex
        { 
            get { return this.sex; }
            protected set  // the setter is protected so that its value could be set by the derived classes
            {
                if ((value != "female" && value != "f" && value != "F") && (value != "male" && value != "m" && value != "M"))
                {
                    throw new ArgumentException("We can have either male, or female animals!");
                }

                this.sex = value;

                // if the string entered for sex equals any of the options below then, the property IsFemale will be set to true/false, respectively
                if (value == "female" || value == "f" || value == "F")
	            {
                    this.IsFemale = true;
	            }
                else if (value == "male" || value == "m" || value == "M")
                {
                    this.IsFemale = false;
                }
            }
        }

        public bool IsFemale 
        {
            get { return this.isFemale; }
            protected set 
            {
                this.isFemale = value;
            }
        }


        // methods
        public abstract void MakeSound();

        public override string ToString()
        {
            return string.Format("This is a {0}. Its name is {1}. \n{1} is {2} years old and is a girl: {3}.", this.GetType().Name, this.Name, this.Age, this.IsFemale);
        }
    }
}
