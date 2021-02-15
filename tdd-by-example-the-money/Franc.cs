namespace tdd_by_example_the_money
{
    public class Franc
    {
        private readonly int _amount;

        public Franc(int amount)
        {
            this._amount = amount;
        }

        public Franc Times(int multiplier)
        {
            return new Franc(this._amount * multiplier);
        }

        public override bool Equals(object? obj)
        {
            var franc = (Franc) obj;
            return this._amount == franc._amount;
        }
    }
}