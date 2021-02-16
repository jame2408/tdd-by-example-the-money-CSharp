namespace tdd_by_example_the_money
{
    public interface IExpression
    {
        Money Reduce(Bank bank, string to);
    }
}