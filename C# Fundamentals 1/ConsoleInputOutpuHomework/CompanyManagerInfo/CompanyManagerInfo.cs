/*A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. Write a program that reads the information about a company and its manager and prints them on the console.*/

using System;

    class CompanyManagerInfo
    {
        static void Main()
        {
            string companyInfo = "Company Info";
            Console.Write("Please enter the name of your company: ");
            string companyName = Console.ReadLine();
            Console.Write("Please enter address for your company: ");
            string address = Console.ReadLine();
            Console.Write("Please enter the company's phone number: ");
            string phoneNum = Console.ReadLine();
            Console.Write("Please enter the company's fax number: ");
            string faxNum = Console.ReadLine();
            Console.Write("Please enter the company's web site: ");
            string webSite = Console.ReadLine();
            Console.Write("Please enter the name of the manager: ");
            string companyManager = Console.ReadLine();

            string managerInfo = "Manager's Info";
            Console.Write("Please enter the first name of the manager: ");
            string manFirstName = Console.ReadLine();
            Console.Write("Please enter the last name of the manager: ");
            string manLastName = Console.ReadLine();
            Console.Write("Please enter the current age of the manager: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Please enter the manager's phone number: ");
            string manPhoneNum = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("{0, 24}", companyInfo);
            Console.WriteLine();
            Console.WriteLine("Name: {0}", companyName);
            Console.WriteLine("Address: {0}      Phone and fax number: {1}, {2}", address, phoneNum, faxNum);
            Console.WriteLine("Web site: {0}", webSite);
            Console.WriteLine("Manager: {0}", companyManager);
            Console.WriteLine();
            Console.WriteLine("{0, 24}", managerInfo);
            Console.WriteLine();
            Console.WriteLine("Name: {0} {1}", manFirstName, manLastName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Phone number: {0}", manPhoneNum);
        }
    }
