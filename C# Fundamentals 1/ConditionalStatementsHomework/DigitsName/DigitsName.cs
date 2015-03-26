/*Write program that asks for a digit and depending on the input shows the name of that digit (in English) using a switch statement.*/

using System;

    class DigitsName
    {
        static void Main()
        {
            Console.Write("Please enter a digit of your choice: ");
            int digit = int.Parse(Console.ReadLine());
            Console.WriteLine();

                switch (digit)
                {
                    case 0: Console.WriteLine("0 in English is 'Zero'"); break;
                    case 1: Console.WriteLine("1 in English is 'One'"); break;
                    case 2: Console.WriteLine("2 in English is 'Two'"); break;
                    case 3: Console.WriteLine("3 in English is 'Three'"); break;
                    case 4: Console.WriteLine("4 in English is 'Four'"); break;
                    case 5: Console.WriteLine("5 in English is 'Five'"); break;
                    case 6: Console.WriteLine("6 in English is 'Six'"); break;
                    case 7: Console.WriteLine("7 in English is 'Seven'"); break;
                    case 8: Console.WriteLine("8 in English is 'Eight'"); break;
                    case 9: Console.WriteLine("9 in English is 'Nine'"); break;
                    default: Console.WriteLine("Invalid input. Please start over."); break;

                }
        }
    }
