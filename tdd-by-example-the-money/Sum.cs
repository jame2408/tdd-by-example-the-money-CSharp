﻿namespace tdd_by_example_the_money
{
    public class Sum : IExpression
    {
        public Sum(IExpression augend, IExpression addend)
        {
            this.Augend = augend;
            this.Addend = addend;
        }

        public IExpression Augend { get; set; }
        public IExpression Addend { get; set; }

        public Money Reduce(Bank bank, string to)
        {
            var amount = Augend.Reduce(bank, to)._amount + Addend.Reduce(bank, to)._amount;
            return new Money(amount, to);
        }

        public IExpression Plus(IExpression addend)
        {
            return new Sum(this, addend);
        }

        public IExpression Times(int multiplier)
        {
            return new Sum(this.Augend.Times(multiplier), this.Addend.Times(multiplier));
        }
    }
}