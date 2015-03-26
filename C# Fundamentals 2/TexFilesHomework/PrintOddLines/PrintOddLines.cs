/* Write a program that reads a text file and prints on the console its odd lines.*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class PrintOddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader("If.txt");
        StreamWriter writer = new StreamWriter("onlyOdd.txt", false);

        int lineNumber = 0;
        string line = reader.ReadLine();

        while (line != null)
        {
            if (lineNumber % 2 != 0)
            {
                Console.WriteLine("Line {0}: {1}", lineNumber, line);
                writer.WriteLine(line);
            }

            line = reader.ReadLine();
            lineNumber++;
        }

        reader.Close();
        writer.Close();
    }
}
