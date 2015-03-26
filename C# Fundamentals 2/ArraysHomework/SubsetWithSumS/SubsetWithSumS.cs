/* We are given an array of integers and a number S. Write a program to find if there exists a subset of the elements of the array that has a sum S. Example:
	arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6)*/

using System;
using System.Collections.Generic;
using System.Text;

class SubsetWithSumS
{
    static int checkNumber(string strNumber)
    {
        int num = 0;
        bool check = int.TryParse(strNumber, out num);

        while (check == false && num <= 0)
        {
            Console.WriteLine("Invalid input!");
            Console.WriteLine("For n and s, please enter a number greater than or equal to 1!");
            strNumber = Console.ReadLine();
            check = int.TryParse(strNumber, out num);
        }

        return num;
    }

    static int checkElements(string strNumber)
    {
        int num = 0;
        bool check = int.TryParse(strNumber, out num);

        while (check == false)
        {
            Console.WriteLine("Invalid input!");
            Console.WriteLine("The array accepts only integer numbers as values, so please enter an int number of your choice: ");
            strNumber = Console.ReadLine();
            check = int.TryParse(strNumber, out num);
        }

        return num;
    }
    static void Main()
    {
        Console.WriteLine("Please enter a positive integer number for the length of the array,");
        Console.Write("n = ");
        int n = checkNumber(Console.ReadLine());

        int[] myArr = new int[n];

        Console.WriteLine("Please enter the elements of the array:");

        for (int i = 0; i < n; i++)
        {
            myArr[i] = checkElements(Console.ReadLine());
        }

        Console.WriteLine("Please enter the sum we'll be looking for, ");
        Console.Write("s = ");
        int s = checkNumber(Console.ReadLine());

        List<int> subset = new List<int>();
        string printSubset = null;

        int maxIterations = (int)(Math.Pow((double)2, n)) - 1;
        bool hasSubset = false;
        int count = 0;

        for (int i = 1; i < maxIterations; i++)
        {
            int currentSum = 0;
            subset.Clear();

            for (int j = 0; j < myArr.Length; j++)
            {
                int mask = 1 << j;
                int iAndMask = i & mask;
                int bit = iAndMask >> j;

                if (bit == 1)
                {
                    currentSum += myArr[j];
                    subset.Add(myArr[j]);
                }
            }

            if (currentSum == s)
            {
                hasSubset = true;
                count++;

                if (count > 1)
                {
                    printSubset += " ; ";
                    printSubset += string.Join(" ", subset);
                }
                else
                {
                    printSubset += string.Join(" ", subset);
                }
                subset.Clear(); 
            }
            else
            {
                subset.Clear();
            }
        }

        Console.WriteLine();
        Console.WriteLine("Is there a subset in the present array whose elements have sum equal to {0}? ", s);
      //  Console.WriteLine(hasSubset == true ? hasSubset + "( " + printSubset + " = " + s + ")" : hasSubset);

        string[] numsToPrint = printSubset.Split(' ');
    /*    if (hasSubset)
        {
            Console.Write(hasSubset + " ");
            if (count > 1)
            {
                for (int i = 0; i < printSubset.Length - 1; i++)
                {
                    if (printSubset[i] != ';' && printSubset[i] != ' ' && printSubset[i + 1] != ';')
                    {
                        Console.Write(printSubset[i] + " + ");   
                    }
                    else if (printSubset[i] != ';' && printSubset[i] != ' ' && (printSubset[i + 1] == ';' || printSubset[i + 1] == printSubset.Length - 1))
                    {
                        Console.Write(printSubset[i]);
                    }
                    else if (printSubset[i] == ' ' && printSubset[i + 1] == printSubset[printSubset.Length - 1])
                    {
                        Console.Write(printSubset[i + 1]);
                    }
                    if (printSubset[i + 1] == ';' || printSubset[i + 1] == printSubset[printSubset.Length - 1])
                    {
                        Console.WriteLine(" = {0}", s);
                    }
                }

            }
            else
            {
                for (int i = 0; i < printSubset.Length; i++)
                {
                    if(printSubset[i] != ' ' && i != printSubset.Length - 1)
                    { 
                        Console.Write(printSubset[i] + " + ");
                    }
                    else if (printSubset[i] != ' ' && (i == printSubset.Length - 1 || printSubset.Length == 1))
                    {
                        Console.Write(printSubset[i]);
                    }
                }
                Console.WriteLine(" = {0}", s);
            }
        }
        else
        {
            Console.WriteLine(hasSubset);
        }*/
        if (hasSubset)
        {
            Console.WriteLine(hasSubset);

            for (int i = 0; i < numsToPrint.Length - 1; i++)
            {
                if (numsToPrint[i] != ";")
                {
                    if (numsToPrint[i + 1] == ";" || i + 1 == numsToPrint.Length - 1)
                    {
                        if (i + 1 == numsToPrint.Length - 1)
                        {
                            Console.WriteLine(numsToPrint[i] + " + " + numsToPrint[i + 1] +" = {0}", s);
                        }
                        else
                        {
                            Console.WriteLine(numsToPrint[i] + " = {0}", s);
                        }
                    }
                    else
                    {
                        Console.Write(numsToPrint[i] + " + ");
                    }
                }
            }
        }
        else
        {
            Console.WriteLine(hasSubset);
        }
    }
}
