/* Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations and methods and holds a version in the format major.minor (e.g. 2.11). Apply the version attribute to a sample class and display its version at runtime.*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Problem11
{
    [Version(2, 11)]
    public class MySampleClass
    {
        private string productName;
        private string manufacturer;

        public MySampleClass(string product, string manufacturerName)
        {
            this.productName = product;
            this.manufacturer = manufacturerName;
        }

        public string ProductName { get; set; }
        public string Manufacturer { get; set; }

        static void Main(string[] args)
        {

            MySampleClass product = new MySampleClass("Some Name", "Microsoft");

            Type type = typeof(MySampleClass);

            object[] allAttributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute attr in allAttributes)
            {
                Console.WriteLine("Product name: \"{0}\".", product.productName);
                Console.WriteLine("Manufacturer: \"{0}\".", product.manufacturer);
                Console.WriteLine("Version: {0}", attr);
            }

        }
    }
}
