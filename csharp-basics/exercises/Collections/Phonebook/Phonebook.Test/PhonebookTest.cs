using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhoneBook.Test
{
    [TestClass]
    public class PhonebookTest
    {
        private PhoneDirectory _target;

        [TestMethod]
        public void PutNumber_NameAndNumber_ExpectedNameAndNumberAddedToList()
        {
            //Arrange
            _target = new PhoneDirectory();
            _target.PutNumber("person1", "number1");
            //Assert
            Assert.IsTrue(_target.PhoneEntryList.ContainsKey("person1"));
            Assert.AreEqual("number1", _target.PhoneEntryList["person1"]);
        }

        [TestMethod]
        public void PutNumber_NumberAndNullName_ExpectedException()
        {
            //Arrange
            _target = new PhoneDirectory();
            //Assert
            Assert.ThrowsException<Exception>(() => _target.PutNumber(null, "number1"));
        }

        [TestMethod]
        public void PutNumber_NameAndNullNumber_ExpectedException()
        {
            //Arrange
            _target = new PhoneDirectory();
            //Assert
            Assert.ThrowsException<Exception>(() => _target.PutNumber("person1", null));
        }

        [TestMethod]
        public void GetNumber_Name_ExpectedNumberBasedOfName()
        {
            //Arrange
            _target = new PhoneDirectory();
            _target.PutNumber("person1", "number1");
            //Act
            var result = _target.GetNumber("person1");
            //Assert
            Assert.AreEqual("number1", result);
        }

        [TestMethod]
        public void GetNumber_IncorrectName_ExpectedNull()
        {
            //Arrange
            _target = new PhoneDirectory();
            _target.PutNumber("person1", "number1");
            //Act
            var result = _target.GetNumber("person2");
            //Assert
            Assert.IsNull(result);
        }
    }
}
