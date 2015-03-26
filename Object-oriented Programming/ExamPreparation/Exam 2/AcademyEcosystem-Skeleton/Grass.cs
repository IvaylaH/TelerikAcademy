using System;

namespace AcademyEcosystem
{
    public class Grass : Plant 
    {
        // constructors
        public Grass(Point location)
            : base(location, 2)
        {

        }

        // methods
        public override void Update(int time)
        {
            if (this.IsAlive)
            {
                for (int i = 0; i < time; i++)
                {
                    Grow();
                }
            }
        }

        private void Grow()
        {
            this.Size++;
        }
    }
}
