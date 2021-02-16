namespace tdd_by_example_the_money
{
    public class Bank
    {
        public Money Reduce(IExpression source, string to)
        {
            var sum = (Sum) source;
            var amount = sum.Augend._amount + sum.Addend._amount;
            return new Money(amount, to);
        }
    }
}