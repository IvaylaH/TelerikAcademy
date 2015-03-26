using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_Bank
{
    public abstract class Account : IAccount
    {
        // fields
        protected Customer customer;
        private decimal balance;
        private decimal interestRate;
        private int numberOfMonths;

        // constructors
        public Account(Customer currentCustomer, decimal currentBalance, decimal currentInterestRate, int currentNumOfMonths)
        {
            this.customer = currentCustomer;
            this.Balance = currentBalance;
            this.InterestRate = currentInterestRate;
            this.NumberOfMonths = currentNumOfMonths;
        }

        // properties
        public decimal Balance
        {
            get { return this.balance; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The value of balance cannot be a negative number!");
                }

                this.balance = value;

            }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The interest rate cannot be a negative number!");
                }

                this.interestRate = value;
            }
        }

        public int NumberOfMonths
        {
            get { return this.numberOfMonths; }
            protected set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("For the number of months we cannot have a negative number or 0!");
                }

                this.numberOfMonths = value;
            }
        }

        public Customer Customer
        {
            get { return this.customer; }
        }

        // methods
        public void DepositMoney(decimal depositedAmount)  // is the method written well
        {
            if (depositedAmount < 0)
            {
                throw new ArgumentOutOfRangeException("The deposited amount of money cannot be a negative number!");
            }

            this.Balance = this.Balance + depositedAmount;
            Console.WriteLine("You made a deposit of {0} to your account and now your new account balance is: {1}", depositedAmount, this.Balance);
        }

        public virtual decimal CalculateInterest()
        {
            return this.NumberOfMonths * this.InterestRate;
        }

        public override string ToString()
        {
            return string.Format("Account info: \nCustomer info: {0} \nBalance: {1}; Interest rate: {2}; Number of months: {3} \nInterest amount: {4}", this.Customer, this.Balance, this.InterestRate, this.NumberOfMonths, this.CalculateInterest());
        }
    }
}
