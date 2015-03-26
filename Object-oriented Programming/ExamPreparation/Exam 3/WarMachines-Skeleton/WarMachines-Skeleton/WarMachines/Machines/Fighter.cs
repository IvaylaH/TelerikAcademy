using System;
using System.Collections.Generic;
using System.Text;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public class Fighter : Machine, IFighter, IMachine
    {
        private const int InitialHealthPoints = 200;

        public Fighter(string inputName, double attackP, double defenseP, bool initialStealthMode)
            : base(inputName, attackP, defenseP, InitialHealthPoints)
        {
            this.StealthMode = initialStealthMode;
        }

        public bool StealthMode  {get; private set; }
        public void ToggleStealthMode()
        {
            this.StealthMode = !this.StealthMode;
        }


        public override string ToString()
        {
            var tankSb = new StringBuilder();

            tankSb.Append(base.ToString());
            string stealthModeAsString = this.StealthMode ? "ON" : "OFF";
            tankSb.Append(string.Format(" *Stealth: {0}", stealthModeAsString));

            return tankSb.ToString();
        }
    }
}
