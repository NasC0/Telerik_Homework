using System;
using System.Text;

namespace StringBuilderExtend
{
    public static class StringBuilderSubstring
    {
        public static StringBuilder Substring(this StringBuilder str, int index, int length)
        {
            string newString = str.ToString();
            StringBuilder result = new StringBuilder();
            result.Append(newString.Substring(index, length));
            return result;
        }
    }
}

