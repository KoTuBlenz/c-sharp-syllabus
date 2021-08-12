namespace FuelConsumptionCalculator
{
    public class Car
    {

        private double _startKilometers; // Starting odometer reading
        private double _endKilometers; // Ending odometer reading
        private double _liters; // Liters of gas used between the readings

        public Car(double startOdo)
        {
            _startKilometers = startOdo;
        }

        public double CalculateConsumption()
        {
            return _liters / (_endKilometers - _startKilometers);
        }

        public double ConsumptionPer100Km()
        {
            return CalculateConsumption()*100;
        }

        public bool GasHog()
        {
            if (ConsumptionPer100Km() > 15) return true;
            else return false;
        }

        public bool EconomyCar()
        {
            if (ConsumptionPer100Km() < 5) return true;
            else return false;
        }

        public void FillUp(double mileage, double liters)
        {
            _endKilometers = mileage;
            _liters = liters;
        }
    }
}
