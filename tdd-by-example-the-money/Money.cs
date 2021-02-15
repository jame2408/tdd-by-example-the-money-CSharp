﻿namespace tdd_by_example_the_money
{
    public class Money
    {
        protected internal int Amount;

        public override bool Equals(object? obj)
        {
            var money = (Money) obj;
            return this.Amount == money.Amount;
        }
    }
}