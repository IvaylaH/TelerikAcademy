/*Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?*/

using System;
class FloatDoubleVars
{
    static void Main()
    {
        double firstValue = 34.567839023;
        float secondValue = 12.345f;
        double thirdValue = 8923.1234857;
        float forthValue = 3456.091f;
        float result = (float)firstValue + secondValue + forthValue;

        Console.WriteLine("{0} + {1} = {2}", firstValue, thirdValue, firstValue + thirdValue);
        Console.WriteLine(secondValue + forthValue);
        Console.WriteLine("{0} + {1} = {2}", firstValue, secondValue, (float)firstValue + secondValue);
        Console.WriteLine((float)thirdValue - forthValue);
        Console.WriteLine("Result = " + (((float)firstValue + secondValue) - forthValue));
        Console.WriteLine("{3} = {0} + {1} + {2}.", (float)firstValue, secondValue, forthValue, result);
    }
}