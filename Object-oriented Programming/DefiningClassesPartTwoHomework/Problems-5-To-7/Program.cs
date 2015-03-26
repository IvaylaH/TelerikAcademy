using System;
using System.Collections.Generic;
using System.Text;

namespace Problems_5_To_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a positive interger number for the capacity of our list: ");
            Console.Write("capacity = ");
            int listCapacity = int.Parse(Console.ReadLine());

            // creating an instance of class GenericList
            GenericList<int> listOfInts = new GenericList<int>(listCapacity);

            // filling the list
            Console.WriteLine("Please enter the element you would like to add to the end of our list: ");

            for (int i = 0; i < listOfInts.Capacity - 1; i++)
            {
                Console.Write("element = ");
                int element = int.Parse(Console.ReadLine());

                listOfInts.AddElement(element);    
            }  

            Console.WriteLine("Please enter the index you would like to check");
            Console.Write("index = ");

            int index = int.Parse(Console.ReadLine());
            int number = listOfInts.AccessElementAt(index);
            Console.WriteLine("The element at position {0} is: {1} ", index, number);

            Console.WriteLine("PLease enter the index of the element you would like to remove from our list: ");
            Console.Write("index = ");

            index = int.Parse(Console.ReadLine());
            number = listOfInts.RemoveElementAt(index);
            Console.WriteLine("The element we removed is: {0} ", number);
            Console.WriteLine("The list after the removal: {0}", listOfInts.ToString());

            listOfInts.InsertElementAt(number, index);
            Console.WriteLine("The list after inserting the element back to its original place: {0} ", listOfInts.ToString());

            Console.WriteLine("Please enter the element we'll be looking for in the list: ");
            Console.Write("element = ");
            number = int.Parse(Console.ReadLine());
            bool doesContain = listOfInts.ContainsElement((number));
            Console.WriteLine("The list contains {0}: {1}", number, doesContain);

            listOfInts.AddElement(5);
            Console.WriteLine("The list after adding '5' at the end of it: {0}", listOfInts.ToString());

            listOfInts.AddElement(10);
            Console.WriteLine("The list after adding '10' at the end of it: {0}", listOfInts.ToString());


            int minNumber = GenericAdditionalMethods.Min(listOfInts);
            int maxNumber = GenericAdditionalMethods.Max(listOfInts);

            Console.WriteLine("The minimal number in our list is: {0}", minNumber);
            Console.WriteLine("The maximal number in our list is: {0}", maxNumber);

            listOfInts.Clear();
            Console.WriteLine(listOfInts.ToString());
        }
    }
}
