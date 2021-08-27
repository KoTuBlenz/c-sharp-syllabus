using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Exercise6.Tests
{
    [TestClass]
    public class Exercise6Test
    {
        private ModifyArray _target;

        [TestMethod]
        public void ReturnUnmodified_GiveArray_ExpectedSameArray()
        {
            //Arange
            int[] array = new int[] { 66, 57, 19, 38, 89, 4, 59, 38, 46, 79 };
            _target = new ModifyArray(array);
            //Act
            var result = _target.ReturnUnmodified();
            //Assert
            CollectionAssert.AreEquivalent(array, _target.ReturnUnmodified());
        }

        [TestMethod]
        public void ReturnModified_PassArray_ExpectedLastArrayElementNegative7()
        {
            //Arange
            int[] array = new int[] { 66, 57, 19, 38, 89, 4, 59, 38, 46, 79 };
            _target = new ModifyArray(array);
            //Act
            var result = _target.ReturnUnmodified();
            //Assert
            Assert.AreEqual(-7, _target.ReturnModified()[array.Length-1]);
        }
    }
}
