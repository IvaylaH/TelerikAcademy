using System;
using System.Collections.Generic;

    class QuickSort
    {
        static List<int> QuickSortImplementation(List<int> numbers)
        {
            if (numbers.Count <= 1)
            {
                return numbers;
            }
            int pivot = numbers.Count / 2;
            int pivotValue = numbers[pivot];
            numbers.RemoveAt(pivot);
            List<int> smallerNums = new List<int>();
            List<int> biggerNums = new List<int>();
            foreach (int element in numbers)
            {
                if (element <= pivotValue)
                {
                    smallerNums.Add(element);
                }
                else
                {
                    biggerNums.Add(element);
                }
            }
            List<int> numsAfterSorting = new List<int>();
            numsAfterSorting.AddRange(QuickSortImplementation(smallerNums));
            numsAfterSorting.Add(pivotValue);
            numsAfterSorting.AddRange(QuickSortImplementation(biggerNums));
            return numsAfterSorting;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a positive integer number for the length of the array, ");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();

            Console.WriteLine("Please enter the {0} elements of the array.", n);
            for (int i = 0; i < n; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            string arrBeforeSorting = string.Join(" ", numbers);
            Console.WriteLine();
            Console.WriteLine(arrBeforeSorting);

            List<int> numsAfterSorting = (QuickSortImplementation(numbers));

            Console.WriteLine("The list after sorting it using the Quick Sort algorithm: ");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write("{0} ", numsAfterSorting[i]);
            }
            Console.WriteLine();

            //it gives a mistake and I'm not sure why
            //when it prints the sorted list on the console, it skips the last element (the biggest number)
        }
    }
