using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexProject
{
    public class Uc1
    {
        //first name starts with Cap and minimum 3 letter
        public static string FIRST_NAME = "^[A-Z]{1}[a-z]{3}$";
        public bool validationName(String Name)
        {
            return Regex.IsMatch(Name, FIRST_NAME);
        }
    }
}
