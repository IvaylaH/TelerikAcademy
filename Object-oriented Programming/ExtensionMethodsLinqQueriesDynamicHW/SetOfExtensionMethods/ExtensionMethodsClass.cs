using System;
using System.Collections.Generic;
using System.Linq;


namespace SetOfExtensionMethods
{
    public static class ExtensionMethodsClass
    {
        public static T Sum<T>(this IEnumerable<T> enumeration)
        {
            dynamic sum = default(T);

            foreach (var element in enumeration)
            {
                sum += element; // should I put dynamic here ??!?
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> enumeration)
        {
            dynamic product = default(T);

            foreach (var element in enumeration)
            {
                product *= element;   
            }

            return product;
        }

        public static T Min<T>(this IEnumerable<T> enumeration)
            where T : IComparable
        {
            dynamic min = enumeration.First();
            
            foreach (var element in enumeration)
            {
                if (element.CompareTo(min) < 0)
                {
                    min = element;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> enumeration)
            where T: IComparable<T>
        {
            dynamic max = enumeration.First();

            foreach (var element in enumeration)
            {
                if (element.CompareTo(max) > 0)
                {
                    max = element;   
                }
            }

            return max;
        }

        public static T Average<T>(this IEnumerable<T> enumeration)
        {
            T sum = enumeration.Sum();
            T average = sum / (dynamic)enumeration.Count();

            if (enumeration.Count() == 0)
            {
                throw new ArgumentException("The collection is empty!");
            }

            return average;
        }
    }
}
