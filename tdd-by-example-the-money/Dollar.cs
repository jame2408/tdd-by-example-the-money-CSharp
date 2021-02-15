namespace tdd_by_example_the_money
{
    public class Dollar : Money
    {
        public Dollar(int amount)
        {
            this.Amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(this.Amount * multiplier);
        }
    }
}