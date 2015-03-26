/* Write a program that reads an integer number and calculates and prints its square root. If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.*/

using System;
using System.Collections.Generic;
using System.Text;

class CalculateSqrt
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Please enter an int number: ");
            Console.Write("number = ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (number > 0)
	        {
	            double numberSqrt = Math.Sqrt(number);

                Console.WriteLine("The square root of {0} is {1}", number, numberSqrt);
	        }
            else 
            { 
                throw new ArithmeticException("Invalid number! You should enter a positive integer number");
            }
        }
        catch(OverflowException ex)
        {
            Console.WriteLine("Invalid number! The number was out of the range the type int");
        }
            catch(FormatException fex)
        {
            Console.WriteLine("Invalid number! Argument not in the right format!");
        }
            catch(ArgumentNullException)
        {
            throw new ArgumentNullException("The argument you were trying to pass is not assigned!");
        }
        finally
        {
            Console.WriteLine("Good-bye!");
        }
    }
}


