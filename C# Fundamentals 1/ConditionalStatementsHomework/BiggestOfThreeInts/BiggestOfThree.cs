/*Write a program that finds the biggest of three integers using nested if statements.*/

using System;

    class BiggestOfThree
    {
        static void Main()
        { 
            //I want to appologize in advance, if the code is difficult to read. I used nested if statements only because it was specificly requested in the problem. 

            Console.Write("Please enter a number of your choice: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Please enter a second number: ");
            int secondNum = int.Parse(Console.ReadLine());
            Console.Write("Please enter a third number: ");
            int thirdNum = int.Parse(Console.ReadLine());
            int biggestNum = firstNum;  //I initialized the variable biggestNum with the intend to use it later. 
                                        //While I still have used it and assigned it with new values, 
                                        //I believe it is not crucial for solving the problem.
            if (firstNum == secondNum)
            {
                biggestNum = secondNum;

                Console.WriteLine();
                Console.WriteLine("The first and second number are equal.");
                if (secondNum == thirdNum)
                {
                    biggestNum = thirdNum;

                    Console.WriteLine("The second and third number are equal.");
                    Console.WriteLine("Both the first and third number are equal to the second one, therefore they are both equal to each other.\nSince all three number are equal, none of them is greater than the others.\n");
                }
                else
                {
                    if (secondNum < thirdNum)
                    {
                    biggestNum = thirdNum;

                    Console.WriteLine("The third number is greater than the second one.");
                    Console.WriteLine("Therefore, the third number is the biggest of the three.");
                    }
                    else
                    {
                        Console.WriteLine("The first and second number are equal and are greater than the third one, therefore their value is the biggest.");
                    }
                }     
            }
            else
            {
                if (secondNum == thirdNum)
                {
                    Console.WriteLine();
                    Console.WriteLine("The second and third number are equal");
                    if (firstNum < secondNum)
                    {
                        Console.WriteLine("The second number is greater than the first one.");
                        Console.WriteLine("The second and third number are equal and are greater than the first one, therefore their value is the biggest.");
                    }
                    else
                    {
                        Console.WriteLine("The first number is greater than the second one.");
                        Console.WriteLine("Therefore, it is the biggest of the three.");
                    }
                }
                 else
                    {
                        if (firstNum < secondNum)
                        {
                            biggestNum = secondNum;

                            Console.WriteLine();
                            Console.WriteLine("The second number is greater than the first one.");

                            if (secondNum < thirdNum)
                            {
                            biggestNum = thirdNum;

                            Console.WriteLine("The third number is greater than the second one.");
                            Console.WriteLine("Therefore, the third number is the biggest of the three.");
                            }
                            else
                            {
                                biggestNum = secondNum;

                                Console.WriteLine("The second number is greater than the third one.");
                                Console.WriteLine("Therefore, the second number is the biggest of the three.");
                            }
                        }
                        else 
                        {
                            Console.WriteLine();
                            Console.WriteLine("The first number is greater than the second one.");
                            if (firstNum > thirdNum)
                            {
                                biggestNum = firstNum;

                                Console.WriteLine("The first number is greter than the third one.");
                                Console.WriteLine("Therofore, the first number is the biggest of the three.");
                            }
                            else
                            {
                                biggestNum = thirdNum;

                                Console.WriteLine("The third number is greater than the first one.");
                                Console.WriteLine("Therofore, the third number is the biggest of the three.");
                            }
                        }
                    }
                }
            }                
        }
      