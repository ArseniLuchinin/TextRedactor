using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MultiTask
{
    static class WinFormInstruments
    {
        public static bool enterInt(String innputText)
        {
            String pattern = "^[0-9]+$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(innputText))
                return true;
            else
                return false;
        }
    }
}
