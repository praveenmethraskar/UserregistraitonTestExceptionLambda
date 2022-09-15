using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationTestExceptionLambda;

namespace MSTest_Registration
{
    [TestClass]
    public class UnitTest1
    {
        //UC1

        [TestMethod]
        public void FirstName()
        {
            //Arrange

            REGEX_Registration obj = new REGEX_Registration();

            bool expected = true;
            string FirstName = "Hemant";

            //Act
            bool var = obj.ValidateFirstName(FirstName);

            //Assert
            Assert.AreEqual(expected, var);
        }

        //UC2

        [TestMethod]
        public void LastName()
        {
            //Arrange

            REGEX_Registration obj1 = new REGEX_Registration();

            bool expected = true;
            string LastName = "Dhurve";

            //Act
            bool var = obj1.ValidateFirstName(LastName);

            //Assert
            Assert.AreEqual(expected, var);
        }

        //UC3

        [TestMethod]
        public void Email()
        {
            //Arrange

            REGEX_Registration obj2 = new REGEX_Registration();

            bool expected = true;
            string Email = "hemantdhurve@gmail.com";

            //Act
            bool var = obj2.ValidateEmail(Email);

            //Assert
            Assert.AreEqual(expected, var);
        }
    }
}
