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
            var product = five.Times(2);
            Assert.AreEqual(new Dollar(10), product);
            product = five.Times(3);
            Assert.AreEqual(new Dollar(15), product);
        }

        [Test]
        public void equality()
        {
            Assert.IsTrue(new Dollar(5).Equals(new Dollar(5)));
            Assert.IsFalse(new Dollar(5).Equals(new Dollar(6)));
        }
    }
}