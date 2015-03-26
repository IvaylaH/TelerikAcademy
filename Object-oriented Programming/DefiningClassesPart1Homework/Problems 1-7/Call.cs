using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_1_7
{
    class Call
    {
        public string Date { get; set; }
        public string Time { get; set; }
        public string DialedPhoneNum { get; set; }
        public int Duration { get; set; }
        
        public Call(string date, string time, string dialedPhoneNum, int duration)
        {
            this.Date = date;
            this.Time = time;
            this.DialedPhoneNum = dialedPhoneNum;
            this.Duration = duration;
        }

        public override string ToString()
        {
            StringBuilder callsSb = new StringBuilder();

            callsSb.Append("Date of the call: " + Date);
            callsSb.Append(Environment.NewLine);
            callsSb.Append("Time of the call: " + Time);
            callsSb.Append(Environment.NewLine);
            callsSb.Append("The call was with number: " + DialedPhoneNum);
            callsSb.Append(Environment.NewLine);
            callsSb.Append("Duration of the call: " + Duration);
            callsSb.Append(Environment.NewLine);

            return callsSb.ToString();
        }
    }
}
