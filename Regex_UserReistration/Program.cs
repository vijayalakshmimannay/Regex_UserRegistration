using System;
namespace RegexProblems
{
    public class program
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
            Console.Write("PASSWORD:");
            string password = Console.ReadLine();
            regex.RegexNameChecker();
            //regex.RegexLastNameChecker();
            regex.RegexEmail();
            regex.RegexMobileNumber();
            regex.RegexPassword();
            Console.WriteLine("\nSample emails validation:\n");
           // string[] sample = File.ReadAllLines(@"C:\BridgeLabz\.Net_Fellowship\Regex_UserRegistration\Regex_UserReistration\SampleMails.txt");
             // for (int i = 0; i < sample.Length; i++)
           // {
            //    string ret = regex.SampleMails(sample[i]);
              //  Console.WriteLine(sample[i] + "  --  " + ret);
           // }

        }
    }
}
