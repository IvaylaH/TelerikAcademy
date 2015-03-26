/*Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. Print the obtained array on the console.*/

using System;

class ArrayOf20Ints
{
    static void Main()
    {
        int[] numbers = new int[20];

        for (int index = 0; index < numbers.Length; index++)
        {
            numbers[index] = index * 5;
        }

        string numbersToStr = string.Join(", ", numbers);
        Console.WriteLine(numbersToStr);
    }
}
