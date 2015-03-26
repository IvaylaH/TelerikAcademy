using System;
using System.Collections.Generic;

namespace Problem2_Bank
{
    class Program_TestTheBankSystem
    {
        static void Main()
        {
            // creating an instance of the class DepositAccount
            IList<DepositAccount> deposits = new List<DepositAccount>
            {
                new DepositAccount(new Individual("Ivan", "Petrov", 1), 1500.00M, 1.3M, 12),
                new DepositAccount(new Company("SomeCompany", 3), 15000.15M, 0.5M, 23),
                new DepositAccount(new Individual("Kocety", "Ivanov", 3), 2000.14M, 1.3M, 18)
            };

            // creating an instance of the class LoanAccount
            IList<LoanAccount> loans = new List<LoanAccount>
            {
                new LoanAccount(new Company("FirstCompany", 5), 15000.50M, 1.6M, 36),
                new LoanAccount(new Individual("Vasil", "Stamatov", 2), 7500.11M, 2.5M, 120),
            };

            // creating an instance of the class MortgageAccount
            IList<MortgageAccount> mortgages = new List<MortgageAccount>
            {
                new MortgageAccount(new Company("StartUpCompany", 1), 20500.25M, 1.2M, 120),
                new MortgageAccount(new Company("Drops", 4), 0.15M, 1.2M, 120),
                new MortgageAccount(new Individual("Staman", "Petrov", 1), 3010.10M, 2.4M, 120),
                new MortgageAccount(new Company("Skyfall", 3), 2013.13M, 2.0M, 120)
            };

            // creating an instance of the class Bank
            Bank myBank = new Bank("JustABank",deposits, loans, mortgages);

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Print bank info:");

            Console.ResetColor();
            Console.WriteLine(myBank);

            // second check of the CalculateInterest()
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Calculating the interest amount for deposit acounts: ");

            PrintInterestAmount(deposits);

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Calculating the interest amount for loan acounts: ");

            PrintInterestAmount(loans);

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Calculating the interest amount for mortgage acounts: ");

            PrintInterestAmount(mortgages);
        }

        public static void PrintInterestAmount(IEnumerable<Account> accounts)
        {
            Console.ResetColor();

            foreach (var account in accounts)
            {
                Console.WriteLine(account);
            }

            Console.Write(Environment.NewLine);
        }
    }
}
