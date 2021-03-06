﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Rock : StaticObject, IResource
    {
        private int quantity;

        public Rock(int hitPoints, Point position)
            : base(position)
        {
            this.HitPoints = hitPoints;
            this.Quantity = this.HitPoints / 2;
        }

        public int Quantity
        {
            get { return this.quantity; } // better version -> get { return this.HitPoints / 2; } then we do not need the field and the setter
            private set
            {
                this.quantity = value;
            }
        }

        public ResourceType Type
        {
            get { return ResourceType.Stone; }
        }
    }
}
