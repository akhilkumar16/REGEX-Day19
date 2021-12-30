using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexProject
{
    public class Uc5_Uc8
    {
        // minimum 8 characters----Sample Emails to Test
        public static string PASSWORD = "^((?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*-_.])(?=.{8,}))";
        public bool validationPassword(string password)
        {
            return Regex.IsMatch(password, PASSWORD);
        }
    }
}
