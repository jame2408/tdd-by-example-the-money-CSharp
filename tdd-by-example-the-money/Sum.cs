namespace tdd_by_example_the_money
{
    public class Sum : IExpression
    {
        public Sum(Money augend, Money addend)
        {
            this.Augend = augend;
            this.Addend = addend;
        }

        public Money Augend { get; set; }
        public Money Addend { get; set; }

        public Money Reduce(Bank bank, string to)
        {
            var amount = Augend.Reduce(bank, to)._amount + Addend.Reduce(bank, to)._amount;
            return new Money(amount, to);
        }
    }
}