using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_1_7
{
    class GSMTest
    {
        GSM[] shortArrOfPhones = new GSM[5];
        public StringBuilder result = new StringBuilder();

        public void GetSomePhones(string[] models, string[] manufacturers, decimal[] prices, string[] owners, string[] batteryModel, double[] batHoursIdle, double[] batHoursTalk, double[] displaySize, int[] displayColors)
        {
            for (int i = 0; i < shortArrOfPhones.Length; i++)
            {
                shortArrOfPhones[i] = new GSM(models[i], manufacturers[i], prices[i], owners[i], batteryModel[0], batHoursIdle[0], batHoursTalk[0], displaySize[i], displayColors[0]);
                result.Append(shortArrOfPhones[i]);
                result.Append(Environment.NewLine);
            }
        }

        public override string ToString()
        {
            return result.ToString();
        }
    }
}
