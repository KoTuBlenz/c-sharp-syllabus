using System;

namespace BankAccount
{
    class Account
    {
        string _accountName;
        double _accountBalance;
        public Account(string accountName, double accountBalance)
        {
            _accountName = accountName;
            _accountBalance = accountBalance;
        }
        public string ShowUserNameAndBalance()
        {
            return $"{_accountName}, {String.Format("{0:$#,0.00}", _accountBalance)}";
        }
    }
}
