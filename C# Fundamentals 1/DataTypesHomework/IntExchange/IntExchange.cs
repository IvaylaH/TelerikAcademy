/*Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.*/

using System;

class IntExchange
{
    static void Main()
    {
        //Again the problem is solved in two ways. The first way is:
        int firstVar = 5;
        int secondVar = 10;

        firstVar += secondVar;
        secondVar = firstVar - secondVar;
        firstVar -= secondVar;

        Console.WriteLine(" " + firstVar);
        Console.WriteLine(" " + secondVar + "\n");

        // Here I do the same exchange using the bitwise operator ^. As a result both variables get their initial values.
        firstVar ^= secondVar;
        secondVar = firstVar ^ secondVar;
        firstVar = firstVar ^ secondVar;

        Console.WriteLine(" " + firstVar);
        Console.WriteLine(" " + secondVar + "\n");
    }
}
