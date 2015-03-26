using System;

namespace Problem2_Bank
{
    public class MortgageAccount : Account
    {
        // constructors
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate, int numOfMonths)
            : base(customer, balance, interestRate, numOfMonths)
        {

        }

        // methods
        public override decimal CalculateInterest()
        {
            if (this.customer is Individual)
            {
                return ((this.NumberOfMonths - 6) * this.InterestRate);
            }
            else
            {
                return ((12 * (0.5M * this.InterestRate) + (this.NumberOfMonths - 12) * this.InterestRate));
            }
        }
    }
}
