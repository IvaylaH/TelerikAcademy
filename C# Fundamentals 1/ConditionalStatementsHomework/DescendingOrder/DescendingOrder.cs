/*Sort 3 real values in descending order using nested if statements.*/

using System;

    class DescendingOrder
    {
        static void Main()
        {
            Console.Write("Please enter a real number of your choice: ");
            double firstNum = double.Parse(Console.ReadLine());
            Console.Write("Please enter a second real number: ");
            double secondNum = double.Parse(Console.ReadLine());
            Console.Write("Please enter a third real number: ");
            double thirdNum = double.Parse(Console.ReadLine());

            if (firstNum == secondNum)
            {
                Console.WriteLine();
                Console.WriteLine("The first and second number are equal.");
                if (secondNum == thirdNum)
                {
                    Console.WriteLine("The second and third number are equal.");
                    Console.WriteLine("Therefore, the numbers in a sequence look like this: {0}, {1}, {2}.", firstNum, secondNum, thirdNum);
                }
                else
                {
                    if (secondNum > thirdNum)
                    {
                        Console.WriteLine("The second number is greater than the third one.");
                        Console.WriteLine("Therefore, the numbers in descending order are: {0}, {1}, {2}.", firstNum, secondNum, thirdNum);
                    }
                    else
                    {
                        Console.WriteLine("The third number is greater than the second one.");
                        Console.WriteLine("Therefore, the numbers in descending order are: {0}, {1}, {2}.", thirdNum, firstNum, secondNum);
                    }
                }
            }
            else
            {
                if (secondNum == thirdNum)
                {
                    Console.WriteLine();
                    Console.WriteLine("The second and third number are equal.");

                    if (firstNum < secondNum)
                    {
                        Console.WriteLine("The second number is greater than the first one.");
                        Console.WriteLine("Therefore, the numbers in descending order are: {0}, {1}, {2}.", secondNum, thirdNum, firstNum);
                    }
                    else
                    {
                        Console.WriteLine("The first number is greater than the second one.");
                        Console.WriteLine("Therefore, the numbers in descending order are: {0}, {1}, {2}.", firstNum, secondNum, thirdNum);
                    }
                }
                else
                {
                    if (firstNum < secondNum)
                    {
                        Console.WriteLine();
                        Console.WriteLine("The second number is greater than the first one.");
                        if (secondNum < thirdNum)
                        {
                            Console.WriteLine("The third number is greater than the second one.");
                            Console.WriteLine("Therefore, the numbers in descending order are: {0}, {1}, {2}.", thirdNum, secondNum, firstNum);
                        }
                        else
                        {
                            Console.WriteLine("The second number is greater than the third one.");
                            if (firstNum < thirdNum)
                            {
                                Console.WriteLine("The third number is greater than the first one.");
                                Console.WriteLine("Therefore, the numbers in descending order are: {0}, {1}, {2}.", secondNum, thirdNum, firstNum);
                            }
                            else
                            {
                                Console.WriteLine("The first number is greater than the third one.");
                                Console.WriteLine("Therefore, the numbers in descending order are: {0}, {1}, {2}.", secondNum, firstNum, thirdNum);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("The first number is greater than the second one.");
                        if (secondNum > thirdNum)
                        {
                            Console.WriteLine("The second number is greater than the third one.");
                            Console.WriteLine("Therefore, the numbers in descending order are: {0}, {1}, {2}.", firstNum, secondNum, thirdNum);
                        }
                        else
                        {
                            Console.WriteLine("The third number is greater than the second one.");
                            if (firstNum > thirdNum)
                            {
                                Console.WriteLine("The first number is greater than the third one.");
                                Console.WriteLine("Therefore, the numbers in descending order are: {0}, {1}, {2}.", firstNum, thirdNum, secondNum);
                            }
                            else
                            {
                                Console.WriteLine("The third number is greater than the first one.");
                                Console.WriteLine("Therefore, the numbers in descending order are: {0}, {1}, {2}.", thirdNum, firstNum, secondNum);
                            }
                        }
                    }
                }
            }
        }
    }
