using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using John.SocialClub.Desktop;

namespace John.SocialClub.Test
{
    // unit test code
    /*
     A test method must meet the following requirements:
        ===The method must be decorated with the [TestMethod] attribute.
        ===The method must return void.
        ===The method cannot have parameters.
     */
    [TestClass]
    public class ValidationTest
    {
        // Pass : Users input is between 6 and 12 characters, UpperCase, Number, or Symbols "%$%&*"
        [TestMethod]
        public void PassUserNameBetween6And12CharactersAndUpperCase()
        {
            //Arrange create instance of class
            Validation numOfCharacters = new Validation();
            //Act create an example of how it will be called
            bool result = numOfCharacters.PasswordValidation("Works6%");
            //Assert verify is what we expect
            Assert.AreEqual(true , result);
        }

        // Fail : Users input is less than 6 characters
        [TestMethod]
        public void FailIsLessThan6Characters()
        {
            //Arrange create instance of class
            Validation lessThan6Characters = new Validation();
            //Act create an example of how it will be called
            bool result = lessThan6Characters.NumOfCharacters("12345");
            //Assert verify is what we expect
            Assert.AreNotEqual(true , result);
        }

        // Fail : Users input is greater than 12 characters
        [TestMethod]
        public void FailIsGreaterThan12Characters()
        {
            //Arrange create instance of class
            Validation greaterThan12Characters = new Validation();
            //Act create an example of how it will be called
            //Assert verify is what we expect
            Assert.AreEqual(false , greaterThan12Characters.NumOfCharacters("123456789123456789"));
        }

        // Fail : Users input has no number
        [TestMethod]
        public void FailInputHasNoNumber()
        {
            //Arrange create instance of class
            Validation noNumber = new Validation();
            //Act create an example of how it will be called
            //Assert verify is what we expect
            Assert.AreNotEqual(true , noNumber.HasNumber("Thisshouldnotwork"));
        }

        // Fail : Has No Symbol
        [TestMethod]
        public void FailHasNoSymbol()
        {
            //Arrange create instance of class
            Validation noSymbol = new Validation();
            //Act create an example of how it will be called
            //Assert verify is what we expect
            Assert.AreNotEqual(true , noSymbol.HasSymbol("Thisshouldnot"));
        }

        // Fail: User input has no uppercase
        [TestMethod()]
        public void FailContainsNoUpperCase()
        {
            //Arrange create instance of class
            Validation noUpperCase = new Validation();
            //Act create an example of how it will be called
            //Assert verify is what we expect
            Assert.AreNotEqual(true , noUpperCase.HasUpperCase("nouppercase"));
        }

        // Fail: No User input 
        [TestMethod()]
        public void FailNoUserInput()
        {
            //Arrange create instance of class
            Validation noUpperCase = new Validation();
            //Act create an example of how it will be called
            bool result = String.IsNullOrEmpty("");
            //Assert verify is what we expect
            Assert.AreEqual(true , result);
        }

        [TestMethod]
        public void PassUserID()
        {
            //arrange
            Validation validID = new Validation();
            //act
            bool result = validID.CheckID("895867");
            //assert
            Assert.AreEqual(true , result);

        }
        [TestMethod]
        public void FailPassUserID()
        {
            //arrange
            Validation validID = new Validation();
            //act
            bool result = validID.CheckID("notgood");
            //assert
            Assert.AreEqual(false , result);
        }

    }
}
