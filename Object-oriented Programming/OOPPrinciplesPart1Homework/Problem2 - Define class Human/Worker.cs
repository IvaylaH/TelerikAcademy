using System;

namespace Problem2_Define_classHuman
{
    public class Worker : Human
    {
        // fields
        private decimal weekSalary;
        private decimal workHoursPerDay;
        private decimal hourlyPayment;

        // constructors
        public Worker(string firstName, string lastName, decimal wSalary, decimal wHours)
            : base(firstName, lastName)
        {
            this.WeekSalary = wSalary;
            this.WorkHoursPerDay = wHours;
        }

        // properties
        public decimal WeekSalary 
        {
            get { return this.weekSalary; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The week salary cannot be a negative number!");
                }

                this.weekSalary = value;
            }
        }

        public decimal WorkHoursPerDay 
        {
            get {return this.workHoursPerDay;}
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Number of work hours per day cannot be a negative number!");
                }

                this.workHoursPerDay = value;
            }
        }

        public decimal HourlyPayment 
        {
            get { return this.hourlyPayment; }
            private set
            {
                this.hourlyPayment = value;
            }
        }

        // methods
        public decimal MoneyPerHour()
        {
            return this.HourlyPayment = this.weekSalary / this.workHoursPerDay;
        }

        public override string ToString()
        {
            return string.Format("Worker's name: {0} works {1} hours per day for a week salary of: {2}", this.FirstName + this.LastName, this.WorkHoursPerDay, this.WeekSalary);
        }
    }
}
