/*A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, BIC code and 3 credit card numbers associated with the account. Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.*/

using System;

class BankAccount
{
    static void Main()
    {
        string firstName = "Winnie";
        string middleName = "The";
        string lastName = "Pooh";
        string holderName = firstName + " " + middleName + " " + lastName;
        decimal ballance;
        ballance = 150.001m;
        string bankName;
        bankName = "Honey Jar";
        string iban;
        iban = "BG20HONEYJAR3560000000";
        string biCode;
        biCode = "BGHONEYJAR15SF";
        ulong firstCard;
        ulong secondCard;
        ulong thirdCard;

        Console.WriteLine("Our client's name is : {0}. He trusts our {1} and keeps all {2} tons on honey he has in it.", holderName, bankName, ballance);
        Console.WriteLine("Our {0} has the following IBAN and BicCode:\n{1}; {2}.", bankName, iban, biCode);
        Console.WriteLine("Mr. {0} has 3 credit cards at our bank that allow him to buy more honey every day.", lastName);
        Console.WriteLine("Thank you for trusting our {0}, Mr. {1}! You're a lucky bear!", bankName, lastName);

    }
}
