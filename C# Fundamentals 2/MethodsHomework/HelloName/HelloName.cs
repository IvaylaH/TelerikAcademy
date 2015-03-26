/*Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). Write a program to test this method.*/

using System;
using System.Collections.Generic;

class HelloName
    //the problem was easy so I decided to play a little bit. First I'm using '1' and '2' to indicate whether the user is male
    //or female (having 2 different methods corresponding to the 2 genders
    //if the input is different than '1' or '2' two other methods check, first, if it is an integer number greater than 0 and
    //then if the input == '1' or '2'

{
    static void AskNameMale()           //if n == 1, the method for male name will be called
    {
        Console.Write("Mr, please enter your first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Mr, pLease enter your second name: ");
        string secondName = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Hello, {0}!", firstName);

        if (secondName != "")
        {
            Console.WriteLine("Hello, Mr. {0}!", secondName);
            Console.WriteLine("Hello, Mr. {0}!", firstName + " " + secondName);   
        }
    }
    static void AskNameFemale()         //if n == 2, the method for a female name will be called
    {
        Console.Write("Mrs, please enter your first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Mrs, please enter your second name: ");
        string secondName = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Hello, {0}!", firstName);

        if (secondName != "")
        {
            Console.WriteLine("Hello, Mrs. {0}!", secondName);
            Console.WriteLine("Hello, Mrs. {0}!", firstName + " " + secondName);
        }
    }

    static int AskForNewInput(string number)        //if the input is a positive int number different than '1' or '2'
    {                                               //it will call for this method and ask for correct input
        Console.BackgroundColor = ConsoleColor.DarkRed;       //the method we'll stop it's operation when for n we get 
        Console.WriteLine();                                  //either '1' or '2'
        Console.WriteLine("In order to print the greeting, ");
        Console.WriteLine("you must first enter '1' for male and '2' for female, ");
        Console.WriteLine("else the program won't work correctly!");
        Console.WriteLine("\nPlease start over and this time enter either 1, or 2 for number!");

        Console.BackgroundColor = ConsoleColor.Black;
        Console.Write("number = ");
        number = Console.ReadLine();

        int n = CheckInput(number);
        return n;
    }

    static int CheckInput(string number)            //this method checks if the input is a positive integer number
    {                                               //greater than 0, if the input is accurate it will continue it's operation
        int num = 0;                                //else it will keep asking for correct input
        bool check = int.TryParse(number, out num);

        if (!check && num < 0)
        {
            Console.WriteLine("Invalid input!");
            Console.WriteLine("Please enter a positive integer number greater than 0.");
            Console.Write("number = ");
            number = Console.ReadLine();
            check = int.TryParse(number, out num);
        }

        return num;
    }
    static void Main()
    {
        Console.WriteLine("PLease enter '1' for male and '2' for female, ");
        Console.Write("number = ");
        string number = Console.ReadLine();
        int n = CheckInput(number);

        if (n == 1)
        {
            AskNameMale();
        }
        else if (n == 2)
        {
            AskNameFemale();
        }
        else
        {
            while (n != 1 && n != 2) //we this loop I ensure that the program we'll keep asking for correct input, until such
            {                        //is provided and it can print "Hello <name>" on the console 
                n = AskForNewInput(number);   
            }

            if (n == 1)
            {
                AskNameMale();
            }
            else if (n == 2)
            {
                AskNameFemale();
            }
        }
    }
}
