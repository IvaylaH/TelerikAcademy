using System;

namespace Problem3_InvalidRangeException
{
    public class InvalidRangeException<T> : ApplicationException
    {
        // fields
        private T start;
        private T end;

        // constructors
        public InvalidRangeException(T currentStart, T currentEnd)
            : base()
        {
            this.Start = currentStart;
            this.End = currentEnd;
        }

        public InvalidRangeException(string message, T currentStart, T currentEnd)
            : base(message)
        {
            this.Start = currentStart;
            this.End = currentEnd;
        }

        public InvalidRangeException(string message, T currentStart, T currentEnd, Exception innerException)
            : base(message, innerException)
        {
            this.Start = currentStart;
            this.End = currentEnd;
        }

        // properties

        protected T Start
        {
            set 
            {
                this.start = value;
            }
        }

        protected T End
        {
            set
            {
                this.end = value;
            }
        }

        public override string Message
        {
            get
            {
                return base.Message + string.Format("Range [{0}...{1}]", this.start, this.end);
            }
        }

    }
}
