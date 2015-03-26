using System;
using System.Collections.Generic;
using System.Text;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public class Tank : Machine, ITank, IMachine
    {
        private const int InitialHealthPoints = 100;
        private const int AttackPointsModifier = 40;
        private const int DefensePointsModifier = 30;
        private bool defenseMode;

        public Tank(string inputName, double attackP, double defenseP)
            : base(inputName, attackP, defenseP, InitialHealthPoints)
        {
            this.ToggleDefenseMode();
        }

        public bool DefenseMode { get; private set; }

        public void ToggleDefenseMode()
        {
            if (this.DefenseMode)
            {
                this.AttackPoints += AttackPointsModifier;
                this.DefensePoints -= DefensePointsModifier;
            }
            else
            {
                this.AttackPoints -= AttackPointsModifier;
                this.DefensePoints += DefensePointsModifier;
            }

            this.DefenseMode = !this.DefenseMode;
        }

        public override string ToString()
        {
            var tankSb = new StringBuilder();

            tankSb.Append(base.ToString());
            string defenseModeAsString = this.DefenseMode ? "ON" : "OFF";
            tankSb.Append(string.Format(" *Defense: {0}", defenseModeAsString));

            return tankSb.ToString();
        }
    }
}
