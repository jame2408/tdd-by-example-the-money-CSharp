namespace tdd_by_example_the_money
{
    public class Dollar
    {
        public Dollar(int amount)
        {
            this.Amount = amount;
        }

        public double Amount { get; set; }

        public void Times(int multiplier)
        {
            Amount *= multiplier;
        }
    }
}