using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexProject
{
    public class Uc2
    {
        // last name starts with Cap and minimum 3 letter
        public static string LAST_NAME = "^[A-Z]{1}[a-z]{3}$";
        public bool validationLastName(string lastname)
        {
            return Regex.IsMatch(lastname, LAST_NAME);
        }
    }
}
