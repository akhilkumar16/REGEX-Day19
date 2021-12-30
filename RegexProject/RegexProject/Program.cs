using System;

namespace RegexProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // first name starts with Cap and minimum 3 letter
            Uc1 user = new Uc1();
            Console.WriteLine(user.validationName("Appl"));

            // last name starts with Cap and minimum 3 letter
            Uc2 obj = new Uc2();
            Console.WriteLine(obj.validationLastName("Frui"));

            // E.g. abc.xyz@bl.co.in - Email has 3 mandatory parts (abc, bl,&co) and 2 optional(xyz & in) with precise @ and.positions
            Uc3 abc = new Uc3();
            Console.WriteLine(abc.validationEmail("abc.xyz@bl.co.in"));

            // Mobile Format 91 9165452358
            Uc4 mob = new Uc4();
            Console.WriteLine(mob.validationMobileNo("91 9165452358"));

            // minimum 8 characters
            Uc5_Uc8 pass = new Uc5_Uc8();
            Console.WriteLine(pass.validationPassword("asH1!hjk"));

            // valid emails 
            Uc9 smp = new Uc9();
            Console.WriteLine(smp.emailtest("abc@yahoo.com"));

            Sample a = new Sample();
            Console.WriteLine(a.invaidmail("abc.xyz.com"));
            Console.WriteLine(" @ must be included");
        }
    }
}
