/*Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.*/

using System;

class MaxIncreasingSequence
{
    static void Main()
    {
        Console.WriteLine("Please enter a positive integer number for the length of the array");
        Console.Write("n = ");
        string length = Console.ReadLine();
        int n;
        bool check = int.TryParse(length, out n);

        while (check == false || n <= 0)
        {
            Console.WriteLine("Invalid input!");
            Console.WriteLine("For n, please enter a positive integer number greater than 0.");
            length = Console.ReadLine();
            check = int.TryParse(length, out n);
        }

        char[] myArr = new char[n];
        for (int i = 0; i < myArr.Length; i++)
        {
            myArr[i] = char.Parse(Console.ReadLine());
        }

        int maxCounter = 0;
        int startIndex = 0;
        int endIndex = 0;

        for (int i = 0; i < myArr.Length - 1; i++)
        {
            int counter = 1;
            int temp = (int)myArr[i];
            for (int j = i + 1; j < myArr.Length; j++) //!!
            {
                if ((int)myArr[j] == temp + 1) //!!!
                {
                    temp = (int)myArr[j];
                    counter++;
                }
                else
                {
                    break;
                }

                if (maxCounter < counter)
                {
                    maxCounter = counter;
                    startIndex = i;
                    endIndex = j;
                }
            }
        }
        if (maxCounter != 0)
        {
            Console.WriteLine("In the current array there IS an increasing sequence of consecutive elements.");
            Console.WriteLine("The sequnce has {0} elements.", maxCounter);
            Console.WriteLine("The increasing sequence is: ");
            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.Write(myArr[i] + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("In the current array there is NO increasing sequence of consecutive elements.");
        }
    }
}
