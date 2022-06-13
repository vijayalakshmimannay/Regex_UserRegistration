using System;
namespace RegexProblems
{
    class program
    {
        public static void Main(string[] args)
        {


            RegExpression regex = new RegExpression();
            Console.WriteLine("Enter Name to check:");
            string name = Console.ReadLine();
            regex.RegexNameChecker("Prasu");
        }
    }
}
