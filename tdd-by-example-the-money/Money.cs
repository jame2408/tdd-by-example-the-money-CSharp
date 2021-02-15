﻿namespace tdd_by_example_the_money
{
    public abstract class Money
    {
        protected internal int Amount;

        public override bool Equals(object? obj)
        {
            var money = (Money) obj;
            return this.Amount == money.Amount && GetType() == money.GetType();
        }

        public static Money Dollar(int amount)
        {
            return new Dollar(amount);
        }

        public static Money Franc(int amount)
        {
            return new Franc(amount);
        }

        public abstract Money Times(int multiplier);
    }
}