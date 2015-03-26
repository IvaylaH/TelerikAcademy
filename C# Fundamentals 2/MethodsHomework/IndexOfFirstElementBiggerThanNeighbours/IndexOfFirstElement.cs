/*Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.
Use the method from the previous exercise.*/

using System;
using System.Collections.Generic;

class IndexOfFirstElement
{
    static void CheckNeighbours(int[] numArr, out int index, out int checkedElement)
    {
        index = - 1;
        int result = 0;
        checkedElement = 0;

        for (int i = 1; i < numArr.Length - 1; i++)
        {
            checkedElement = numArr[i];
            if (numArr[i - 1] != checkedElement && checkedElement != numArr[i + 1])
            {
                result = Math.Max(Math.Max(numArr[i - 1], checkedElement), numArr[i + 1]);   
            }

            if (result == checkedElement)
            {
                index = i;
                break;
            }
        }
    }
    static int CheckInput(string number)
    {
        int num = 0;
        bool check = int.TryParse(number, out num);

        while (!check)
        {
            Console.WriteLine("Invalid input!");
            Console.WriteLine("Please enter an integer number!");
            Console.Write("number = ");

            number = Console.ReadLine();
            check = int.TryParse(number, out num);
        }

        return num;
    }

    static void Main()
    {
        Console.WriteLine("Please enter a positive integer number for the length of the array, ");
        Console.Write("number = ");
        string number = Console.ReadLine();

        number = number.TrimStart('-');
        int n = CheckInput(number);

        int[] numArr = new int[n];

        for (int i = 0; i < numArr.Length; i++)
        {
            Console.Write("Element {0} = ", i);

            number = Console.ReadLine();
            numArr[i] = CheckInput(number);
        }

        int index = 0;
        int elementValue = int.MinValue;
        CheckNeighbours(numArr, out index, out elementValue);

        if (index == -1)
        {
            Console.WriteLine();
            Console.WriteLine("In the present array there is no such element that is bigger than both its neighbours.");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("The first element of the present array, ");
            Console.WriteLine("that is bigger than both his neighbours is at index {0} --> element \"{1}\".", index, elementValue);
        }
    }
}
