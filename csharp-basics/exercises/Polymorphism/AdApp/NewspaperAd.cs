namespace AdApp
{
    public class NewspaperAd : Advert
    {
        private int _column;
        private int _rate;

        public NewspaperAd(int fee, int column, int rate) : base(fee)
        {
            _rate = rate;
            _column = column;
        }

        public override int Cost()
        {
            int addPrice = _column * _rate;
            return base.Cost() + addPrice;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}