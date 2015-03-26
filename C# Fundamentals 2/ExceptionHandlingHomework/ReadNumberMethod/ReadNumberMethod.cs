/* Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. If an invalid number or non-number text is entered, the method should throw an exception. Using this method write a program that enters 10 numbers:
			a1, a2, … a10, such that 1 < a1 < … < a10 < 100*/

using System;
using System.Collections.Generic;
using System.Text;

class ReadNumberMethod
{
    static void ReadNumber(int start, int end)
    {
        try
        {
            Console.WriteLine("Please enter an int number: ");
            Console.Write("number = ");
            int number = int.Parse(Console.ReadLine());
            int count = 0;

            Console.WriteLine();

            if ((number <= start) || (number > end))
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                count++;
                Console.WriteLine("{0}. number = {1}", count, number);
            }

        }
        catch (ArgumentOutOfRangeException argEx)
        {
            Console.WriteLine("The number is not inside the range we have!");
        }
        catch (FormatException fEx)
        {
            throw new FormatException("Invalid input! Non - number text or not wrong data type!");
        }
        catch(StackOverflowException stEx)
        {
            Console.WriteLine("The number was outside the range of type int");
        }
        catch(ArgumentNullException aEx)
        {
            throw new ArgumentNullException ("The argument you're trying to pass was not assigned a value.");
        }

    }
    static void Main()
    {
        int count = 0;

        while (count <= 10) //printing the 10 numbers
        {
            ReadNumber(1, 100);   
        }
    }
}
