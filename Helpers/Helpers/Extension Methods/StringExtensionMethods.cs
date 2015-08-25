using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.Extension_Methods
{
    public static class StringExtensionMethods
    {
        /// <summary>
        /// Removes extra characters \r\n that may be appended to the end of a string.
        /// </summary>
        /// <param name="stringToClean">The string to clean.</param>
        /// <returns>The string without the \r\n.</returns>
        public static string Clean(this string stringToClean)
        {
            return stringToClean.Replace("\r", string.Empty).Replace("\n", string.Empty);
        }
    }
}
