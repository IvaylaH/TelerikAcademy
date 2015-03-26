/* Write a program that deletes from a text file all words that start with the prefix "test". Words contain only the symbols 0...9, a...z, A…Z, _.*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class DeleteWordsWithPrefixTest
{
    static void Main()
    {
        StreamReader reader = new StreamReader("textText.txt");
        StreamWriter writer = new StreamWriter("processedText.txt");

        string line = reader.ReadLine();

        while (line != null)
        {
            writer.WriteLine(Regex.Replace(line, @"\btest\w*\b", String.Empty));
            line = reader.ReadLine();
        }

        reader.Close();
        writer.Close();
    }
}
       