/* Write a program that extracts from given XML file all the text without the tags. Example:*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class ExtractTextFromXML
{
    static void Main()
    {
        StreamReader reader = new StreamReader("XMLfile.txt");
        StringBuilder inputToSb = new StringBuilder();

        inputToSb.Append(reader.ReadLine()); //closing reader
        int startIndex = 0;
        int endIndex = 0;
        bool startTag = false;
        bool endTag = false;

        while (true)
        {
            if (inputToSb[startIndex] == '<' && startIndex != inputToSb.Length)
            {
                //  startIndex = 0;
                startTag = true;

                while (!endTag)
                {
                    endIndex++;

                    if (inputToSb[endIndex] == '>' && endIndex < inputToSb.Length)
                    {
                        endTag = true;
                    }
                }

                inputToSb.Remove(startIndex, (endIndex + 1) - startIndex);
                endIndex = startIndex;
                startTag = false;
                endTag = false;

                if (endIndex == inputToSb.Length)
                {
                    break;
                }
            }
            else if (char.IsLetterOrDigit(inputToSb[0]))
            {
                startIndex = 0;
                endIndex = 1;

                while (inputToSb[endIndex] != '<' && endIndex < inputToSb.Length)
                {
                    endIndex++;
                }

                startIndex = endIndex; //!!
                if (endIndex != inputToSb.Length)
                {
                    endIndex += 1;
                }
                else
                {
                    break;
                }
            }
        }

        reader.Close();

        Console.WriteLine(inputToSb.ToString());
    }
}