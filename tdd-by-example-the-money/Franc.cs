namespace tdd_by_example_the_money
{
    public class Franc : Money
    {
        public Franc(int amount)
        {
            this.Amount = amount;
        }

        public Franc Times(int multiplier)
        {
            return new Franc(this.Amount * multiplier);
        }
    }
}