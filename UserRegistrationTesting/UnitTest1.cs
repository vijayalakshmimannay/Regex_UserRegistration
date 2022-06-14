
namespace UserRegistrationTesting
{
    public class Tests
    {
       /* [Test]
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
        }*/

       [Test]
        public void GetInvalidFirstName_checkRegexPattern_ShouldThrowInvalidNameException()
        {
            try
            {
                string firstName = "Vijaya";
                string excepted = "Valid";
                RegexProblems.RegExpression regex = new RegexProblems.RegExpression(firstName);
                string actual = regex.RegexFirstNameChecker();
                excepted.Equals(actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid Name", ex.Message);
            }
        }
        
        [Test]
        public void GetInvalidLastName_checkRegexPattern_ShouldThrowInvalidNameException()
        {
            try
            {
                string lastName = "Lakshmi";
                string excepted = "Valid";
                RegexProblems.RegExpression regex = new RegexProblems.RegExpression(lastName);
                string actual = regex.RegexLastNameChecker();
                excepted.Equals(actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid Name", ex.Message);
            }
        }
        [Test]
        public void GetInvalidEmail_checkRegexPattern_ShouldThrowInvalidEmailException()
        {
            try
            {
                string email = "xyz@abc@bl.com";
                string excepted = "Valid";
                RegexProblems.RegExpression regex = new RegexProblems.RegExpression(email);
                string actual = regex.RegexEmail();
                excepted.Equals(actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid Email", ex.Message);
            }
        }
        [Test]
        public void GetInvalidPhoneNumber_CheckRegexPattern_ShouldThrowInvalidNumberException()
        {
            try
            {
                string mobileNumber = "987654321200";
                string excepted = "Valid";
                RegexProblems.RegExpression regex = new RegexProblems.RegExpression(mobileNumber);
                string actual = regex.RegexMobileNumber();
                excepted.Equals(actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid PhoneNumber", ex.Message);
            }
        }
        [Test]
        public void GetInvalidPassword_CheckRegexPattern_ShouldThrowInvalidPasswordException()
        {
            try
            {
                string password = "Summa@123#";
                string excepted = "Valid";
                RegexProblems.RegExpression regex = new RegexProblems.RegExpression(password);
                string actual = regex.RegexPassword();
                excepted.Equals(actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid Password", ex.Message);
            }
        }

    }

}