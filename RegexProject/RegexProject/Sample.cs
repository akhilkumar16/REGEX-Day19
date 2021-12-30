using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexProject
{
    class Sample
    {
        public static string INVALID_EMAIL = "^[a-c]{3}[.+]@[x-z]{3}[.+]{0,1}[a-z]{3}$";
        public bool invaidmail(string id)
        {
            return Regex.IsMatch(id, INVALID_EMAIL);
        }
    }
}
