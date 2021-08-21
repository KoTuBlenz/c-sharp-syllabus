namespace AdApp
{
    public class Hoarding: Advert
    {
        private int _rate;
        //per day
        private int _numDays;
        private bool _primeLocation;
        public Hoarding(int fee, int numDays, int rate, bool primeLocation) : base(fee)
        {
            _rate = rate;
            _numDays = numDays;
            _primeLocation = primeLocation;
        }

        public override int Cost() 
        {
            int addPrice = _primeLocation ? (int)(_rate * _numDays * 1.5) : _rate * _numDays;
            return base.Cost() + addPrice;
        }

        public override string ToString() 
        {
            return base.ToString();
        }
    }
}