/* Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.*/

using System;
using System.Text;

namespace SubstringExtensionMethod
{
    public class TestExtensionMethod
    {
        static void Main()
        {
            // input
            string myStr = "Let's test this extension method";

            Console.WriteLine("Please enter a positive integer number for the start index");
            Console.Write("index = ");

            int index = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a positive integer number for the length of the substring");
            Console.Write("length = ");

            int length = int.Parse(Console.ReadLine());

            StringBuilder strToSb = new StringBuilder(myStr);
            strToSb = strToSb.Substring(index, length);

            Console.Write(Environment.NewLine);
            Console.WriteLine("The result from the Substring() is: \"" + strToSb.ToString() + "\"");
        }
    }
}
