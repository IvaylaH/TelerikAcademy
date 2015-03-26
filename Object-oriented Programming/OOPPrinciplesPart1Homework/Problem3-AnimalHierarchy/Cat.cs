using System;

namespace Problem3_AnimalHierarchy
{
    public abstract class Cat : Animal
    {
        // constructors
        public Cat(int age, string name)
            : base(age, name)
        {
            
        }

        // methods
        public override void MakeSound()
        {
            Console.WriteLine("All cats \"purr\"");
            Console.WriteLine("And all cats say \"Meowww!\"");
        }
    }
}
