﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Ninja : Character, IFighter, IGatherer
    {
        private int attackPoints;

        public Ninja(string name, Point position, int owner)
            : base(name, position, owner)
        {
            this.HitPoints = 1;
        }

        public int AttackPoints
        {
            get { return this.attackPoints; }
        }

        public int DefensePoints // what to put for the defense
        {
            get { return int.MaxValue; }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            var strongestEnemy = availableTargets.Max(se => se.HitPoints); // not sure if it's enought

            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != this.Owner && availableTargets[i].Owner != 0 && availableTargets[i].HitPoints == strongestEnemy)
                {
                    return i;
                }
            }

            return -1;
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Lumber)
            {
                this.attackPoints += resource.Quantity;
                return true;
            }

            if (resource.Type == ResourceType.Stone)
            {
                this.attackPoints += (resource.Quantity * 2);
                return true;
            }

            return false;
        }
    }
}
