using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexProject
{
     public class Uc4
    {
        // Mobile Format 91 9165452358
        public static string MOBILE_NUMBER = "^[1-9]{2}[ ][1-9]{10}$";
        public bool validationMobileNo(string moblie)
        {
            return Regex.IsMatch(moblie, MOBILE_NUMBER);
        }
    }
}
