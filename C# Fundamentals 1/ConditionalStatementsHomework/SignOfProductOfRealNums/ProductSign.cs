/*Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.*/

using System;

    class ProductSign
    {
        static void Main()
        { // I have solved the problem in 2 different ways. 
            Console.Write("Please enter a real number of your choice: ");
            double firstNum = double.Parse(Console.ReadLine());
            Console.Write("Please enter a second real number: ");
            double secondNum = double.Parse(Console.ReadLine());
            Console.Write("Please enter a third real number: ");
            double thirdNum = double.Parse(Console.ReadLine());

            //This is the first way. It uses 4 if-else statements and runs a number of tests to check if the value of the number is positive or negative and as a result prints the sign of the product.
            bool firstCheck = firstNum > 0;
            bool secondCheck = secondNum > 0;
            bool thirdCheck = thirdNum > 0;

            if ((firstNum == 0) || (secondNum == 0) || (thirdNum == 0))
            {
                Console.WriteLine();
                Console.WriteLine("Product of the 3 numbers is '0' because at least 1 of them is '0'.");
            }
            else if ((firstCheck == true) && (secondCheck == true) && (thirdCheck == true))
            {
                Console.WriteLine();
                Console.WriteLine("The product of the 3 numbers has sign '+'.");
            }
            else if (((firstCheck == false) && (secondCheck == true) && (thirdCheck == true)) || ((firstCheck == true) && (secondCheck == false) && (thirdCheck == true)) || ((firstCheck == true) && (secondCheck == true) && (thirdCheck == false)))
            {
                Console.WriteLine();
                Console.WriteLine("The product of the 3 numbers has sign '-'.");
            }
            else if (((firstCheck == false) && (secondCheck == false) && (thirdCheck == true)) || ((firstCheck == false) && (secondCheck == true) && (thirdCheck == false)) || ((firstCheck == true) && (secondCheck == false) && (thirdCheck == false)))
            {
                Console.WriteLine();
                Console.WriteLine("The product of the 3 numbers has sign '+'.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("The product of the 3 numbers has sign '-'.");
            }

            //I guess the first way is slower, because of all the test it has to run, therefore I tried to solve it in a second way, as well, using counter for the negative numbers and checking if the couter is an odd or even number:
                int negativeNumsCount = 0;
                if (firstNum < 0)
                {
                    negativeNumsCount++;
                }
                if (secondNum < 0)
                {
                    negativeNumsCount++;
                }
                if (thirdNum < 0)
                {
                    negativeNumsCount++;
                }

                Console.WriteLine();
                Console.WriteLine("Checking the sign of the product using negativeNumsCount to check if the number of negatives is odd or even: ");

                if ((firstNum == 0) || (secondNum == 0) || (thirdNum == 0))
                {
                    Console.WriteLine();
                    Console.WriteLine("Product of the 3 numbers is '0' because at least 1 of them is '0'.");
                }
                else if (negativeNumsCount % 2 == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("The product of the 3 numbers has sign '+'.");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("The product of the 3 numbers has sign '-'.");
                }           
        }
    }
