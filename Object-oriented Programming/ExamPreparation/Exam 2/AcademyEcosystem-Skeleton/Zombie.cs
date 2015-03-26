using System;

namespace AcademyEcosystem
{
    public class Zombie : Animal
    {
        // fields 
        private const int MeatFromZombie = 10;

        // constructors
        public Zombie(string zombiesName, Point initialPosition)
            : base(zombiesName, initialPosition, 0)
        {

        }

        // methods
        public override int GetMeatFromKillQuantity()
        {
         //   this.IsAlive = true;
            return MeatFromZombie;
        }
    }
}
