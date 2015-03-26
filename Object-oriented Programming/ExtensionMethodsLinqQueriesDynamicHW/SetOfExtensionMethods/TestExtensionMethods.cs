/* Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.*/

using System;
using System.Collections.Generic;

namespace SetOfExtensionMethods
{
    public class TestExtensionMethods
    {
        static void Main()
        {
            List<string> listOfStrings = new List<string> 
            {
                "Let's", "try", "these", "extension", "methods", "and", "see", "if", "they", "work", "properly"
            };

            List<double> listOfDoubles = new List<double>
            {
                1.3, 5.6, 2, 0, 4, 15, 6, 8.2, 0.5, 13
            };

            // when applied to List<string> methods Min and Max - compare the elements and returns the (min) first in lexicographical order and (max) the last in lexicographical order
            // mehtod .Sum() works properly and concataenates the elements in the list
            // methods Product() and Average() cannot be implemented because the operators '*' and '/' cannot be applied on objects of type string
            Console.WriteLine("Results from the implementation of our extension methods to List<string>");
            Console.WriteLine(".Sum() -> {0}", listOfStrings.Sum());
            Console.WriteLine(".Min() -> {0}", listOfStrings.Min());
            Console.WriteLine(".Max() -> {0}", listOfStrings.Max());

            Console.Write(Environment.NewLine);

            // all extension methods work properly
            Console.WriteLine("Results from the implementation of our extension methods to List<double>");
            Console.WriteLine(".Sum() -> {0}", listOfDoubles.Sum());
            Console.WriteLine(".Product() -> {0}", listOfDoubles.Product());
            Console.WriteLine(".Average() -> {0}", listOfDoubles.Average());
            Console.WriteLine(".Min() -> {0}", listOfDoubles.Min());
            Console.WriteLine(".Max() -> {0}", listOfDoubles.Max());
        }
    }
}
