/*
 - 11. Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
		x2 + 5 = 1x2 + 0x + 5 
 - 12. Extend the program to support also subtraction and multiplication of polynomials.*/

using System;
using System.Collections.Generic;
using System.Text;

class Polynomials
{
    static decimal[] AddPolynomials(decimal[] coefficients1, decimal[] coefficients2)   //add the 2 polynomials
    {
        int arrLength;
        int longerPolynom;
        int commonLength; 

        DeterminArrLength(coefficients1, coefficients2, out arrLength, out commonLength, out longerPolynom);
        
        decimal[] addedCoefficients = new decimal[arrLength];

        for (int i = 0; i < arrLength; i++)
        {
            if (i < commonLength)       //while i < (the length of the shorter array, we add/subtract the corresponding elements
            {                                                                   //of the first and second coefficient arrays
                addedCoefficients[i] = coefficients1[i] + coefficients2[i];
            }
            else if (i >= commonLength && longerPolynom == 1)           //if longerPolynom == 1, I add the rest of the elements
            {                                                           //of the first coefficients array until I fill the
                addedCoefficients[i] = coefficients1[i];                //addedCoefficients array
	        }
            else if (i >= commonLength && longerPolynom == 2)           //here is the same, I only use the elements of the 
            {                                                           //second coefficients array, since it's the longer []
                addedCoefficients[i] = coefficients2[i];
            }
        }

        return addedCoefficients;
    }

    static decimal[] SubtractPolynomials(decimal[] coefficients1, decimal[] coefficients2)      //subtract the 2 polynomials
    {
        int arrLength;
        int commonLength;
        int longerPolynom;

        DeterminArrLength(coefficients1, coefficients2, out arrLength, out commonLength, out longerPolynom);

        decimal[] subtractedCoefficients = new decimal[arrLength];

        for (int i = 0; i < arrLength; i++)
        {
            if (i < commonLength)       //while i < (the length of the shorter array, we add/subtract the corresponding elements
            {                                   //of the first and second coefficient arrays
                if (coefficients2[i] < 0)
                {
                    subtractedCoefficients[i] = coefficients1[i] + ((coefficients2[i]) * (-1));
                }
                else
                {
                    subtractedCoefficients[i] = coefficients1[i] - coefficients2[i];
                }
            }
            else if (i >= commonLength && longerPolynom == 1)           //if longerPolynom == 1, I add the rest of the elements
            {                                                           //of the first coefficients array until I fill the
                subtractedCoefficients[i] = coefficients1[i] * (-1);    //subtactedCoefficients array
            }
            else if (i >= commonLength && longerPolynom == 2)           //here is the same, I only use the elements of the 
            {                                                           //second coefficients array, since it's the longer []
                subtractedCoefficients[i] = coefficients2[i] * (-1);
            }
        }

        return subtractedCoefficients;
    }

    static decimal[] MultiplyPolynomials (decimal[] coefficients1, decimal[] coefficients2) //multiplies the 2 polynomials
    {
        int arrLength = arrLength = (coefficients1.Length - 1) + (coefficients2.Length - 1) + 1;

        decimal[] multipliedCoefficients = new decimal[arrLength];

        for (int i = 0; i < coefficients1.Length; i++)
        {
            for (int j = 0; j < coefficients2.Length; j++)
            {
                if (i == 0)
                {
                    multipliedCoefficients[i + j] = coefficients1[i] * coefficients2[j];   
                }
                else
                {
                    multipliedCoefficients[i + j] += (coefficients1[i] * coefficients2[j]);
                }
            }
        }

        return multipliedCoefficients;
    }

    static void DeterminArrLength(decimal[] coefficients1, decimal[] coefficients2, out int arrLength, out int commonLength, out int longerPolynom)                                     
    {                                                       //use this method to find the length of the array that is going
        arrLength = 0;                                      //to hold the coefficients for the addition and subtraction methods
        longerPolynom = 0;

        if (coefficients1.Length > coefficients2.Length)
        {
            arrLength = coefficients1.Length;
            longerPolynom = 1;                  //I use this variable to determine which is the longer array
        }
        else
        {
            arrLength = coefficients2.Length;
            longerPolynom = 2;
        }

        commonLength = Math.Min(coefficients1.Length, coefficients2.Length);    //commonLength will be the length of the 
    }                                                                           //shorter array

    static string BuildPolynomial(decimal[] coefficients)       //I use this method so I can build the polynomial
    {
        StringBuilder polynomial = new StringBuilder();         //I wanted print the polynomial in the format:
                                                                //(... + a^x3 + b^x2 + c^x + d)
        polynomial.Append("(");                                 //therefore the program performs so many checks
                                                                //I've also tried to skip adding a coefficiet when it equals 0
        for (int i = 0; i < coefficients.Length; i++)           //(e.g) b == 0, so the above will be: (a^x3 + c^x + d)
        {                                                       //also when we have (a^x2) and 'a' == 1 or 'a' == -1
            if (i == 0 && coefficients[i] != 0)                 //I tried to make it add only (x2), for 'a' == 1 and (-x2) for
            {                                                   //'a' == -1
                polynomial.AppendFormat("{0}", coefficients[i]);
            }                                                   //hope I succeded covering all the cases
            else if (i == 0 && coefficients[i] == 0)            //and sorry for the endless sequence of 'else if' statements
            {
                polynomial.Append("");
            }
            else if (i != 0 && coefficients[i] != 0)
            {
                if (i == 1 && coefficients[i - 1] != 0 && coefficients[i] == 1)
                {
                    polynomial.AppendFormat(" + x{0}", i); 
                }
                else if (i == 1 && coefficients[i - 1] == 0 && coefficients[i] == 1)
                {
                    polynomial.AppendFormat("x{0}", i); 
                }
                else if (i == 1 && coefficients[i - 1] == 0 && coefficients[i] != 1)
                {
                    polynomial.Append(coefficients[i]);
                    polynomial.AppendFormat("^x{0}", i); 
                }
                else if (i == 1 && coefficients[i - 1] != 0 && coefficients[i] != 1 && coefficients[i] > 0)
                {
                    polynomial.AppendFormat(" + {0}", coefficients[i]);
                    polynomial.AppendFormat("^x{0}", i);
                }
                else if (i == 1 && coefficients[i - 1] != 0 && coefficients[i] != 1 && coefficients[i] < 0)
                {
                    polynomial.AppendFormat(" {0}", coefficients[i]);
                    polynomial.AppendFormat("^x{0}", i);
                }
                else if (i == 1 && coefficients[i - 1] != 0 && coefficients[i] == - 1)
                {
                    polynomial.AppendFormat(" - x{0}", i);
                }
                else if (i == 1 && coefficients[i - 1] == 0 && coefficients[i] == - 1)
                {
                    polynomial.AppendFormat("- x{0}", i);
                }
                else if (i > 1 && coefficients[i] == 1)
                {
                    polynomial.AppendFormat(" + x{0}", i);
                }
                else if (i > 1 && coefficients[i] != 1 && coefficients[i] != - 1)
                {
                    polynomial.AppendFormat(" + {0}", coefficients[i]);
                    polynomial.AppendFormat("^x{0}", i); 
                }
                else if (coefficients[i] < 0 && coefficients[i] == - 1)
                {
                    polynomial.AppendFormat(" - x{0}", i);
                }
                else if (coefficients[i] < 0 && coefficients[i] != - 1)
                {
                    polynomial.AppendFormat(" {0}", coefficients[i]);
                    polynomial.AppendFormat("^x{0}", i);
                }
            }
        }

        polynomial.Append(")");
        string polynomStr = string.Join("",polynomial);

        return polynomStr;
    }
    static void Main()
    {
     /*   Console.WriteLine("Please enter coeficients for the first polynomial: ");
        List<decimal> fPolynomialCoefficients = new List<decimal>();
        fPolynomialCoefficients.Add(decimal.Parse(Console.ReadLine()));*/

        decimal[] fPolynomialCoefficients = { 5, 1};
        string firstPolynom = BuildPolynomial(fPolynomialCoefficients);

        decimal[] sPolynomialCoefficients = { 5, -6, 1};
        string secondPolynom = BuildPolynomial(sPolynomialCoefficients);

        //adding the 2 polynomials

        Console.WriteLine("First, let's add the 2 polynomials: ");

        decimal[] result = AddPolynomials(fPolynomialCoefficients, sPolynomialCoefficients);
        string resultStr = BuildPolynomial(result);

        Console.Write(firstPolynom + " + " + secondPolynom + " = " + resultStr);

        //subtracting the 2 polynomials

        Console.WriteLine();
        Console.WriteLine("\nSecond, let's subtract the 2 polynomials: ");

        result = SubtractPolynomials(fPolynomialCoefficients, sPolynomialCoefficients);
        resultStr = BuildPolynomial(result);

        Console.Write(firstPolynom + " - " + secondPolynom + " = " + resultStr);

        //multiplying the 2 polynomials

        Console.WriteLine();
        Console.WriteLine("\nThird, let's multiply the 2 polynomials: ");

        result = MultiplyPolynomials(fPolynomialCoefficients, sPolynomialCoefficients);
        resultStr = BuildPolynomial(result);

        Console.WriteLine(firstPolynom + " * " + secondPolynom + " = " + resultStr);
        Console.WriteLine();
    } 
}
