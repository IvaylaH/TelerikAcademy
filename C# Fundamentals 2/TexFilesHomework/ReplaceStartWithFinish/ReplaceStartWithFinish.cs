/* Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file. Ensure it will work with large files (e.g. 100 MB).*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class ReplaceStartWithFinish
{
    static void Main()
    {
        StreamReader reader = new StreamReader("startText.txt");
        StreamWriter writer = new StreamWriter("finishText.txt", false);

        string line = reader.ReadLine();
        string word = "start";

        using (reader)
        {
            using (writer)
            {
                while (line != null)
                {
                    writer.WriteLine(line.Replace(word, "finish"));
                    line = reader.ReadLine();
                }   
            }
        }
    }
}
