namespace tdd_by_example_the_money
{
    public interface IExpression
    {
        Money Reduce(Bank bank, string to);
        IExpression Plus(IExpression addend);
        IExpression Times(int multiplier);
    }
}