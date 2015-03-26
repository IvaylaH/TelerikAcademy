/*Write a program that finds the maximal sequence of equal elements in an array.
		Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.*/

using System;

class MaxSequence
{
    static void Main()
    {
        Console.WriteLine("Please enter an integer number for the length of the array you want to check,");
        Console.Write("n = ");
        string number = Console.ReadLine();
        int n;
        bool check = int.TryParse(number, out n); //here I check the input for n

        //the loop ensures that the program will continue only after the input is a positive integer number greater than 0
        while (check == false || n <= 0)
        {
            Console.WriteLine("Invalid input!");
            Console.WriteLine("For n, please enter a positive integer number greater than or equal to 1.");
            number = Console.ReadLine();
            check = int.TryParse(number, out n);
        }

        string[] strArr = new string[n];            // since, the type of the array is not specified in the problem, I use
        for (int i = 0; i < strArr.Length; i++)     // string[] to make sure that both letters and digits can be processed
        {
            strArr[i] = Console.ReadLine();
        }

        int maxSequence = 0;

        for (int i = 0; i < strArr.Length - 1; i++) //since "strArr.Length - 1" is the last element of the array, I want the
		{                                           //for loop to skip it, because there are no elements after it
			string temp = strArr[i];                //the last element is being checked in the while loop and if it is part of
            int counter = 1;                        //a sequence it will be counted;
            int j = i + 1;
            while (j <= strArr.Length - 1)
            {
                if (strArr[i] == strArr[j])
                {
                    counter++;
                }
                else
                {
                    break;
                }
                j++;
                if (maxSequence < counter)
                {
                    maxSequence = counter;
                }
            }
		}
        Console.WriteLine(maxSequence == 0 ? "There is no sequence of equal elements in the current array." : "The maximal sequence of equal elements in the current array is: {0}", maxSequence);
    }
}
