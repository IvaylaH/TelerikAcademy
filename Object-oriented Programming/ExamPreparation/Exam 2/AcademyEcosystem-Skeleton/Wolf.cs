using System;
using System.Collections.Generic;

namespace AcademyEcosystem
{
    public class Wolf : Animal, ICarnivore
    {
        // constructors
        public Wolf(string wolfsName, Point initialLocation)
            :base(wolfsName, initialLocation, 4)
        {

        }

        // methods
        public int TryEatAnimal(Animal animal)
        {
            if (animal != null)
            {
                if (animal.Size <= this.Size || animal.State == AnimalState.Sleeping)
                {
                    return animal.GetMeatFromKillQuantity();
                }                
            }

            return 0; // is it OK to leave it like this
        }
    }
}
