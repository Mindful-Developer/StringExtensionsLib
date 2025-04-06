using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtensionsLib
{
    public static class StringExtensions
    {
        public static bool StartsWithUpper(this string? str)
        { 
            if (string.IsNullOrWhiteSpace(str))
                return false;

            char firstChar = str[0];
            return char.IsUpper(firstChar);
        }
    }
}
