﻿namespace tdd_by_example_the_money
{
    public class Sum : IExpression
    {
        public Money Augend { get; set; }
        public Money Addend { get; set; }

        public Sum(Money augend, Money addend)
        {
            this.Augend = augend;
            this.Addend = addend;
        }
    }
}