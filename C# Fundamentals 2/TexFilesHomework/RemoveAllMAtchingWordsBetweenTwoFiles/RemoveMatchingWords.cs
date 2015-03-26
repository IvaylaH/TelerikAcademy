/* Write a program that removes from a text file all words listed in given another text file. Handle all possible exceptions in your methods.*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class RemoveMatchingWords
{
    static void Main()                  //used a solution from the forum to write this one;
    {                                   //but I think that mine's not working properly
        try
        {
            StreamReader reader = new StreamReader("If.txt");
            StreamWriter writer = new StreamWriter("revisedText.txt", false);
            string expression = @"\b(" + string.Join("|", File.ReadAllLines("wordsToSearchFor.txt")) + @")\b";

            string line = reader.ReadLine();

            while (line != null)
	        {
	            writer.WriteLine(Regex.Replace(line, expression, string.Empty));
                line = reader.ReadLine();
	        }
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
