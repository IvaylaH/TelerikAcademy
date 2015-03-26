using System;

namespace Problem3_AnimalHierarchy
{
    class Dog : Animal
    {
        // constructors
        public Dog(int age, string name, string sex)
            : base(age, name, sex)
        {

        }

        // methods
        public override void MakeSound()
        {
            Console.WriteLine("All dogs \"bark\"");
            Console.WriteLine("And they say \"Waf-waf!\"");
        }
    }
}
