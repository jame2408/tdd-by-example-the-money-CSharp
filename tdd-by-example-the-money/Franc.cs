namespace tdd_by_example_the_money
{
    public class Franc : Money
    {
        public Franc(int amount)
        {
            this._amount = amount;
            this._currency = "CHF";
        }

        public override Money Times(int multiplier)
        {
            return new Franc(this._amount * multiplier);
        }
    }
}