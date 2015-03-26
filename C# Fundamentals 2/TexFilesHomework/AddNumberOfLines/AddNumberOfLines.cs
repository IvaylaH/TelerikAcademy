/* Write a program that reads a text file and inserts line numbers in front of each of its lines. The result should be written to another text file.*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class AddNumberOfLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader("lyrics.txt");
        StreamWriter writer = new StreamWriter("numberedLines.txt", false);

        int lineNumber = 0;
        string line = reader.ReadLine();

        using (writer)
        {
            using (reader)
            {
                while (line != null)
                {
                    lineNumber++;
                    writer.WriteLine("Line {0} -> {1}", lineNumber, line);
                    line = reader.ReadLine();
                }
            }
        }
    }
}
