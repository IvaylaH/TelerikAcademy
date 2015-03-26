/*Write a method that returns the maximal element in a portion of array of integers starting at given index. Using it write another method that sorts an array in ascending / descending order.*/

using System;
using System.Collections.Generic;

//TO DO: solving the problem using "quick sort algorithm" to sort the array

class MaxElement
{
    static void FindMaxElementDescending(int[] numsArr, int index, out int maxNumber, out int maxNumIndex)     
    {
        maxNumber = int.MinValue;                       //the method is used for finding the max number in the array
        maxNumIndex = 0;                                //and then for sorting the array in descending order

        for (int i = index; i < numsArr.Length; i++)
        {

            if (maxNumber < numsArr[i])
            {
                maxNumber = numsArr[i];
                maxNumIndex = i;
            }
        }
    }
       
    static void FindMaxElementAscending(int[] numsArr, int index, out int maxNumber, out int maxNumIndex)
    {
        maxNumber = int.MinValue;           //the method is used for sorting the array in ascending order
        maxNumIndex = 0;

        for (int i = numsArr.Length - 1 - index; i >= 0; i--)
        {

            if (maxNumber < numsArr[i])
            {
                maxNumber = numsArr[i];
                maxNumIndex = i;
            }
        }
    }
 
    static void SwapElements(int[] numsArr, int currentNumIndex, int maxNumIndex)
    {                                                               //the method is used for swaping the elements of the array
        if (maxNumIndex != currentNumIndex)                         //while sorting it in either ascending or descending order
        {
            int swap = numsArr[currentNumIndex];

            numsArr[currentNumIndex] = numsArr[maxNumIndex];
            numsArr[maxNumIndex] = swap;   
        }
    }

    static int CheckN(string number)            //checking the input for 'n'
    {
        int num = 0;
        bool checkN = int.TryParse(number, out num);

        while (!checkN || num < 0)
        {
            Console.WriteLine("Invalid input!");
            Console.WriteLine("For'n' or/and 'index', please enter a positive integer number greater than or equal to 0.");
            Console.WriteLine("number = ");

            number = Console.ReadLine();
            checkN = int.TryParse(number, out num);
        }

        return num;
    }

    static int CheckElements(string number, int i)      //checking the input for the elements of the array
    {
        int num = 0;
        bool checkValue = int.TryParse(number, out num);

        while (!checkValue)
        {
            Console.WriteLine("Invalid input!");
            Console.WriteLine("We have an int[], therefore the elements of the [] can only be integer numbers.");
            Console.Write("Element {0} = ", i);

            number = Console.ReadLine();
            checkValue = int.TryParse(number, out num);
        }

        return num;
    }

    static void Main()
    {
        Console.WriteLine("Please enter a positive integer number for the length of the array, ");
        Console.Write("n = ");
        int n = CheckN(Console.ReadLine());

        int[] numsArr = new int[n];

        for (int i = 0; i < numsArr.Length; i++)
        {
            Console.Write("Element {0} = ", i);
            numsArr[i] = CheckElements(Console.ReadLine(), i);
        }

        string arrToStr = string.Join(" ", numsArr);
        Console.WriteLine(arrToStr);

        Console.WriteLine("Please, enter a positive integer number for the index our check should start from, ");
        Console.Write("index = ");
        int index = CheckN(Console.ReadLine());

        int maxElement = 0;
        int maxNumIndex = 0;

        if (index > numsArr.Length)
        {
            Console.WriteLine();
            Console.WriteLine("The program cannot perform the check, since the array we are checking has only {0} elements and for index you have entered the number {1}.", numsArr.Length, index);
        }
        else
        {
             FindMaxElementDescending(numsArr, index, out maxElement, out maxNumIndex);

            Console.WriteLine();
            Console.WriteLine("The maximal element of the array, that is a member of the partion '{0}' - '{1}' is: {2}", index, numsArr.Length - 1, maxElement);
        }


        Console.WriteLine("\nSorting the array in descending order:  ");

        for (int i = 0; i < n - 1; i++)             //sorting the array in descending order using the method for finding the
        {                                           //biggest number in a partition of an array
            
            FindMaxElementDescending(numsArr, i, out maxElement, out maxNumIndex);
            SwapElements(numsArr, i, maxNumIndex);
        }

        string sortingArr = string.Join(" ", numsArr);
        Console.WriteLine(sortingArr);

        Console.WriteLine("\nSorting the array in ascending order");

        for (int i = 0; i < n - 1; i++)
        {
            FindMaxElementAscending(numsArr, i, out maxElement, out maxNumIndex);
            SwapElements(numsArr, numsArr.Length - 1 - i, maxNumIndex);
        }

        sortingArr = string.Join(" ", numsArr);
        Console.WriteLine(sortingArr);
        Console.WriteLine();
    }
}
