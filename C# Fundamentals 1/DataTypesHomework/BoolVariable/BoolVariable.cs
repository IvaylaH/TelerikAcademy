/*Declare a boolean variable called isFemale and assign an appropriate value corresponding to your gender.*/

using System;

class BoolVariable
{
    static void Main()
    {
        bool isFemale = true;

        Console.WriteLine(isFemale);

        // I tried to make it a bit more interesting. First the program will ask for your gender. If you press m/f the program will procede and depending on the gender will print a message. If you press another button the program will stop due to an inappropriate input

        Console.WriteLine("\nIn order to procede with your registration we need to collect information about your gender. Please press F if you are a woman and M if you are a man.");

        ConsoleKeyInfo key = (Console.ReadKey());
        Console.WriteLine();
        char pressedKey = key.KeyChar;
        char female = '\u0066';
        char male = '\u006D';
        bool check = (pressedKey == female) || (pressedKey == male);
        bool isMale = (pressedKey == male);

        if ((check == true) && (isMale == true))
        {
            Console.WriteLine("Dear Mr, you can now procede with your registration.");
        }
        else if ((check == true) && (isMale == false))
        {
            Console.WriteLine("Dear Mrs, you can now procede with your registration.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please start over.");
        }
    }
}
