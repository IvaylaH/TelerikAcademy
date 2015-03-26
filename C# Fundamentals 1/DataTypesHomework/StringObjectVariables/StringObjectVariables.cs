﻿/*Declare two string variables and assign them with “Hello” and “World”. Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval). Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).*/

using System;

class StringObjectVars
{
    static void Main()
    {
        string firstWord = "Hello";
        string secondWord = "World";
        object concatFirstSecond = firstWord + " " + secondWord + "!";
        string objString = (string)concatFirstSecond;

        Console.WriteLine(" \"" + concatFirstSecond + "\"" + " printed as an object.");
        Console.WriteLine(" \"" + objString + "\"" + " printed as a string.\n");
    }
}
