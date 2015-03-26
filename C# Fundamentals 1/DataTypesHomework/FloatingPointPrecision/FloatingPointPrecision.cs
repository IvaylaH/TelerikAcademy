/*Write a program that safely compares floating-point numbers with precision of 0.000001. Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true*/
namespace FloatingPointPrecise
{
    using System;
    class FloatingPointPrecision
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number of your choice.");
            double firstNum = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a second number.");
            double secondNum = double.Parse(Console.ReadLine());

            bool difference = Math.Abs(firstNum - secondNum) < 0.000001;
            if (difference == true)
            {
                Console.WriteLine("{0} and {1} are equal with precision 0.000001.", firstNum, secondNum);
            }
            else
            {
                Console.WriteLine("{0} and {1} are not equal.", firstNum, secondNum);

            }
        }

    }
}