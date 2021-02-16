namespace tdd_by_example_the_money
{
    public class Dollar : Money
    {
        public Dollar(int amount, string currency) : base(amount, currency)
        {
        }

        public override Money Times(int multiplier)
        {
            return new Money(base._amount * multiplier, base._currency);
        }
    }
}