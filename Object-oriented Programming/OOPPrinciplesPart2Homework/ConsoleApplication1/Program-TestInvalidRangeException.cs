using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_InvalidRangeException
{
    class Program_TestInvalidRangeException
    {
        static void Main()
        {
            AskForDate();

            List<int> numbers = new List<int>();
            numbers = GetAllTheRequiredInts();

            PrintElements(numbers);
        }

        // asks for date input and then calls the CheckDate()
        public static void AskForDate()
        {
            DateTime startDate = new DateTime(1980, 1, 1);
            DateTime endDate = new DateTime(2013, 12, 31);

            Console.WriteLine("Please enter a date: yyyy/mm/dd ");
            Console.Write("date: ");

            DateTime dateToCheck;
            bool checkInput = DateTime.TryParse(Console.ReadLine(), out dateToCheck);
            try
            {
                CheckDate(dateToCheck, startDate, endDate);
                Console.WriteLine("The date you have entered: " + dateToCheck.ToString("dd.MM.yyyy"));
            }
            catch (InvalidRangeException<DateTime> ire)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(ire.Message);

                Console.ResetColor();
            }
        }

        // checks if the input date is inside the required range
        private static DateTime CheckDate(DateTime dateToCheck, DateTime startDate, DateTime endDate)
        {
            if (dateToCheck >= startDate && dateToCheck <= endDate)
            {
                return dateToCheck;
            }
            else
            {
                throw new InvalidRangeException<DateTime>("The date you entered is out of the required range. ", startDate, endDate);
            }
        }

        // checks if the number entered by the user is inside the required range
        public static int EnterIntNumbers()
        {
            int start = 1;
            int end = 100;

            Console.WriteLine("Please enter an integer number in the range [1...100]");
            Console.Write("number = ");
            int number;
            bool checkInput = int.TryParse(Console.ReadLine(), out number);

            if (number >= start && number <= end)
            {
                return number;
            }
            else
            {
                throw new InvalidRangeException<int>("The number is out of the required range. ", start, end);
            }
        }

        // allows the user to decide how many numbers he would like to enter and then calls EnterIntNumbers()
        public static List<int> GetAllTheRequiredInts()
        {
            List<int> numbers = new List<int>();

            Console.Write(Environment.NewLine);
            Console.Write("How many number you would like to add to the list? ");
            Console.Write("number of elements = ");
            int numberOfElements;
            bool checkInput = int.TryParse(Console.ReadLine(), out numberOfElements);

            for (int i = 0; i < numberOfElements; i++)
            {
               numbers.Add(EnterIntNumbers());
            }

            return numbers;
        }

        // prints the numbers
        public static void PrintElements(IEnumerable<int> numbers)
        {
            Console.Write(Environment.NewLine);
            Console.WriteLine("We have the following list");

            foreach (var num in numbers)
            {
                Console.Write(num + " ");
            }

            Console.Write(Environment.NewLine);
        }
    }
}
