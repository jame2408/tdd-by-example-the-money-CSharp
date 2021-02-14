using NUnit.Framework;
using tdd_by_example_the_money;

namespace tdd_by_example_the_money_test
{
    public class MoneyTest
    {
        [Test]
        public void multiplication()
        {
            var five = new Dollar(5);
            five.Times(2);
            Assert.AreEqual(10, five.Amount);
            five.Times(3);
            Assert.AreEqual(15, five.Amount);
        }
    }
}