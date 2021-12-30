using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexProject
{
    public class Uc9
    {
        // valid emails 
        public static string SAMPLE_EMAIL = "^[A-Z0-9a-z]{1,}([.#$^][A-Za-z0-9]+)?[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";
        public bool emailtest(string sample)
        {
            return Regex.IsMatch(sample, SAMPLE_EMAIL);
        }
    }
}
