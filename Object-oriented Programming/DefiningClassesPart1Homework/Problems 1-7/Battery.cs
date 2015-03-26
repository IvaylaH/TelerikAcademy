using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_1_7
{
    class Battery
    {
        // private fields
        private string model;
        private double? hoursIdle;
        private double? hoursTalk;
        private BatteryType batteryType;

        enum BatteryType { LiIon, NiMH, NiCD };

        // properties
   /*     public string Model
        {
            get 
            {
                return this.model; }
            set 
            {
               this.model = value;
            }
        }

        public double? HoursIdle 
        {
            get 
            {
                return this.hoursIdle;
            }
            set 
            {
                if (hoursIdle < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid input! The value you're entering should enter a positive number.");
                }
                else
                {
                    this.hoursIdle = value; 
                }
            }
        }

        public double? HoursTalk
        {
            get 
            {
                return this.hoursTalk;
            }
            set
            {
                if (hoursTalk < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid input! The value you're entering should enter a positive number.");
                }
                else
                {
                    this.hoursTalk = value;
                }
            }
        }*/

        //constructors
        public Battery()
        {
            this.model = null;
            this.hoursIdle = null;
            this.hoursTalk = null;
            this.batteryType = BatteryType.LiIon;
        }

        public Battery(string model)
        {
            this.model = model;
            this.hoursIdle = null;
            this.hoursTalk = null;
            this.batteryType = BatteryType.LiIon;
        }

        public Battery(string model, double hoursIdle, double hoursTalk)
        {
            this.model = model;
            if (hoursIdle < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid input! The value you're entering should enter a positive number.");
            }
            else
            {
                this.hoursIdle = hoursIdle;       
            }
            if (hoursTalk < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid input! The value you're entering should enter a positive number.");
            }
            else
            {
                this.hoursTalk = hoursTalk;
            }
            this.batteryType = BatteryType.LiIon;
        }

        public override string ToString()
        {
            return string.Format("Model: {0} Battery Type: {1} Hours Idle: {2} Hours Talk: {3}", model, batteryType, hoursIdle, hoursTalk);
        }
    }
}
