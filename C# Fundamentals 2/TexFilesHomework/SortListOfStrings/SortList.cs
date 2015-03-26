/* Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. Example:
	Ivan			George
	Peter			Ivan
	Maria			Maria
	George			Peter*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class SortList
{
    static void Main()
    {
        StreamReader reader = new StreamReader("List.txt");
        StreamWriter writer = new StreamWriter("sortedList.txt");

        string line = reader.ReadLine();
        List<string> unsortedList = new List<string>();

        using (reader)
        {
            while (line != null)
            {
                unsortedList.Add(line);
                line = reader.ReadLine();
            }
        }

        unsortedList.Sort();

        using (writer)
        {
            foreach (var element in unsortedList)
            {
                writer.WriteLine(element);
            }
        }
    }
}
