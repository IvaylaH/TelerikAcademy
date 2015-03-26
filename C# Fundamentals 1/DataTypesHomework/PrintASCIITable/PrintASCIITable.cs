/*Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console.*/

using System;

    class PrintASCIITable
    {
        static void Main()
        {
           Console.OutputEncoding = System.Text.Encoding.UTF8;

            for (int counter = 32; counter < 128; counter++)
            {
                Console.WriteLine("The symbol at number {0} in the ASCII table is '{1}' \n", counter, (char)counter);
            }
        }
    }
