using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    internal class StringHelper
    {
        private static readonly Regex sWhitespace = new Regex(@"\s+");
        private static readonly Regex sEuro = new Regex("€");

        //https://stackoverflow.com/questions/6219454/efficient-way-to-remove-all-whitespace-from-string
        public static void TrimAllWhiteSpace(ref string stringToTrim)
        {
            string newTrimmedString = Regex.Replace(stringToTrim, sWhitespace.ToString(), "");

            stringToTrim = newTrimmedString;
        }

        public static void RemoveEuroFromString(ref string stringToRemove)
        {
            string newString = Regex.Replace(stringToRemove, sEuro.ToString(), "");
            TrimAllWhiteSpace(ref newString);

            stringToRemove = newString;
        }

        public static bool IsEmptyOrNull(params Control[] controls)
        {
            foreach(Control control in controls)
            {

                if (String.IsNullOrEmpty(control.Text))
                    return true;
            }

            return false;
        }
    }
}
