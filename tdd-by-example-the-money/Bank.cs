namespace tdd_by_example_the_money
{
    public class Bank
    {
        public Money Reduce(IExpression source, string to)
        {
            return source.Reduce(this, to);
        }

        public void AddRate(string source, string to, int rate)
        {
        }

        public int Rate(string from, string to)
        {
            return (from.Equals("CHF") && to.Equals("USD")) ? 2 : 1;
        }
    }

    internal class Pair
    {
        private readonly string _from;
        private readonly string _to;

        public Pair(string from, string to)
        {
            this._from = from;
            this._to = to;
        }
    }
}