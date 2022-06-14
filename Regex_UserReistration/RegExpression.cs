using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Regex_UserReistration;

namespace RegexProblems
{
    public class RegExpression
    {
        public string input;
        public RegExpression(string input)
        {
            this.input = input;
        }
        public RegExpression()
        {

        }
        const string NAME = "^[A-Z]{1}[a-z]{2,}$";

        //const string FIRSTNAME = "^[A-Z]{1}[a-z]{2,}$";
       //const string LASTNAME = "^[A-Z]{1}[a-z]{2,}$";
        const string EMAIL = "^(abc).?[a-z]{3,}[@](bl).?(co).?[a-z]{2,}$";
        const string CONTACT = "^[0-9]{1,3}[ ][789][0-9]{9}$";
        const string PASSWORD = "^[a-z A-Z 0-9]{1,}[A-Z]{1,}[a-z A-Z 0-9]{1,}[!*@#$%^&+=]?[a-z A-Z 0-9]{1,}[0-9]{1,}[a-z A-Z 0-9]{1,}$";
        const string SAMPLE = "^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";

        public string RegexNameChecker()
        {
            Func<string, bool> result = (input) => (Regex.IsMatch(input, NAME));
            if (result(input))
            {
                Console.WriteLine("Your Name is Valid");
                return "Valid";
            }
            else
            {
                Console.WriteLine("Your Name is Invalid");
                throw new CustomExceptions(CustomExceptions.ExceptionType.INVALID_NAME, "Invalid Name");
            }
        }


        public string RegexEmail()
        {
            Func<string, bool> result = (input) => Regex.IsMatch(input, EMAIL);
            if (result(input))
            {
                Console.WriteLine("Your email is Valid");
                return "Valid";
            }
            else
            {
                Console.WriteLine("Your email is Invalid");
                throw new CustomExceptions(CustomExceptions.ExceptionType.INVALID_EMAIL, "Invalid Mail");
            }
        }
        public string RegexMobileNumber()
        {
            Func<string, bool> result = (input) => Regex.IsMatch(input, CONTACT);
            if (result(input))
            {
                Console.WriteLine("Your mobileNumber is Valid");
                return "Valid";
            }
            else
            {
                Console.WriteLine("Your mobileNumber is Invalid");
                throw new CustomExceptions(CustomExceptions.ExceptionType.INVALID_NUMBER, "Invalid MobileNumber");
            }
        }
        public string RegexPassword()
        {
            Func<string, bool> result = (input) => Regex.IsMatch(input, PASSWORD);
            if (result(input))
            {
                Console.WriteLine("Your password is Valid");
                return "Valid";
            }
            else
            {
                Console.WriteLine("Your password is Invalid");
                throw new CustomExceptions(CustomExceptions.ExceptionType.INVALID_PASSWORD, "Invalid password");
            }
        }

    }
}