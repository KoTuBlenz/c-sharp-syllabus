using System;
using System.Collections.Generic;
using System.Text;

namespace AdApp
{
    class Poster: Advert
    {
        private int _height;
        private int _width;
        private int _amount;
        private int _costPerSize;

        public Poster(int fee, int height, int width, int amount, int costPerSize) : base(fee)
        {
            _height = height;
            _width = width;
            _amount = amount;
            _costPerSize = costPerSize;
        }

        public override int Cost()
        {
            int addPrice = _height*_width* _costPerSize * _amount;
            return base.Cost() + addPrice;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
