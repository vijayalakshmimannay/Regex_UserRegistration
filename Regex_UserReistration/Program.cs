using System;
namespace RegexProblems
{
    class program
    {
        public static void Main(string[] args)
        {


            RegExpression regex = new RegExpression();
            Console.WriteLine("Enter Name to check:");
            Console.Write("First Name:");
            string firstName = Console.ReadLine();
            Console.Write("Last Name:");
            string lastName = Console.ReadLine();
            Console.Write("EMAIL:");
            string email = Console.ReadLine();
            Console.Write("CONTACT:");
            string mobileNumber = Console.ReadLine();
            regex.RegexFirstNameChecker(firstName);
            regex.RegexLastNameChecker(lastName);
            regex.RegexEmail(email);
            regex.RegexMobileNumber(mobileNumber);
        }
    }
}
