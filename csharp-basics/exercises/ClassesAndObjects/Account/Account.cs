namespace Account
{
    public class Account
    {
        private string _name;
        private double _money;

        public Account(string v1, double v2)
        {
            _name = v1;
            _money = v2;
        }

        public double Withdrawal(double i)
        {
            _money -= i;
            return i;
        }

        public void Deposit(double i)
        {
            _money += i;
        }

        public double Balance
        {
            get => _money;
        }

        public override string ToString()
        {
            return $"{_name}: {_money}";
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public static void Transfer(Account from, Account to, double howMuch)
        {
            to.Deposit(from.Withdrawal(howMuch));
        }
    }
}
