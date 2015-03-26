/* Write a program that concatenates two text files into another text file.*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class ConcatTwoTextFiles
{
    static void Main()
    {
        StreamReader firstReader = new StreamReader("if.txt");
        StreamReader secondReader = new StreamReader("lyrics.txt");
        StreamWriter writer = new StreamWriter("If-lyrics.txt", false);

        string line = string.Empty;

        using (writer)
        {
            using (firstReader)
            {
                line = firstReader.ReadLine();

                while (line != null)
                {
                    writer.WriteLine(line);
                    line = firstReader.ReadLine();
                }
            }

            writer.WriteLine("\r\n");

            using (secondReader)
            {
                line = secondReader.ReadLine();

                while (line != null)
                {
                    writer.WriteLine(line);
                    line = secondReader.ReadLine();
                }
                     
            }
        }
    }
}
