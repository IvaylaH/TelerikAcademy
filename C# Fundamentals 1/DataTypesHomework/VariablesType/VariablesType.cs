/*Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.*/

using System;
class VaraiblesType
{
    static void Main()
    {
        ushort firstValue = 52130;
        sbyte secondValue = -115;
        int thirdValue = 4825932;
        byte forthValue = 97;
        short fifthValue = -10000;

        Console.WriteLine("1. {0} is of type ushort.", firstValue);
        Console.WriteLine("2. {0} is of type sbyte.", secondValue);
        Console.WriteLine("3. {0} is of type int.", thirdValue);
        Console.WriteLine("4. {0} is of type byte.", forthValue);
        Console.WriteLine("5. {0} is of type short.", fifthValue);
    }
}