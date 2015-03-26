/* Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different. Assume the files have equal number of lines.*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class CompareTwoFiles
{
    static void Main()
    {
        StreamReader firstReader = new StreamReader("If.txt");
        //StreamReader firstReader = new StreamReader("onlyOdd.txt"); //--> countSame = 0; countDiff = 17;
        StreamReader secondReader = new StreamReader("If+lyrics.txt");

        int countSame = 0;
        int countDiff = 0;

        using (secondReader)
        {
            using (firstReader)
            {
                string firstRLine = firstReader.ReadLine();
                string secondRLine = secondReader.ReadLine();

                while (firstRLine != null && secondRLine != null)
                {
                    if (firstRLine == secondRLine)
                    {
                        countSame++;
                    }
                    else
                    {
                        countDiff++;
                    }

                    firstRLine = firstReader.ReadLine();
                    secondRLine = secondReader.ReadLine();
                }
            }
        }

        Console.WriteLine("Number of equal lines: {0}", countSame);
        Console.WriteLine("Number of different lines: {0}", countDiff);
    }
}
