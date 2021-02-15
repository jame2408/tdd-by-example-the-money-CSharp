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

        public override bool Equals(object? obj)
        {
            Money dollar = (Dollar) obj;
            return this.Amount == dollar.Amount;
        }
    }
}