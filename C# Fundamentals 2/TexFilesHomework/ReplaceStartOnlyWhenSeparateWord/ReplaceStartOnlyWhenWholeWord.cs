/* Modify the solution of the previous problem to replace only whole words (not substrings).*/

using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceStartOnlyWhenWholeWord
{
    static void Main()
    {
        StreamReader reader = new StreamReader("startText.txt");
        StreamWriter writer = new StreamWriter("finishText.txt", false);

        string line = reader.ReadLine();

        using (reader)
        {
            using (writer)
            {
                while (line != null)
                {
                    writer.WriteLine(Regex.Replace(line, @"\bstart\b", "finish"));
                    line = reader.ReadLine();
                }   
            }
        }
    }
}