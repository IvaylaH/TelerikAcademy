using System;

namespace AcademyEcosystem
{
    public class Boar : Animal, ICarnivore, IHerbivore
    {
        // field
        private const int BitSize = 2;

        // constructors
        public Boar(string boarName, Point initialLocation)
            : base(boarName, initialLocation, 4)
        {

        }

        // methods
        public int TryEatAnimal(Animal animal)
        {
            if (animal != null)
            {
                if (animal.Size <= this.Size)
                {
                    return animal.GetMeatFromKillQuantity();
                }   
            }

            return 0;
        }

        public int EatPlant(Plant plant)
        {
            if (plant != null)
            {
                this.Grow();
                return plant.GetEatenQuantity(BitSize);                
            }

            return 0;
        }

        private void Grow()
        {
            this.Size++;
        }
    }
}
