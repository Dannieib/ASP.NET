using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmailTest
{


    public class Program
    {
        static void Main(string[] args)
        {
            string email = null;
        EmailClass emailClass = new EmailClass();


            Console.WriteLine("Please enter your email");
            email = Console.ReadLine();
            var checkEmail = emailClass.IsEmailValid(email);
            if (checkEmail !=null)
                Console.WriteLine($"Valid:   {email}");
            else
                Console.WriteLine($"Invalid: {email}");

            Console.ReadKey();
        }
    }

}
