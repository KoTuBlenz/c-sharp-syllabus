namespace AdApp
{
    public class TVAd: Advert
    {
        private int _time;
        private int _rate;
        private bool _IsPeakTime;
        public TVAd(int fee, int time, int rate, bool IsPeakTime) : base(fee)
        {
            _time = time;
            _rate = rate;
            _IsPeakTime = IsPeakTime;
        }
        
        public override int Cost() 
        {
            int addPrice = _IsPeakTime ? 2*_time * _rate : _time * _rate;
            return base.Cost() + addPrice;
        }

        public override string ToString() 
        {
            return base.ToString();
        }
    }
}