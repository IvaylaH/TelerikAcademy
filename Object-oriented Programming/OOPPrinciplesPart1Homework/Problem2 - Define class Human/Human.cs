using System;

namespace Problem2_Define_classHuman
{
    public abstract class Human
    {
        // fields
        private string firstName;
        private string lastName;

        // constructors
        protected Human(string fName, string lName)
        {
            this.FirstName = fName;
            this.LastName = lName;
        }

        // properties
        public string FirstName 
        {
            get { return this.firstName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The first name cannot be empty!");
                }

                if (value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("The first name should have at least 2 characters!");
                }

                this.firstName = value;
            }
        }

        public string LastName 
        {
            get { return this.lastName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The last name cannot be empty!");
                }

                if (value.Length < 4)
                {
                    throw new ArgumentOutOfRangeException("The last name should have at least 4 characters!");
                }

                this.lastName = value;
            }
        }
    }
}
