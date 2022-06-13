using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;

namespace RegexProblems
{
    internal class RegExpression
    {
        const string FIRSTNAME = "^[A-Z]{1}[a-z]{2,}$";
        const string LASTNAME = "^[A-Z]{1}[a-z]{2,}$";
        const string EMAIL = "^(abc).?[a-z]{3,}[@](bl).?(co).?[a-z]{2,}$";
        const string CONTACT = "^[0-9]{1,3}[ ][789][0-9]{9}$";
        public void RegexFirstNameChecker(string firstName)
        {
            if (Regex.IsMatch(firstName, FIRSTNAME))
            {
                Console.WriteLine("First name is valid.");
                return;
            }
            Console.WriteLine("First name is not valid.");
        }
        public void RegexLastNameChecker(string secondName)
        {
            if (Regex.IsMatch(secondName, LASTNAME))
            {
                Console.WriteLine("second name is valid.");
                return;
            }
            Console.WriteLine("second name is not valid.");
        }
        public void RegexEmail(string email)
        {
            if (Regex.IsMatch(email, EMAIL))
            {
                Console.WriteLine("E-Mail id is valid.");
                return;
            }
            Console.WriteLine("E-Mail id is not valid.");
        }
        public void RegexMobileNumber(string mobile)
        {
            if (Regex.IsMatch(mobile, CONTACT))
            {
                Console.WriteLine("Mobile number is valid.");
                return;
            }
            Console.WriteLine("Mobile number is not valid.");
        }
    }
}