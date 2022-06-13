
namespace UserRegistrationTesting
{
    public class Tests
    {
        [Test]
        public void GivenFirstName_RegexFirstName_ReturnFirstName()
        {
            RegexProblems.RegExpression regex = new RegexProblems.RegExpression();
            string firstName = "Lakshmi";
            string actualResult = regex.RegexFirstNameChecker(firstName);
            Assert.Pass("Valid", actualResult);
        }
        [Test]
        public void GivenLastName_RegexLastName_ReturnLastName()
        {
            RegexProblems.RegExpression regex = new RegexProblems.RegExpression();
            string lastName = "Lakshmi";
            string actualResult = regex.RegexLastNameChecker(lastName);
            Assert.Pass("Valid", actualResult);
        }
        [Test]
        public void GivenEmail_RegexEmail_ReturnEmail()
        {
            RegexProblems.RegExpression regex = new RegexProblems.RegExpression();
            string email = "abc.xyz@bl.co.in";
            string actualResult = regex.RegexEmail(email);
            Assert.Pass("Valid", actualResult);
        }
        [Test]
        public void GivenMobileNumber_RegexMobileNumber_ReturnMobileNumber()
        {
            RegexProblems.RegExpression regex = new RegexProblems.RegExpression();
            string mobileNumber = "91 9553945305";
            string actuvalResult = regex.RegexMobileNumber(mobileNumber);
            Assert.Pass("Valid", actuvalResult);
        }
        [Test]
        public void GivenPassWord_RegexPassWord_ReturnPassWard()
        {
            RegexProblems.RegExpression regex = new RegexProblems.RegExpression();
            string password = "Lucky@08";
            string actualResult = regex.RegexPassword(password);
            Assert.Pass("Valid", actualResult);
        }
    }
}