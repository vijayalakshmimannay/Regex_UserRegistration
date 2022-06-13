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
            regex.RegexFirstNameChecker(firstName);
            regex.RegexLastNameChecker(lastName);
        }
    }
}
