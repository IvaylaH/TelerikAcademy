using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_5_To_7
{
    public static class GenericAdditionalMethods
    {
        public static T Min<T>(this GenericList<T> myList)
            where T: IComparable<T>
        {
            T min = myList[0];

            for (int i = 0; i < myList.Count; i++)
			{
			    if (myList[i].CompareTo(min) < 0)
	            {
		            min = myList[i];
	            }
			}

            return min;
        }

        public static T Max<T>(this GenericList<T> myList)
            where T: IComparable<T>
        {
            T max = myList[0];

            for (int i = 0; i < myList.Count; i++)
			{
			    if (myList[i].CompareTo(max) > 0)
	            {
		             max = myList[i];
	            }
			}

            return max;
        }
    }
}
