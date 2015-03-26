/** Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. Examples:
	0  "Zero"
	273  "Two hundred seventy three"
	400  "Four hundred"
	501  "Five hundred and one"
	711  "Seven hundred and eleven"*/

using System;

    class NumberToText
    {   
        static string PrintDigit(int remainder, string numPronun)
        {  //Here are the digits between [0...9]
            switch (remainder)
            {
                case 0: return numPronun = "Zero";
                case 1: return numPronun = "One";
                case 2: return numPronun = "Two";
                case 3: return numPronun = "Three";
                case 4: return numPronun = "Four";
                case 5: return numPronun = "Five";
                case 6: return numPronun = "Six";
                case 7: return numPronun = "Seven";
                case 8: return numPronun = "Eight";
                default: return numPronun = "Nine";
            }
        }

        static string PrintNumbersBetween10And20(int remainder, string numPronun)
        { //Here are the numbers between [10...19]
            switch (remainder)
            {
                case 0: return numPronun = "Ten";
                case 1: return numPronun = "Eleven";
                case 2: return numPronun = "Twelve";
                case 3: return numPronun = "Thirteen";
                case 4: return numPronun = "Fourteen";
                case 5: return numPronun = "Fifteen";
                case 6: return numPronun = "Sixteen";
                case 7: return numPronun = "Seventeen";
                case 8: return numPronun = "Eighteen";
                default: return numPronun = "Nineteen";
            }
        }
        static string PrintTwoDigits1(int result, string numPronun)
        { // Here are the tens - 20, 30, 40, 50, 60, 70, 80, 90
            switch(result)
            {
                case 2: return numPronun = "Twenty";
                case 3: return numPronun = "Thirty";
                case 4: return numPronun = "Forty";
                case 5: return numPronun = "Fifty";
                case 6: return numPronun = "Sixty";
                case 7: return numPronun = "Seventy";
                case 8: return numPronun = "Eighty";
                default: return numPronun = "Ninety";
            }
        }
        static string PrintTwoDigits2(int remainder, int result, string numPronun)
        { // Here I combine the tens with the digit numbers, so that I can get a two digit number like 42
            switch (remainder)
            {
                case 0: return PrintTwoDigits1(result, numPronun);
                case 1: return PrintTwoDigits1(result, numPronun) + "-" + PrintDigit(remainder, numPronun);
                case 2: return PrintTwoDigits1(result, numPronun) + "-" + PrintDigit(remainder, numPronun);
                case 3: return PrintTwoDigits1(result, numPronun) + "-" + PrintDigit(remainder, numPronun);
                case 4: return PrintTwoDigits1(result, numPronun) + "-" + PrintDigit(remainder, numPronun);
                case 5: return PrintTwoDigits1(result, numPronun) + "-" + PrintDigit(remainder, numPronun);
                case 6: return PrintTwoDigits1(result, numPronun) + "-" + PrintDigit(remainder, numPronun);
                case 7: return PrintTwoDigits1(result, numPronun) + "-" + PrintDigit(remainder, numPronun);
                case 8: return PrintTwoDigits1(result, numPronun) + "-" + PrintDigit(remainder, numPronun);
                default: return PrintTwoDigits1(result, numPronun) + "-" + PrintDigit(remainder, numPronun);
            } 
        }
        static string PrintsThreeDigits1(int secondResult, string numPronun)
        { //Here are the hundreds
            switch(secondResult)
            {
                case 1: return numPronun = "One Hundred";
                case 2: return numPronun = "Two Hundred";
                case 3: return numPronun = "Three Hundred";
                case 4: return numPronun = "Four Hundred";
                case 5: return numPronun = "Five Hundred";
                case 6: return numPronun = "Six Hundred";
                case 7: return numPronun = "Seven Hundred";
                case 8: return numPronun = "Eight Hundred";
                default: return numPronun = "Nine Hundred";
            }
        }
        static void Main()
        {
            Console.WriteLine("This program will print the pronunciation in English of any number in the range [0...999] that you enter as an input.");
            Console.Write("Please enter a number of your choice: ");
            int number = int.Parse(Console.ReadLine());
            int result = 0;
            int secondResult;
            int remainder = 0;
            int newRemainder = 0;
            string numPronun = null;

            if ((number >= 0) && (number < 20))
            {
                result = number / 10; // the result will show me if the number is < 0
                remainder = number % 10; // the remainder will show me if the number is between [10...19]
  
                switch(result)
                {
                    case 0: Console.WriteLine("Number {0} in English is \"{1}\".", number, PrintDigit(remainder, numPronun)); break;
                    default: Console.WriteLine("Number {0} in English is \"{1}\".", number, PrintNumbersBetween10And20(remainder, numPronun)); break;
                }
            }
            else if ((number >= 20) && (number < 100))
            {
                 result = number / 10; //the result will give the tens of the number
                 remainder = number % 10; //the the remainder will give the ones of the number
                
                 switch(result)
                 {
                    case 2: Console.WriteLine("Number {0} in English is: \"{1}\".", number, PrintTwoDigits2(remainder, result, numPronun)); break;
                    case 3: Console.WriteLine("Number {0} in English is: \"{1}\".", number, PrintTwoDigits2(remainder, result, numPronun)); break;
                    case 4: Console.WriteLine("Number {0} in English is: \"{1}\".", number, PrintTwoDigits2(remainder, result, numPronun)); break;
                    case 5: Console.WriteLine("Number {0} in English is: \"{1}\".", number, PrintTwoDigits2(remainder, result, numPronun)); break;
                    case 6: Console.WriteLine("Number {0} in English is: \"{1}\".", number, PrintTwoDigits2(remainder, result, numPronun)); break;
                    case 7: Console.WriteLine("Number {0} in English is: \"{1}\".", number, PrintTwoDigits2(remainder, result, numPronun)); break;
                    case 8: Console.WriteLine("Number {0} in English is: \"{1}\".", number, PrintTwoDigits2(remainder, result, numPronun)); break;
                    default: Console.WriteLine("Number {0} in English is: \"{1}\".", number, PrintTwoDigits2(remainder, result, numPronun)); break;           
                 }
            }
            else if ((number >= 100) && (number < 1000))
            {
                secondResult = number / 100;  // the secondResult gives the hundreds
                newRemainder = number % 100; // newRemainder gives the remainder of number / 10
                result = newRemainder / 10; // result gives the tens of the number
                remainder = newRemainder % 10; // remainder gives the ones

                if (newRemainder == 0)
                {
                    numPronun = PrintsThreeDigits1(secondResult, numPronun);
                    Console.WriteLine("Number {0} in English is: \"{1}\".", number, numPronun);
                }
                else if ((newRemainder > 9) && (newRemainder < 20))
                {
                    numPronun = PrintsThreeDigits1(secondResult, numPronun) + " And " + PrintNumbersBetween10And20(remainder, numPronun);
                    Console.WriteLine("Number {0} in English is: \"{1}\".", number, numPronun);
                }
                else if ((newRemainder == 20) || (newRemainder == 30) || (newRemainder == 40) || (newRemainder == 50) || (newRemainder == 60) || (newRemainder == 70) || (newRemainder == 80) || (newRemainder == 90))
                {
                    numPronun = PrintsThreeDigits1(secondResult, numPronun) + " " + PrintTwoDigits1(result, numPronun);
                    Console.WriteLine("Number {0} in English is: \"{1}\".", number, numPronun);
                }
                else
                {
                    numPronun = PrintsThreeDigits1(secondResult, numPronun) + " " + PrintTwoDigits1(result, numPronun) + "-" + PrintDigit(remainder, numPronun);
                    Console.WriteLine("Number {0} in English is: \"{1}\".", number, numPronun);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number in the range [0...999]");
            }
      
        }
                
    }


