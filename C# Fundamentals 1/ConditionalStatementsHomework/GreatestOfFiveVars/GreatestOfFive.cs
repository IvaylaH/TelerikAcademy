/*Write a program that finds the greatest of given 5 variables.*/

using System;

    class GreatestOfFive
    {
        static void Main()
        { // The problem is solved in two different ways. This is the first way:
            Console.Write("Please enter a number of your choice ");
            double firstNum = double.Parse(Console.ReadLine());
            Console.Write("Please enter a second number ");
            double secondNum = double.Parse(Console.ReadLine());
            Console.Write("Please enter a third number ");
            double thirdNum = double.Parse(Console.ReadLine());
            Console.Write("Please enter a forth number ");
            double forthNum = double.Parse(Console.ReadLine());
            Console.Write("Please enter a fifth number ");
            double fifthNum = double.Parse(Console.ReadLine());

            double greatestNum = 0;

            if (firstNum < secondNum)
            {
                greatestNum = secondNum;
                if (secondNum < thirdNum)
                {
                    greatestNum = thirdNum;
                    if (thirdNum < forthNum)
                    {
                        greatestNum = forthNum;
                        if (forthNum < fifthNum)
                        {
                            greatestNum = fifthNum;
                            Console.WriteLine("The greatest number is: {0}", fifthNum);
                        }
                        else
                        {
                            greatestNum = forthNum;
                            Console.WriteLine("The greatest number is: {0}", forthNum);
                        }
                    }
                    else
                    {
                        if (thirdNum < fifthNum)
                        {
                            greatestNum = fifthNum;
                            Console.WriteLine("The greatest number is: {0}", fifthNum);
                        }
                        else
                        {
                            greatestNum = thirdNum;
                            Console.WriteLine("The greatest number is: {0}", thirdNum);
                        }
                    }
                }
                    else
                    {
                        if (secondNum < forthNum)
                        {
                            greatestNum = forthNum;
                            if (forthNum < fifthNum)
                            {
                                greatestNum = fifthNum;
                                Console.WriteLine("The greatest number is: {0}", fifthNum);
                            }
                            else
                            {
                                greatestNum = forthNum;
                                Console.WriteLine("The greatest number is: {0}", forthNum);
                            }
                        }
                        else
                        {
                            if (secondNum < fifthNum)
                            {
                                greatestNum = fifthNum;
                                Console.WriteLine("The greatest number is: {0}", fifthNum);
                            }
                            else
                            {
                                greatestNum = secondNum;
                                Console.WriteLine("The greatest number is: {0}", secondNum);
                            }                      
                        }
                    }
            }
            else
            {
                if (firstNum < thirdNum)
                {
                    greatestNum = thirdNum;
                    if (thirdNum < forthNum)
                    {
                        greatestNum = forthNum;
                        if (forthNum < fifthNum)
                        {
                            greatestNum = fifthNum;
                            Console.WriteLine("The greatest number is: {0}", fifthNum);
                        }
                        else
                        {
                            greatestNum = forthNum;
                            Console.WriteLine("The greatest number is: {0}", forthNum);
                        }
                    }
                    else
                    {
                        greatestNum = thirdNum;
                        Console.WriteLine("The greatest number is: {0}", thirdNum);
                    }
                }
                else
                {
                    greatestNum = firstNum;
                    Console.WriteLine("The greatest number is: {0}", firstNum);
                }
            }
            //I saw this solution in the forum. It's much simpler. I really liked it and decided to try it out.

            Console.Write("\nPlease enter a number: ");
            double maxNum = double.Parse(Console.ReadLine());

                for(int i = 1; i < 5; i++)
                {
                    Console.Write("Please enter another number: ");
                    double number = double.Parse(Console.ReadLine());
                    if (maxNum < number)
                    {
                        maxNum = number;
                    }
                }
            Console.WriteLine("\nThe greatest number is: {0}", maxNum);
        }
    }
