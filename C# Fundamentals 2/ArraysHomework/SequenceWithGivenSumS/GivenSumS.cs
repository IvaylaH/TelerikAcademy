/*Write a program that finds in given array of integers a sequence of given sum S (if present). Example: {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}*/

using System;
using System.Collections.Generic;
using System.Text;

    class GivenSumS
    {
        static void Main()
        {
            Console.WriteLine("Please enter a positive integer number for the length of the array,");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            int[] numsArr = new int[n];

            Console.WriteLine("Please enter the {0} elements of the array: ", n);
            for (int i = 0; i < n; i++)
            {
                numsArr[i] = int.Parse(Console.ReadLine());
            }

            string arrToString = string.Join(" ", numsArr);
            Console.WriteLine();
            Console.WriteLine(arrToString);

            Console.WriteLine("Please enter a value for the sum we will be looking for, ");
            Console.Write("s = ");
            int s = int.Parse(Console.ReadLine());
            StringBuilder sequence = new StringBuilder();
            string printSequence = null;
            int count = 0;

            for (int i = 0; i < numsArr.Length - 1; i++)
            {
                int tempSum = 0;
                tempSum += numsArr[i];
                sequence.AppendFormat(" " + numsArr[i]);

                int j = i + 1;

                while (j < numsArr.Length)
                {
                    tempSum += numsArr[j];
                    sequence.AppendFormat(" " + numsArr[j]);

                    if (tempSum == s)
                    {
                        count++;
                        if (count == 1)
                        {
                            printSequence = sequence.ToString() + " ";
                        }
                        else
                        {
                            printSequence += (sequence.ToString() + " ");
                        }
                        sequence.Clear();
                    }
                    else if (tempSum > s)
                    {
                        sequence.Clear();
                        break;
                    }
                    j++;
                }
            }

            Console.WriteLine();
            if (count != 0)
            {
                if (count == 1)
                {
                    Console.WriteLine("In the present array there is {0} sequence with sum equal to {1}", count, s);
                    Console.WriteLine("It is: {0} ", printSequence);
                }
                else
                {
                    Console.WriteLine("In the present array there are {0} sequence/s with sum equal to {1}", count, s);
                    Console.WriteLine("They are: {0} ", printSequence);
                }
            }
            else
            {
                Console.WriteLine("There is no sequence in the present array with sum equal to {0}", s);
            }
        }
    }
