using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public class Pilot : IPilot
    {
        private string name;
        private IList<IMachine> machines;

        public Pilot(string inputName)
        {
            this.Name = inputName;
            this.machines = new List<IMachine>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Pilot name cannot be null");
                }

                this.name = value;
            }
        }

        public void AddMachine(IMachine machine)
        {
            if (machine == null)
            {
                throw new ArgumentNullException("Machine cannot be null");
            }

            this.machines.Add(machine);
        }

        public string Report()
        {
            StringBuilder reportSb = new StringBuilder();

            string pilotName = this.Name;
            string machinesCount = this.machines.Count == 0 ? "no" : this.machines.Count.ToString();
            string pluralOrNot = this.machines.Count == 1 ? "machine" : "machines";
            reportSb.AppendLine(string.Format("{0} - {1} {2}", pilotName, machinesCount, pluralOrNot));

            if (this.machines.Count != 0)
            {
               // reportSb.AppendLine();
                var sortedMachines = this.machines.
                    OrderBy(mc => mc.HealthPoints).
                    ThenBy(mc => mc.Name);

                foreach (var machine in sortedMachines)
                {
                    reportSb.AppendLine(machine.ToString());
                }
            }

            return reportSb.ToString().TrimEnd();
        }
    }
}
