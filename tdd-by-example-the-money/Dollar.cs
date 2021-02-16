namespace tdd_by_example_the_money
{
    public class Dollar : Money
    {
        public Dollar(int amount)
        {
            this._amount = amount;
            this._currency = "USD";
        }

        public override Money Times(int multiplier)
        {
            return new Dollar(this._amount * multiplier);
        }
    }
}