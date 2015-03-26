using System;
using System.Text;

namespace SubstringExtensionMethod
{
    public static class ExtensionsMethodsClass
    {
        public static StringBuilder Substring(this StringBuilder sb, int index, int length)
        {
            StringBuilder resultSb = new StringBuilder();

            if ((index < 0 && index >= sb.Length) || (length < 0 || ((sb.Length - index + 1) < length)))
            {
                throw new IndexOutOfRangeException("Either the index, or the length is out of the range of the StringBuilder we're working with.");
            }

            for (int i = index; i < index + length; i++)
            {
                resultSb.Append(sb[i]);
            }

            return resultSb;
        }
    }
}
