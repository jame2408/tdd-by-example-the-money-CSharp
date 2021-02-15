namespace tdd_by_example_the_money
{
    public class Dollar : Money
    {
        private readonly int _amount;

        public Dollar(int amount)
        {
            this._amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(this._amount * multiplier);
        }

        public override bool Equals(object? obj)
        {
            var dollar = (Dollar) obj;
            return this._amount == dollar._amount;
        }
    }
}