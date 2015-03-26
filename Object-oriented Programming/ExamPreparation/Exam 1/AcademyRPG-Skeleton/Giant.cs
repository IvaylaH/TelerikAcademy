using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Giant : Character, IFighter, IGatherer
    {
        private int gatheredStones = 0;
        private int attackPoints = 150;

        public Giant(string name, Point position, int owner = 0)
            : base(name, position, owner)
        {
            this.HitPoints = 200;
            this.attackPoints = 150;
        }

        public int AttackPoints
        {
            get { return this.attackPoints; }
        }

        public int DefensePoints
        {
            get { return 80; }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != 0)
                {
                    return i;
                } 
            }

            return -1;
        }

        public bool TryGather(IResource resource)
        {
            if (gatheredStones != 0)
            {
                return false;
            }

            if (resource.Type == ResourceType.Stone)
            {
                gatheredStones++;
                this.attackPoints += 100;
                return true;
            }

            return false;
        }
    }
}
