namespace tdd_by_example_the_money
{
    public class Dollar : Money
    {
        private readonly string _currency;

        public Dollar(int amount)
        {
            this.Amount = amount;
            this._currency = "USD";
        }

        public override Money Times(int multiplier)
        {
            return new Dollar(this.Amount * multiplier);
        }

        public override string Currency()
        {
            return this._currency;
        }
    }
}