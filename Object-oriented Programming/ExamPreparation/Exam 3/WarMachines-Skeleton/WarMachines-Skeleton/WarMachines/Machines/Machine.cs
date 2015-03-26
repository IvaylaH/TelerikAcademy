using System;
using System.Collections.Generic;
using System.Text;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public abstract class Machine : IMachine
    {
        private string name;
        private IPilot pilot;
        private IList<string> targets;

        public Machine(string inputName,  double attackP, double defenseP, double healthP)
        {
            this.Name = inputName;
            this.AttackPoints = attackP;
            this.DefensePoints = defenseP;
            this.targets = new List<string>();
            this.HealthPoints = healthP;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Machine name cannot be null or empty");
                }

                this.name = value;
            }
        }

        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Machine cannt be engaged by a null pilot");
                }

                this.pilot = value;
            }
        }

        public double HealthPoints { get ; set; }

        public double AttackPoints { get; protected set; }

        public double DefensePoints { get; protected set; }

        public IList<string> Targets
        {
            get { return new List<string>(targets); }
        }

        public void Attack(string target)
        {
            if (string.IsNullOrEmpty(target))
            {
                throw new ArgumentNullException("Target cannot be null or empty");
            }

            this.targets.Add(target);
        }

        public override string ToString()
        {
            var printSb = new StringBuilder();

            string targetsAsString = this.targets.Count == 0 ? "None" : string.Join(", ", this.targets);

            printSb.AppendLine(string.Format("- {0}", this.Name));
            printSb.AppendLine(string.Format(" *Type: {0}", this.GetType().Name));
            printSb.AppendLine(string.Format(" *Health: {0}", this.HealthPoints));
            printSb.AppendLine(string.Format(" *Attack: {0}", this.AttackPoints));
            printSb.AppendLine(string.Format(" *Defense: {0}", this.DefensePoints));
            printSb.AppendLine(string.Format(" *Targets: {0}", targetsAsString));

            return printSb.ToString();
        }
    }
}
