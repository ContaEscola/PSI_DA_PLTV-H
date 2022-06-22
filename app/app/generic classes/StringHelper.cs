using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace app
{
    internal class StringHelper
    {
        private static readonly Regex sWhitespace = new Regex(@"\s+");

        //https://stackoverflow.com/questions/6219454/efficient-way-to-remove-all-whitespace-from-string
        public static void TrimAllWhiteSpace(ref string stringToTrim)
        {
            string newTrimmedString = Regex.Replace(stringToTrim, @"\s+", "");

            stringToTrim = newTrimmedString;
        }
    }
}
