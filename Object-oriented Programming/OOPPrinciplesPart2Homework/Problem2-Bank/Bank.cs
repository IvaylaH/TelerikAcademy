using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2_Bank
{
    public class Bank
    {
        // fields
        private string bankName;
        private IList<DepositAccount> depositAccounts;  // why I cannot use <Acocunt>
        private IList<LoanAccount> loanAccounts;
        private IList<MortgageAccount> mortgageAccounts;
        private int totalNumberOfAccounts;

        // constructors
        public Bank(string name, IList<DepositAccount> deposits, IList<LoanAccount> loans, IList<MortgageAccount> mortgages)
        {
            this.bankName = name;
            this.depositAccounts = deposits;  // which one is better?
            this.loanAccounts = loans;
            this.mortgageAccounts = mortgages;
           // this.depositAccounts = new List<DepositAccount>(deposits);  // ensures that I can use IEnumerable in the declaration
           // this.loanAccounts = new List<LoanAccount>(loans);
           // this.mortgageAccounts = new List<MortgageAccount>(mortgages);
        }

        // properties
        public string BankName
        {
            get { return this.bankName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name of the bank cannot be null or empty!");
                }

                if (value.Length < 6)
                {
                    throw new ArgumentOutOfRangeException("The name of the bank must have at least 6 characters!");
                }

                this.bankName = value;
            }
        }

        public IEnumerable<Account> DepositAccounts  // can I leave it IEnumerable when I have IList in the declaration of the field ?!?
        {
            get { return new List<DepositAccount>(this.depositAccounts); }
        }

        public IEnumerable<Account> LoanAccounts
        {
            get { return new List<LoanAccount>(this.loanAccounts); }
        }

        public IEnumerable<Account> MortgageAccounts
        {
            get { return new List<MortgageAccount>(this.mortgageAccounts); }
        }

        public int TotalNumberOfAccounts
        {
            get { return this.FindNumberOfAccounts(); }  // can I do this?
          /*  private set
            {
                this.totalNumberOfAccounts = value;
            }*/
        }

        // methods
        public int FindNumberOfAccounts()  // is it OK?
        {
            this.totalNumberOfAccounts = this.depositAccounts.Count + this.loanAccounts.Count + this.mortgageAccounts.Count;

            return this.totalNumberOfAccounts;
        }

        public override string ToString()
        {
            return string.Format("Name of the bank: {0}. \nTotal number of the accounts: {1} \nDeposit accounts: {2} \nLoan accounts: {3} \nMortgage accounts: {4}", this.BankName, this.TotalNumberOfAccounts, PrintAccounts(this.DepositAccounts), PrintAccounts(this.LoanAccounts), PrintAccounts(this.MortgageAccounts));
        }

        public string PrintAccounts(IEnumerable<Account> accounts)
        {
            StringBuilder printSb = new StringBuilder();

            foreach (var account in accounts)
            {
                 printSb.AppendFormat("{0}", account);
                 printSb.Append(Environment.NewLine);
            }

            return printSb.ToString();
        }
    }
}
