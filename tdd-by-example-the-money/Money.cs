namespace tdd_by_example_the_money
{
    public abstract class Money
    {
        private protected int _amount;
        private protected string _currency;

        public override bool Equals(object? obj)
        {
            var money = (Money) obj;
            return this._amount == money._amount && GetType() == money.GetType();
        }

        public static Money Dollar(int amount)
        {
            return new Dollar(amount);
        }

        public static Money Franc(int amount)
        {
            return new Franc(amount, null);
        }

        public abstract Money Times(int multiplier);

        public string Currency()
        {
            return this._currency;
        }
    }
}