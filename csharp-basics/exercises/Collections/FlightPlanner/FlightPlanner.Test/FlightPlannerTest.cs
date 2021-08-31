using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace FlightPlanner.Test
{
    [TestClass]
    public class FlightPlannerTest
    {
        private string _flightList = "city1 -> targetCity1\n" +
                "city2 -> targetCity2\n" +
                "city1 -> targetCity3";
        private FlightPlanner _target;

        [TestMethod]
        public void StartingCities_CityList_ExpectedStartingCitiesList()
        {
            //Arrange
            _target = new FlightPlanner(_flightList);
            //Act
            var expected = new List<string>() { "city1", "city2" };
            var result = _target.StartingCities();
            //Assert
            CollectionAssert.AreEquivalent(expected, result);
        }

        [TestMethod]
        public void TargetCities_CityListAndStartingCity_ExpectedTargetCitiesList()
        {
            //Arrange
            _target = new FlightPlanner(_flightList);
            var startingCity = "city1";
            //Act
            var expected = new List<string>() { "targetCity1", "targetCity3" };
            var result = _target.TargetCities(startingCity);
            //Assert
            CollectionAssert.AreEquivalent(expected, result);
        }

        [TestMethod]
        public void TargetCities_CityListAndIncorrectStartingCity_ExpectedNull()
        {
            //Arrange
            _target = new FlightPlanner(_flightList);
            var startingCity = "city3";
            //Act
            var result = _target.TargetCities(startingCity);
            //Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void FlightRoute_StartingCityAndTargetCity_ExpectedStringWithFlightRoute()
        {
            //Arrange
            _target = new FlightPlanner(_flightList);
            var startingCity = "city1";
            var targetCity = "targetCity3";
            //Act
            var expected = "Your chosen flight is: |city1| => |targetCity3|";
            var result = _target.FlightRoute(startingCity, targetCity);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FlightRoute_IncorrectStartingCityAndTargetCity_ExpectedNull()
        {
            //Arrange
            _target = new FlightPlanner(_flightList);
            var startingCity = "city3";
            var targetCity = "targetCity3";
            //Act
            var result = _target.FlightRoute(startingCity, targetCity);
            //Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void FlightRoute_StartingCityAndIncorrectTargetCity_ExpectedNull()
        {
            //Arrange
            _target = new FlightPlanner(_flightList);
            var startingCity = "city2";
            var targetCity = "targetCity3";
            //Act
            var result = _target.FlightRoute(startingCity, targetCity);
            //Assert
            Assert.IsNull(result);
        }

    }
}
