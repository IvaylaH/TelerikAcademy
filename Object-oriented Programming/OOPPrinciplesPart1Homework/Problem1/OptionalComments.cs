using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    public abstract class OptionalComments // we create an abstract class because we do not want to create instances of the class, but the class will be inherited and thus it will expand the functionality of the derived classes
    {
        // fields
        private string comment;

        // properties
        public string Comment
        {
            get { return this.comment; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The comment you're entering cannot be empty!");
                }

                if (value.Length < 4)
                {
                    throw new ArgumentException("The comment must have at least 4 characters!");
                }

                this.comment = value;
            }
        }

        // methods
        public void AddComment(string inputComment)
        {
            this.Comment = inputComment;
        }

        public override string ToString()
        {
            return this.Comment;
        }
    }
}
