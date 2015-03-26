/* Write a program to return the string with maximum length from an array of strings. Use LINQ.*/

using System;
using System.Linq;

namespace ReturnStringWithMaxLength
{
    public class StringWithMaxLength
    {
        static void Main()
        {
            string[] stringArr = new string[] 
            {
                "This" , "is", "my", "string", "array.", "This", "program", "will", "find", "the", "element", "with", "max", "length", "from", "the", "string[]"
            };

            Console.WriteLine("Solution using extension method .Aggregate() and lambda expressions: ");

            string maxString = stringArr.Aggregate((str1, str2) => str1.Length > str2.Length ? str1 : str2);

            Console.WriteLine("The element with max length in our string[] is: \"{0}\". Its length is: {1}", maxString, maxString.Length);

            Console.WriteLine("Solution using Linq: ");

            maxString =
                ((from str in stringArr
                orderby str.Length descending
                select str).First());

            Console.WriteLine("The element with max length in our string[] is: \"{0}\". Its length is: {1}", maxString,
                maxString.Length);
        }
    }
}
