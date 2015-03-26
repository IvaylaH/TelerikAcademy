using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_1_7
{
    class GSM
    {
        // private fields - ensures encapsulation
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery GSMBattery;
        private Display GSMDisplay;
        private static GSM iPhone4S;

        private List<Call> callHistory = new List<Call>();

        public List<Call> CallHistory
        {
            get 
            {
                return this.callHistory; 
            }
            set 
            {
                this.callHistory = value;
            }
        }
        

        // properties - they allow us to access the fields safely - again ensures encapsulation
        public string Model
        {
            get 
            {
                return this.model; 
            }
            set 
            {
                this.model = value; 
            }
        }

        public string Manufacturer
        {
            get 
            {
                return this.manufacturer; 
            }
            set 
            { 
                this.manufacturer = value;
            }
        }

        public decimal? GSMPrice
        {
            get 
            { 
                return this.price;
            }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid input! The value of the price should be a positive number.");
                }
                else
                {
                    this.price = value;       
                } 
            }
        }

        public string Owner
        {
            get 
            {
                return this.owner;
            }
            set 
            {
                this.owner = value;
            }
        }

        // declared the properties for Battery and Display here, so that I get their characteristics and print them with the characterics of the GSM class

        //TODO: to try if the program would still print the characteristics of Battery and Display if their properties are declared inside the classes themselves and not in the GSM class
        public Battery Battery
        {
            get
            {
                return this.GSMBattery;
            }
            set
            {
                this.GSMBattery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.GSMDisplay;
            }
            set
            {
                this.GSMDisplay = value;
            }
        }

        public static GSM IPhone4S // declaration of the iPhone4S static property 
        {
            get
            {
                return new GSM("iPhone 4S", "Apple", 540m, null, "someBat", 8.5, 4.5, 7.3, 225000000);
            }
        }

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.GSMPrice = null;
            this.Owner = null;
            this.GSMBattery = new Battery();
            this.GSMDisplay = new Display();
        }

        public GSM(string model, string manufacturer, decimal gsmPrice, string owner)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.GSMPrice = gsmPrice;
            this.Owner = owner;
        }

        public GSM(string model, string manufacturer, decimal gsmPrice, string owner, string batteryModel, double batteryIdleH, double batteryTalkH, double displaySize, int displayColors)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.GSMPrice = gsmPrice;
            this.Owner = owner;
            this.GSMBattery = new Battery(batteryModel, batteryIdleH, batteryTalkH);
            this.GSMDisplay = new Display(displaySize, displayColors);
        }

        public override string ToString()
        {
            return "GSM Info: Model: " + Model + " Manufacturer: " + Manufacturer + " Price: " + GSMPrice + " Owner: " + Owner + "; Battery --> " + GSMBattery + "; Display --> " + GSMDisplay;
        }

        // methods for adding and deleting calls to the CallHistory and Clearing the CallHistory
        public void AddCalls(string date, string time, string dialedPhoneNum, int duration)
        {
            callHistory.Add(new Call(date, time, dialedPhoneNum, duration));
        }

        public void DeleteCalls(Call removeThisCall)
        {
            callHistory.Remove(removeThisCall);
        }

        public void ClearCallHistory()
        {
            callHistory.Clear();
        }

        public string CalculateTotalBill(int duration, decimal fixedPrice)
        {
            decimal bill = 0;

            foreach (Call finishedCall in callHistory) //this.callHistory ?? should I put it and if Yes, WHY!?!
            {
                bill += finishedCall.Duration * fixedPrice;
            }

            return string.Format("{0:F2}", bill); // to try and add it to the Main method, so this method could return decimal values
        }
    }
}
