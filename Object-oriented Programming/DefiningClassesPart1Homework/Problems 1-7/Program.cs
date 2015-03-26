using System;
using System.Collections.Generic;
using System.Text;

namespace Problems_1_7
{
    class Program
    {
        private static GSM myPhone = GSM.IPhone4S;
        private static StringBuilder printCalls = new StringBuilder();
        private static string billToStr = String.Empty;
        private static int longestCallIndex = 0;
        private static int longestCallDuration = 0;

        static void Main(string[] args)
        {
          /*  GSM testGsm = new GSM("Nokia C3", "Nokia");
            GSM gsm = new GSM("Nokia C3", "Nokia", 230.00M, "Me", "X53LiIonBat1", 8.5, 4.5, 8.1, 165200);

            Console.WriteLine(testGsm);
            Console.WriteLine();
            Console.WriteLine(gsm);*/ // --> used this to test if the program is working 

            // info for the GSMTest class
            string[] models = { "Nokia C3", "Samsung Ace 2", "Sony Xperia Z", "HTC One X", "BlackBerry Curve 9320" };
            string[] manufacturers = { "Nokia", "Samsung", "Sony Ericson", "HTC", "BlackBerry Limited" };
            decimal[] prices = { 150M, 450M, 750M, 1050M, 1350M };
            string[] owners = { "Me", "You", "He", "She", "They" };
            string[] batteryModel = { "someBat" };
            double[] batHoursIdle = { 8.5 };
            double[] batHoursTalk = { 4.5 };
            double[] displaySize = { 8.3, 7.5, 7.6, 9.0, 8.5 };
            int[] displayColors = { 165000 };

            // filling the array of phones
            GSMTest test = new GSMTest();
            test.GetSomePhones(models, manufacturers, prices, owners, batteryModel, batHoursIdle, batHoursTalk, displaySize, displayColors);

            // printing the resulting array of phones
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("These are the instances of the class GSM, that we created: ");
            Console.ResetColor();
            Console.WriteLine(test);

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Here is the static field iPhone4S that we created: ");
            Console.ResetColor();
            Console.WriteLine(GSM.IPhone4S);

            // Problem 12 - creating an instance of the GSM calls and calculating the total bill
            //this time reading the call info from the Console

            ReadInputAndPerformOperations();

        }

        private static void ReadInputAndPerformOperations()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Please enter a positive integer number for calls we'll be working with: ");
            Console.Write("number = ");
            int number = int.Parse(Console.ReadLine());

            int index = 0;

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Please enter info for the calls in the following order --> date, time, dialed phone, duration: ");

            while (number > 0)
            {
                Console.Write("Call info = ");

                string callInfo = Console.ReadLine();
                string[] callInfoElements = callInfo.Split(new char[] { ',', ' ', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
                myPhone.AddCalls(callInfoElements[0], callInfoElements[1], callInfoElements[2], int.Parse(callInfoElements[3]));

                // at every iteration of the loop I add the duration of the current call to the bill
                billToStr = myPhone.CalculateTotalBill(int.Parse(callInfoElements[3]), 0.37M); //

                // here I append the last call info added to the List<Call> to the StringBuilder that keeps the text, I'll print on the Console in the end; the; the var 'index' helps me keep track of the call info I need to append
                printCalls.Append(myPhone.CallHistory[index]);
                printCalls.Append(Environment.NewLine);

                // looking for the duration of the longest call and the index of this call in the List<Call>; keep both vars so that later can use them to delete the call with longest duration and subtract its cost (duration * 0.37) from the bill
                if (myPhone.CallHistory[index].Duration >= 0 && longestCallDuration == 0 || longestCallDuration < myPhone.CallHistory[index].Duration)
                {
                    longestCallDuration = myPhone.CallHistory[index].Duration;
                    longestCallIndex = index;
                }
                else if (myPhone.CallHistory[index].Duration < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid input! The duration of the phone call cannot be a negative number.");
                }

                index++;
                number--;
            }

            // appending the bill with the call with longest duraton included
            printCalls.AppendFormat("Bill before deleting the longest call: {0}", billToStr); 
            printCalls.Append(Environment.NewLine);

            // deleting the longest call
            myPhone.DeleteCalls(myPhone.CallHistory[longestCallIndex]);

            // finding the new bill (without the longest call)
            billToStr = CalculateBillWithoutLongestCall(billToStr, 0.37, longestCallDuration);

            // appending the new bill
            printCalls.AppendFormat("Bill after deleting the longest call: {0:F2}", billToStr);
            printCalls.Append(Environment.NewLine);

            // clearing the content of our List<Call> and printing the required info on the Console
            myPhone.ClearCallHistory();
            PrintCallsInfo();
        }

        // finding the new bill value (without the longest call)
        private static string CalculateBillWithoutLongestCall(string billToStr, double p, int longestCallDuration)
        {
            double bill = double.Parse(billToStr) - (p * longestCallDuration);

            return bill.ToString();
        }

        // printing the requested info
        private static void PrintCallsInfo() // not sure if it will work
        {
            string print = printCalls.ToString();

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(print);
        }
    }
}
