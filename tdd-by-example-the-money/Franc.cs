namespace tdd_by_example_the_money
{
    public class Franc : Money
    {
        public Franc(int amount, string currency)
        {
            this._amount = amount;
            this._currency = "CHF";
        }

        public override Money Times(int multiplier)
        {
            return Money.Franc(this._amount * multiplier);
        }
    }
}