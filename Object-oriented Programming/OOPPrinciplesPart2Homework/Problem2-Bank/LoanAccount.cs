using System;

namespace Problem2_Bank
{
    public class LoanAccount : Account
    {
        // constructors
        public LoanAccount(Customer customer, decimal balance, decimal interestRate, int numOfMonths)
            : base(customer, balance, interestRate, numOfMonths)
        {

        }

        // methods
        public override decimal CalculateInterest()
        {
            if (this.customer is Individual)
            {
                return ((this.NumberOfMonths - 3) * this.InterestRate);
            }
            else
            {
                return ((this.NumberOfMonths - 2) * this.InterestRate);
            }
        }
    }
}
