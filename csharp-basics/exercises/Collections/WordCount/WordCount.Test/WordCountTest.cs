using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WordCount.Test
{
    [TestClass]
    public class WordCountTest
    {
        private TextProperties _target;

        [TestMethod]
        public void LinesInText_TextWith3Lines_Expected3()
        {
            //Arrange
            var text = "Line1\n" +
                "Line2\n" +
                "Line3";
            _target = new TextProperties(text);
            //Act
            var result = _target.LinesInText();
            //Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void WordsInText_TextWith4Words_Expected4()
        {
            //Arrange
            var text = "word1 word2 word3 word4";
            _target = new TextProperties(text);
            //Act
            var result = _target.WordsInText();
            //Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void CharsInText_TextWith10Chars_Expected10()
        {
            //Arrange
            var text = "Abcedf4waw";
            _target = new TextProperties(text);
            //Act
            var result = _target.CharsInText();
            //Assert
            Assert.AreEqual(10, result);
        }
    }
}
