using System;

namespace Problem2_Bank
{
    public class DepositAccount : Account
    {
        private decimal balance;

        // constructors
        public DepositAccount(Customer customer, decimal balance, decimal interestRate, int numOfMonths)
            : base(customer, balance, interestRate, numOfMonths)
        {
            this.balance = 10;
        }

        // methods
        public void WithdrawMoney(decimal withdrawnMoney)
        {
            this.Balance -= withdrawnMoney;

            if (this.Balance > 0)
            {
                Console.WriteLine("You have withdrawn the following amount of money: {0}", withdrawnMoney); ;
                Console.WriteLine("After the wirhdrawal your balance is: {0}", this.Balance);
            }
            else
            {
                Console.WriteLine("I'm sorry but the transaction cannot be completed! \nYour current balance is under {0}", withdrawnMoney);
            }
        }

        public override decimal CalculateInterest()
        {
            if (this.Balance < 1000) // do I need to check explicitly if is a pos number when I have already resticted it?
            {
                return 0;
            }
            else
            {
                return base.CalculateInterest();
            }
        }
    }
}
