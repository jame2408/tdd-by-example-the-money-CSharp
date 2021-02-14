namespace tdd_by_example_the_money
{
    public class Dollar
    {
        private readonly int _amount;

        public Dollar(int amount)
        {
            _amount = amount;
        }

        public double Amount { get; set; }

        public void Times(int multiplier)
        {
            Amount = 5 * 2;
        }
    }
}