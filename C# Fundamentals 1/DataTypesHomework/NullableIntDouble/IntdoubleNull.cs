/*Create a program that assigns null values to an integer and to double variables. Try to print them on the console, try to add some values or the null literal to them and see the result. */

using System;
class IntDoubleNull
{
    static void Main()
    {
        int a = 7;
        int? aNull = null;
        int b = 10;
        double d = 15.3;
        double? dNull = null;
        Nullable<int> nothing = null;
        Nullable<double> dNothing = null;

        Console.WriteLine(nothing + "," + dNothing);

        Console.WriteLine("{0}", aNull);
        Console.WriteLine(dNull);

        aNull = b;
        Console.WriteLine(aNull);
        dNull = d;
        Console.WriteLine(dNull);

        Console.WriteLine(aNull.HasValue);
        a = aNull.Value;
        Console.WriteLine(a);

        dNull = null;
        Console.WriteLine(dNull.HasValue);

        d = dNull.GetValueOrDefault();
        Console.WriteLine(d + 1);
    }
}