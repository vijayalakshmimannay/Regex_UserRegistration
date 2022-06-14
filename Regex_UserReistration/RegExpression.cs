using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

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

        const string FIRSTNAME = "^[A-Z]{1}[a-z]{2,}$";
        const string LASTNAME = "^[A-Z]{1}[a-z]{2,}$";
        const string EMAIL = "^(abc).?[a-z]{3,}[@](bl).?(co).?[a-z]{2,}$";
        const string CONTACT = "^[0-9]{1,3}[ ][789][0-9]{9}$";
        const string PASSWORD = "^[a-z A-Z 0-9]{1,}[A-Z]{1,}[a-z A-Z 0-9]{1,}[!*@#$%^&+=]?[a-z A-Z 0-9]{1,}[0-9]{1,}[a-z A-Z 0-9]{1,}$";
        const string SAMPLE = "^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";
        public string RegexFirstNameChecker()
        {
            if (Regex.IsMatch(input, FIRSTNAME))
            {
                Console.WriteLine("First name is valid.");
                return "Valid";
            }
            Console.WriteLine("First name is not valid.");
            return "InValid";
        }
        public string RegexLastNameChecker()
        {
            if (Regex.IsMatch(input, LASTNAME))
            {
                Console.WriteLine("second name is valid.");
                return "Valid"; ;
            }
            Console.WriteLine("second name is not valid.");
            return "InValid";
        }
        public string RegexEmail()
        {
            if (Regex.IsMatch(input, EMAIL))
            {
                Console.WriteLine("E-Mail id is valid.");
                return "Valid";
            }
            Console.WriteLine("E-Mail id is not valid.");
            return "InValid";
        }
        public string RegexMobileNumber()
        {
            if (Regex.IsMatch(input, CONTACT))
            {
                Console.WriteLine("Mobile number is valid.");
                return "Valid";
            }
            Console.WriteLine("Mobile number is not valid.");
            return "InValid";
        }
        public string RegexPassword()
        {
            if (Regex.IsMatch(input, PASSWORD))
            {
                Console.WriteLine("Password is valid.");
                return "Valid";
            }
            Console.WriteLine("Password is not valid.");
            return "InValid";
        }
        public string RegexSampleMail(string sample)
        {
            if (Regex.IsMatch(sample, SAMPLE))
            {
                return "Valid";
            }
            return "Not Valid";
        }
    }
}