namespace tdd_by_example_the_money
{
    public class Dollar
    {
        public Dollar(int amount)
        {
            this.Amount = amount;
        }

        public int Amount { get; set; }

        public Dollar Times(int multiplier)
        {
            return new Dollar(Amount * multiplier);
        }
    }
}