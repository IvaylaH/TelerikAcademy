using System;
using System.Collections.Generic;

namespace Problem1
{
    public class Discipline : OptionalComments
    {
        // fields
        private string name;
        private int numberOfLectures;
        private int numberOfExcercises;

        // constructors
        public Discipline(string name)
            : this(name, 0, 0)
        {

        }

        public Discipline(string name, int numberOfLectures, int numberOfExcercises)
        {
            this.Name = name;
            this.NumberOfLextures = numberOfLectures;
            this.NumberOfExcercises = numberOfExcercises;
        }

        //properties
        public string Name 
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name of the Discipline cannot be empty!");
                }

                this.name = value;
            }
        }

        public int NumberOfLextures
        {
            get { return this.numberOfLectures; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The number of lectures cannot be a negative number! ");
                }

                this.numberOfLectures = value;
            }
        }

        public int NumberOfExcercises
        {
            get { return this.numberOfExcercises; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The number of exercises cannot be a negative number! ");
                }

                this.numberOfExcercises = value;
            }
        }

        // methods
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}; ", this.Name, this.NumberOfLextures, this.NumberOfExcercises);
        }
    }
}
