using System.Collections.Generic;


namespace FlightPlanner
{
    public class FlightPlanner
    {
        private Dictionary<string, List<string>> _flightList = new Dictionary<string, List<string>>();

        public FlightPlanner(string flights)
        {
            FillFlightList(flights);
        }

        //Fills _flightList with starting cities as keys and lists of target cities ar values
        private void FillFlightList(string flights)
        {
            var flightArray = flights.Split('\n');
            foreach (string flight in flightArray)
            {
                string[] cities = flight.Replace(" -> ", "-").Split('-');
                if (_flightList == null || !_flightList.ContainsKey(cities[0]))
                {
                    _flightList.Add(cities[0], new List<string>() { cities[1] });
                }
                else
                {
                    _flightList[cities[0]].Add(cities[1]);
                }
            }
        }

        //Returns list of keys as StartingCities from _flightList
        public List<string> StartingCities()
        {
            var startingCities = new List<string>();
            foreach (KeyValuePair<string, List<string>> kvp in _flightList)
            {
                startingCities.Add(kvp.Key);
            }
            return startingCities;
        }

        //Checks and returns all targetCities based of key: startingCity
        public List<string> TargetCities(string startingCity)
        {
            if (!_flightList.ContainsKey(startingCity))
            {
                return null;
            }
            else
            {
                var targetCities = new List<string>();
                foreach (string city in _flightList[startingCity])
                {
                    targetCities.Add(city);
                }
                return targetCities;
            }
        }

        //Checks and returns string of vialible flight based of startingCity and targetCity
        public string FlightRoute(string startingCity, string targetCity)
        {
            if (_flightList.ContainsKey(startingCity))
            {
                if (_flightList[startingCity].Contains(targetCity))
                {
                    return $"Your chosen flight is: |{startingCity}| => |{targetCity}|";
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
