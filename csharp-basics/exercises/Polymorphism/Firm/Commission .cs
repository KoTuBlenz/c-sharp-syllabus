using System;
using System.Collections.Generic;
using System.Text;

namespace Firm
{
    class Commission :Hourly
    {
        private double _commissionRate;
        private double _totalSales;
        public Commission(string eName, string eAddress, string ePhone, string socSecNumber, double rate, double commissRate) :base(eName,eAddress,ePhone,socSecNumber,rate)
        {
            _commissionRate = commissRate;
        }
        public void AddSales(double totalSales)
        {
            _totalSales += totalSales;
        }
        public override double Pay()
        {
            var payment = base.Pay() + (_totalSales * _commissionRate);
            _totalSales = 0;
            return payment;
        }
        public override string ToString()
        {
            var result = base.ToString();
            result += "\nTotal Sales: " + _totalSales;
            return result;
        }
    }
}
