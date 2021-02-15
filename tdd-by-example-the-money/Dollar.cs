namespace tdd_by_example_the_money
{
    public class Dollar : Money
    {
        public Dollar(int amount)
        {
            this.Amount = amount;
        }

        public override Money Times(int multiplier)
        {
            return new Dollar(this.Amount * multiplier);
        }

        public override string Currency()
        {
            return "USD";
        }
    }
}