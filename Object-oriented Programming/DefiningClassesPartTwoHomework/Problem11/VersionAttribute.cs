using System;
using System.Collections.Generic;
using System.Text;

namespace Problem11
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method, AllowMultiple = true)]

    public class VersionAttribute : System.Attribute
    {
        public int Major { get; private set; }
        public int Minor { get; private set; }

        public VersionAttribute(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }

        public override string ToString()
        {
            StringBuilder versionSb = new StringBuilder();

            versionSb.Append(this.Major);
            versionSb.Append(".");
            versionSb.Append(this.Minor);

            return versionSb.ToString();
        }
    }
}
