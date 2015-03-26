/*Write a method that counts how many times given number appears in given array. Write a test program to check if the method is working correctly.*/

using System;
using System.Collections.Generic;

class CountAppearances
{
    static int[] SortArray(int[] myArr) //using the "selection sort" algorithm to sort the array
    {
        int iMax = 0;
        int swap = 0;

        for (int i = 0; i < myArr.Length - 1; i++)
        {
            iMax = i;
            for (int j = i + 1; j < myArr.Length; j++)
            {
                if (myArr[iMax] > myArr[j])
                {
                    iMax = j;
                }
            }

            swap = myArr[iMax];
            myArr[iMax] = myArr[i];
            myArr[i] = swap;
        }

        return myArr;
    }

    static void SearchForK(int[] myArr, int k)
    {
        int count = 0;

        for (int i = 0; i < myArr.Length; i++)
        {
            if (myArr[i] == k)
            {
                count++;
            }

            if (count != 0 && myArr[i + 1] != k)    //since the array has been sorted, if we have already found an occurence of 
            {                                   //'k' among the elements of the array and the next element is different than k 
                break;                          //we'll break the loop since the next iterations won't find new occurence of 'k'
            }
        }

        if (count == 0)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Number {0} does not appear in the searched array! ", k);

            Console.BackgroundColor = ConsoleColor.Black;

        }
        else
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Number {0} appears {1} times in the present array! ", k, count);

            Console.BackgroundColor = ConsoleColor.Black;
        }
    }

    static int CheckInput(string number)
    {
        int num = 0;
        bool check = int.TryParse(number, out num);

        while (!check)
        {
            Console.WriteLine("Invalid input!");
            Console.WriteLine("Please enter an integer number other than 0.");
            Console.Write("number = ");

            number = Console.ReadLine();
            check = int.TryParse(number, out num);
        }
        return num;
    }

    static void Main()
    {
        Console.WriteLine("Please enter a positive integer number for the length of the array: ");
        Console.Write("number = ");
        string number = Console.ReadLine();
        number = number.TrimStart('-');         //if the entered number is negative, I first trim the '-' (n must be a positive
        int n = CheckInput(number);             //integer number) and then check whether the input is a number

        int[] myArr = new int[n];

        for (int i = 0; i < myArr.Length; i++)
        {
            Console.Write("Element {0} = ", i + 1); //the elments of the array can be either positive or negative integers
                                                    //therefore, I do not need to trim the '-' and only check if the input is a 
            number = Console.ReadLine();            //number or a string
            myArr[i] = CheckInput(number);
        }

        string arrToStr = string.Join(" ", myArr);

        Console.WriteLine("The present program will check whether an int[] contians a certain number k and if it does, will count k's occurences in the [].");
        Console.WriteLine("For k, please enter a number of your choice, ");
        Console.Write("k = ");
        number = Console.ReadLine();
        int k = CheckInput(number);

        myArr = SortArray(myArr);
        string sortedArr = string.Join(" ", myArr);
        SearchForK(myArr, k);
    }
}
