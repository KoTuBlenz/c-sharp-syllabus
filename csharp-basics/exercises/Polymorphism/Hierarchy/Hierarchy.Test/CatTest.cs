using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Hierarchy.Test
{
    [TestClass]
    public class CatTest
    {
        private Cat _target =new Cat("cat", 10.00, "Region", "Mix");

        [TestMethod]
        public void MakeNoise_ExpectedAnimalNoiseAsString()
        {
            //Arrange
            var expected = "Meow";
            //Act
            var result = _target.MakeNoise();
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsFoodCorrect_Vegetable_ExpectedTrue()
        {
            //Arrange
            var food = "Vegetable";
            //Act
            var result = _target.IsFoodCorrect(food);
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsFoodCorrect_Meat_ExpectedTrue()
        {
            //Arrange
            var food = "Meat";
            //Act
            var result = _target.IsFoodCorrect(food);
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void EatFood_CorrectFood_AmountEquals5_ExpectedFoodEatenSameAsAmount()
        {
            //Arrange
            var foodIsCorrect = true;
            var amountOfFood = 5;
            //Act
            _target.EatFood(foodIsCorrect, amountOfFood);
            var result = _target.FoodEaten;
            //Assert
            Assert.AreEqual(amountOfFood, result);
        }

        [TestMethod]
        public void EatFood_IncorrectFood_AmountEquals5_ExpectedFoodEatenNotIncreased()
        {
            //Arrange
            _target = new Cat("cat", 10.00, "Region", "Mix");//reset _target.FoodEaten
            var foodIsCorrect = false;
            var amountOfFood = 5;
            //Act
            _target.EatFood(foodIsCorrect, amountOfFood);
            var result = _target.FoodEaten;
            //Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ToString_ExpectedTargetToString()
        {
            //Arrange
            var expected = "Cat [cat, Mix, 10, Region, 0]";
            //Act
            var result = _target.ToString();
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
