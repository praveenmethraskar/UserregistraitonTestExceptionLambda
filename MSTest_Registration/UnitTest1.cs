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

        //UC4

        [TestMethod]
        public void PhoneNo()
        {
            //Arrange

            REGEX_Registration obj3 = new REGEX_Registration();

            bool expected = true;
            string PhNumber = "91 7798051897";

            //Act
            bool var = obj3.ValidatePhNumber(PhNumber);

            //Assert
            Assert.AreEqual(expected, var);
        }

        //UC5

        [TestMethod]
        public void PasswordRule1()
        {
            //Arrange

            REGEX_Registration obj4 = new REGEX_Registration();

            bool expected = true;
            string Password1 = "aksjdhfg";

            //Act
            bool var = obj4.ValidatePassword1(Password1);

            //Assert
            Assert.AreEqual(expected, var);
        }

        //UC6

        [TestMethod]
        public void PasswordRule2()
        {
            //Arrange

            REGEX_Registration obj5 = new REGEX_Registration();

            bool expected = true;
            string Password2 = "asKjdhfg";

            //Act
            bool var = obj5.ValidatePassword2(Password2);

            //Assert
            Assert.AreEqual(expected, var);
        }

        //UC7

        [TestMethod]
        public void PasswordRule3()
        {
            //Arrange

            REGEX_Registration obj6 = new REGEX_Registration();

            bool expected = true;
            string Password3 = "aS92jdhfg";

            //Act
            bool var = obj6.ValidatePassword3(Password3);

            //Assert
            Assert.AreEqual(expected, var);
        }

        //UC8

        [TestMethod]
        public void PasswordRule4()
        {
            //Arrange

            REGEX_Registration obj7 = new REGEX_Registration();

            bool expected = true;
            string Password4 = "aS7k%dhfg";

            //Act
            bool var = obj7.ValidatePassword4(Password4);

            //Assert
            Assert.AreEqual(expected, var);
        }

        //UC9

        [TestMethod]
        public void SampleEmails()
        {
            //Arrange

            REGEX_Registration obj8 = new REGEX_Registration();

            bool expected = true;
            string SampleEmail = "abc-100@yahoo.com";

            //Act
            bool var = obj8.ValidateSampleEmail(SampleEmail);

            //Assert
            Assert.AreEqual(expected, var);
        }

        //UC10
        //

        [TestMethod]
        [DataRow("Happy")]

        //Test Case for FirstName passing Happy
        public void firstName1(string message)
        {
            //Arange
            UserRegister user = new UserRegister(message);

            //Act
            var result = user.firstName();

            //Assert
            Assert.AreEqual("Successful Entry", result);
        }

        [TestMethod]
        [DataRow("Sad")]

        //Test Case for FirstName passing Sad
        public void firstName2(string message)
        {
            //Arange
            UserRegister user = new UserRegister(message);

            //Act
            var result = user.firstName();

            //Assert
            Assert.AreEqual("Un-Successful Entry", result);
        }

        [TestMethod]
        [DataRow("Happy")]
        //Test Case for LastName passing Happy

        public void lastName1(string message)
        {
            //Arange
            UserRegister user = new UserRegister(message);

            //Act
            var result = user.lastName();

            //Assert
            Assert.AreEqual("Successful Entry", result);
        }

        [TestMethod]
        [DataRow("Sad")]

        //Test Case for LastName passing Sad
        public void lastName2(string message)
        {
            //Arange
            UserRegister user = new UserRegister(message);

            //Act
            var result = user.lastName();

            //Assert
            Assert.AreEqual("Un-Successful Entry", result);
        }


        [TestMethod]
        [DataRow("Happy")]

        //Test Case for Email passing Happy
        public void Email1(string message)
        {
            //Arange
            UserRegister user = new UserRegister(message);

            //Act
            var result = user.Email();

            //Assert
            Assert.AreEqual("Successful Entry", result);
        }

        [TestMethod]
        [DataRow("Sad")]

        //Test Case for Email passing Sad
        public void Email2(string message)
        {
            //Arange
            UserRegister user = new UserRegister(message);

            //Act
            var result = user.Email();

            //Assert
            Assert.AreEqual("Un-Successful Entry", result);
        }

        [TestMethod]
        [DataRow("Happy")]

        //Test Case for phoneNumber passing Happy
        public void PhoneNumber1(string message)
        {
            //Arange
            UserRegister user = new UserRegister(message);

            //Act
            var result = user.PhoneNumber();

            //Assert
            Assert.AreEqual("Successful Entry", result);
        }

        [TestMethod]
        [DataRow("Sad")]

        ////Test Case for phoneNumber passing Sad
        public void PhoneNumber2(string message)
        {
            //Arange
            UserRegister user = new UserRegister(message);

            //Act
            var result = user.PhoneNumber();

            //Assert
            Assert.AreEqual("Un-Successful Entry", result);
        }

        [TestMethod]
        [DataRow("Happy")]

        //Test Case for Password passing Happy
        public void Password1(string message)
        {
            //Arange
            UserRegister user = new UserRegister(message);

            //Act
            var result = user.Password();

            //Assert
            Assert.AreEqual("Successful Entry", result);
        }

        [TestMethod]
        [DataRow("Sad")]

        ////Test Case for Password passing Sad
        public void Password2(string message)
        {
            //Arange
            UserRegister user = new UserRegister(message);

            //Act
            var result = user.Password();

            //Assert
            Assert.AreEqual("Un-Successful Entry", result);
        }
    }
}
