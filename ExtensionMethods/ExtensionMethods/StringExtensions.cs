using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class StringExtensions
    {
        public static string RemoveWhiteSpaces(this string str)
        {
            return str.Replace(" ", "");
        }
        public static string Reverse1(this string str)
        {
            var charArray = str.ToCharArray();
            Array.Reverse(charArray);
            //return string.Join("", charArray);
            return new string(charArray);
        }
    }
}
