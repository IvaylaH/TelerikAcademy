using System;

namespace Problem4_Define_Class_Person
{
    class Program
    {
        static void Main()
        {
            Person personWithAge = new Person("Ivan Angelov", 35);
            Person personWithoutSpecAge = new Person("Petar Petrov");

            Console.WriteLine(personWithAge);
            Console.WriteLine(personWithoutSpecAge);
        }
    }
}
