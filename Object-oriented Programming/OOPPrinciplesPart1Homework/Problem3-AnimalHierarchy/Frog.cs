using System;

namespace Problem3_AnimalHierarchy
{
    class Frog : Animal
    {
        // constructors
        public Frog(int age, string name, string sex)
            : base(age, name, sex)
        {

        }

        // methods
        public override void MakeSound()
        {
            Console.WriteLine("All frogs make a \"gobble\" sound.");
            Console.WriteLine("And they say \"Gobble-gobble!\"");
        }
    }
}
