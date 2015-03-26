using System;

namespace Problem3_AnimalHierarchy
{
    class Kitten : Cat
    {
        // fields

        // constructors
        public Kitten(int age, string name)
            : base(age, name)
        {
            this.IsFemale = true;
        }

        // properties
        
    }
}
