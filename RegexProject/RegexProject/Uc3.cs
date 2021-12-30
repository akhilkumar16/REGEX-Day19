using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexProject
{
    public class Uc3
    {
        // E.g. abc.xyz@bl.co.in - Email has 3 mandatory parts (abc, bl,&co) and 2 optional(xyz & in) with precise @ and.positions
        public static string EMAIL_ID = "^[a-c]{3}[.+-_]{0,1}[x-z]{3}@[a-z]{2}[.+-]{0,1}[a-z]{2}[.+-]{0,1}[a-z]{2}$";
        public bool validationEmail(string email)
        {
            return Regex.IsMatch(email, EMAIL_ID);
        }
    }
}
