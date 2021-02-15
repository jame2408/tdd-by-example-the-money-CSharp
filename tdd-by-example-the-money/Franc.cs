namespace tdd_by_example_the_money
{
    public class Franc : Money
    {
        private readonly string _currency;

        public Franc(int amount)
        {
            this.Amount = amount;
            this._currency = "CHF";
        }

        public override Money Times(int multiplier)
        {
            return new Franc(this.Amount * multiplier);
        }

        public override string Currency()
        {
            return this._currency;
        }
    }
}