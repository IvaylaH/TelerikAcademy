/*Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]). Each of the numbers that will be added could have up to 10 000 digits.*/

using System;
using System.Collections.Generic;
using System.Numerics;

class AddTwoPositiveInts
{
    static BigInteger[] InitializeArrays(BigInteger[] numArr, string number)        //initializing the arrays
    {
        for (int i = 0; i < numArr.Length; i++)
        {
            numArr[i] = (BigInteger)(number[number.Length - i - 1] - '0');
        }

        return numArr;
    }

    static string AddTheTwoNumbers(BigInteger[] firstNum, BigInteger[] secondNum)
    {
        List<BigInteger> result = new List<BigInteger>();
        int minLength = Math.Min(firstNum.Length, secondNum.Length);
        int maxLength = Math.Max(firstNum.Length, secondNum.Length);
        BigInteger[] maxNum = new BigInteger[maxLength];

        if (firstNum.Length > secondNum.Length)
	    {
            maxNum = firstNum;
	    }
        else
        {
            maxNum = secondNum;
        }

        int carryTens = 0;
        int remainder = 0;
        int sum = 0;

        for (int i = 0; i < minLength; i++)
        {
            sum = (int)(firstNum[i] + secondNum[i] + carryTens);
            carryTens = 0;
            remainder = sum % 10;
            result.Add(remainder);

            if (sum > 9)
            {
                carryTens = sum / 10;
            }
        }

        for (int i = minLength; i < maxLength; i++)
        {
            if (carryTens != 0)
            {
                sum = (int)maxNum[i] + carryTens;
                carryTens = 0;
                remainder = sum % 10;
                result.Add(remainder);

                if (sum > 9)
                {
                    carryTens = sum / 10;
                }
            }
            else
            {
                result.Add(maxNum[i]);
            }
        }

        result = ReverseResult(result);
        string sumOfNumbers = string.Join("", result);
        return sumOfNumbers;
    }

    static List<BigInteger> ReverseResult(List<BigInteger> result)
    {
        List<BigInteger> reverseResult = new List<BigInteger>();

        for (int i = 0; i < result.Count; i++)
        {
            reverseResult.Add(result[result.Count - 1 - i]);
        }

        return reverseResult;
    }

    static BigInteger CheckInput(string number)
    {
        BigInteger num = 0;
        bool checkInput = BigInteger.TryParse(number, out num);

        while (!checkInput || num < 1)
        {
            Console.WriteLine("Invalid input!");
            Console.WriteLine("In order to proceed, please enter a positive integer number greater than or equal to 1.");
            Console.Write("number = ");

            number = Console.ReadLine();
            checkInput = BigInteger.TryParse(number, out num);
        }
        
        return num;
    }
    static void Main()
    {
        BigInteger firstNum = 0;
        BigInteger secondNum = 0;
        int countNums = 1;
        int firstNumLength = 0;
        int secondNumLength = 0;
        string firstNumToStr = "";
        string secondNumToStr = "";

        while (countNums <= 2)          //checking the input and initializing the 2 numbers and their corresponding arrays
        {
            Console.WriteLine("Please enter the {0} positive integer number: ", countNums);
            Console.Write("number = ");
            string number = Console.ReadLine();

            if (countNums == 1)
            {
                firstNumToStr = number;
                firstNum = CheckInput(number);                                  //initializing the first number
                firstNumLength = number.Length;
            }
            else
            {
                secondNumToStr = number;
                secondNum = CheckInput(number);                                 //initializing the second number
                secondNumLength = number.Length;
            }

            countNums++;
        }
        BigInteger[] firstNumArr = new BigInteger[firstNumLength];       //declaring the first []
        firstNumArr = InitializeArrays(firstNumArr, firstNumToStr);            //initializing the first []

        BigInteger[] secondNumArr = new BigInteger[secondNumLength];      //declaring the second []
        secondNumArr = InitializeArrays(secondNumArr, secondNumToStr);          //initializing the second []

        string addTheTWoNums = AddTheTwoNumbers(firstNumArr, secondNumArr);

        Console.WriteLine("The result of the addition of the 2 numbers is: {0} ", addTheTWoNums);
    }
}
