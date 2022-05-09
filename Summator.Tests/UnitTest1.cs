using NUnit.Framework;

namespace Summator.Tests
{
    public class Tests
    {
        [Test]
        public void Test_Sum_TwoPossitiveNumbers()
        {
            int result = Summator.Sum(new int[] { 5, 7 });

            Assert.That(result == 12);
        }

        [Test]
        public void Test_Sum_OnePossitiveNumber()
        {
            int result = Summator.Sum(new int[] { 5 });

            Assert.That(result == 5);

        }

        [Test]
        public void Test_Sum_TwoNegativeNumber()
        {
            int result = Summator.Sum(new int[] { -5, -10 });

            Assert.That(result == -15);
        }
    }
}
