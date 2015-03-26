/*Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. */

using System;

class NumbersNSum
{
  static void Main()
  {
      Console.Write("Please enter a number for n, n = ");
      int n = int.Parse(Console.ReadLine());
      double sum = 0;

      for (int i = 0; i < n; i++)
      {
          Console.Write("Please enter number of your choice: ");
          double nextNum = double.Parse(Console.ReadLine());
          sum += nextNum;
      }
      Console.WriteLine("The sum of all {0} numbers is: {1:f3}", n, sum);
  }
}
