/* Write a program that deletes from given text file all odd lines. The result should be in the same file.*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class DeleteAllOdd
{
    static void Main()
    {
        StreamReader reader = new StreamReader("If.txt");

        string line = reader.ReadLine();
        List<string> onlyEvenLines = new List<string>();
        int count = 1;

        using (reader)
        {
            while (line != null)
            {
                if (count % 2 == 0)
                {
                    onlyEvenLines.Add(line);
                }

                line = reader.ReadLine();
                count++;
            } 
        }

        StreamWriter writer = new StreamWriter("If.txt", false);

        using (writer)
        {
            foreach (var evenLine in onlyEvenLines)
            {
                writer.WriteLine(evenLine);
            }
        }
    }
}
