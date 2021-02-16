namespace tdd_by_example_the_money
{
    public class Money
    {
        private protected int _amount;
        private protected string _currency;

        public Money(int amount, string currency)
        {
            this._amount = amount;
            this._currency = currency;
        }

        public override bool Equals(object? obj)
        {
            var money = (Money) obj;
            return this._amount == money._amount && Currency() == money._currency;
        }

        public static Money Dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Franc(amount, "CHF");
        }

        public virtual Money Times(int multiplier)
        {
            return null;
        }

        public override string ToString()
        {
            return this._amount + " " + this._currency;
        }

        public string Currency()
        {
            return this._currency;
        }
    }
}