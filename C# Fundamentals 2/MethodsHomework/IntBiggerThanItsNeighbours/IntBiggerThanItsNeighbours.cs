/*Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).*/

using System;
using System.Collections.Generic;

class IntBiggerThanItsNeighbours
{
    static bool CheckNeighbours(int[] numArr, int p)
    {
        int searchedElement = numArr[p - 1];
        bool isBigger = false;

        int result = Math.Max(Math.Max(numArr[p - 2], searchedElement), numArr[p]);
        if (result == searchedElement)
        {
           isBigger = true;
        }

        return isBigger;
    }
    static int CheckN(string number)
    {
        int num = 0;
        bool checkN = int.TryParse(number, out num);

        while (!checkN && num < 1)
        {
            Console.WriteLine("Invalid input!");
            Console.WriteLine("For n, please enter a positive integer number, greater than or equal to 1.");
            Console.Write("number = ");

            number = Console.ReadLine();
            checkN = int.TryParse(number, out num);
        }

        return num;
    }

    static int CheckElementsAndP(string number)
    {
        int num = 0;
        bool checkElements = int.TryParse(number, out num);

        while (!checkElements)
        {
            Console.WriteLine("Invalid input!");
            Console.WriteLine("Please enter an integer number!");

            number = Console.ReadLine();
            checkElements = int.TryParse(number, out num);
        }
        
        return num;
    }

    static void Main()
    {
        Console.WriteLine("Please enter a positive integer number for the length of the array, ");
        Console.Write("number = ");
        string number = Console.ReadLine();
        int n = CheckN(number);

        int[] numArr = new int[n];

        for (int i = 0; i < numArr.Length; i++)
        {
            Console.Write("Element {0} = ", i);

            number = Console.ReadLine();
            numArr[i] = CheckElementsAndP(number);
        }

        Console.WriteLine("Please enter a positive integer number for the position we'll be checking, ");
        Console.Write("p = ");

        number = Console.ReadLine();
        number = number.TrimStart('-');
        int p = CheckElementsAndP(number);

        if (p == 0 || (p - 1) == numArr.Length - 1) //if p gives us the first or the last element of the array
        {                                           //the program will not perform a check on the element, since it has only 
                                                    //one neighbour, not 2
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("The element at position {0} has only 1 neighbour element, so we cannot perform the check!", p);

            Console.BackgroundColor = ConsoleColor.Black;
        }
        else                    //in the rest of the cases the program will perform the check and will print "true"
        {                       //if the element is bigger than both its neighbours and "false" when its bigger than either
                                //just one of the neighbours, or than none of the them
            bool isBigger = CheckNeighbours(numArr, p);

            Console.Write("The element at position {0} of the present array is bigger than both its 2 neighbours? ", p);
            if (isBigger)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(" " + isBigger + " ");

                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(" " + isBigger + " ");

                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
    }
}
