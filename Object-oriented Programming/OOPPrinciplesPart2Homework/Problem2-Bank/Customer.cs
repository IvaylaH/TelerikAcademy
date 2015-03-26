using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_Bank
{
    public abstract class Customer
    {
        // fields
        private string firstName;
        private string lastName;
        private int numberOfAccounts; // gives the number of accounts the customer has in the bank

        // constructors
        public Customer(string companyName, int numOfAccounts)
        {
            this.FirstName = companyName;
            this.NumberOfAccounts = numOfAccounts;
        }

        public Customer(string fName, string lName, int numOfAccounts)
            : this(fName, numOfAccounts)
        {
            this.LastName = lName;
        }

        // properties
        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name of the customer cannot be null or empty!");
                }

                if (value.Length < 3)
                {
                    throw new ArgumentOutOfRangeException("The name of the customer must have at least 3 charactes!");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name of the customer cannot be null or empty!");
                }

                if (value.Length < 5)
                {
                    throw new ArgumentOutOfRangeException("The name of the customer must have at least 5 charactes!");
                }

                this.lastName = value;
            }
        }

        public int NumberOfAccounts
        {
            get { return this.numberOfAccounts; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The number of accounts cannot be set to a negative number!");
                }

                this.numberOfAccounts = value;
            }
        }

        // methods
        public override string ToString()
        {
            return string.Format("Name: " + this.FirstName + " " + this.LastName + "; Number of accounts: " + this.NumberOfAccounts + ".");
        }
    }
}
