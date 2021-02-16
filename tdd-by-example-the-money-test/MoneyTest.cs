using NUnit.Framework;
using tdd_by_example_the_money;

namespace tdd_by_example_the_money_test
{
    public class MoneyTest
    {
        [Test]
        public void multiplication()
        {
            var five = Money.Dollar(5);
            Assert.AreEqual(Money.Dollar(10), five.Times(2));
            Assert.AreEqual(Money.Dollar(15), five.Times(3));
        }

        [Test]
        public void equality()
        {
            Assert.IsTrue(Money.Dollar(5).Equals(Money.Dollar(5)));
            Assert.IsFalse(Money.Dollar(5).Equals(Money.Dollar(6)));
            Assert.IsFalse(Money.Franc(5).Equals(Money.Dollar(5)));
        }

        [Test]
        public void franc_multiplication()
        {
            var five = Money.Franc(5);
            Assert.AreEqual(Money.Franc(10), five.Times(2));
            Assert.AreEqual(Money.Franc(15), five.Times(3));
        }

        [Test]
        public void currency()
        {
            Assert.AreEqual("USD", Money.Dollar(1).Currency());
            Assert.AreEqual("CHF", Money.Franc(1).Currency());
        }

        [Test]
        public void simple_addition()
        {
            var five = Money.Dollar(5);
            var sum = five.Plus(five);
            var bank = new Bank();
            var reduced = bank.Reduce(sum, "USD");
            Assert.AreEqual(Money.Dollar(10), reduced);
        }

        [Test]
        public void plus_return_sum()
        {
            var five = Money.Dollar(5);
            var result = five.Plus(five);
            var sum = (Sum) result; 
            Assert.AreEqual(five, sum.augend);
            Assert.AreEqual(five, sum.addend);
        }
    }
}