using System;

namespace AcademyEcosystem
{
    public class Lion : Animal, ICarnivore
    {
        // constructors
        public Lion(string lionsName, Point initialPosition)
            : base(lionsName, initialPosition, 6)
        {

        }

        // methods
        public int TryEatAnimal(Animal animal)
        {
            if (animal != null)
            {
                if (animal.Size <= (2 * (this.Size)))
                {
                    this.Grow();
                    return animal.GetMeatFromKillQuantity();
                }
            }

            return 0;
        }

        private void Grow()
        {
            this.Size++;
        }
    }
}
