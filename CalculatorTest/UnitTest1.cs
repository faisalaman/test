using CalculatorLogic;
using Xunit;

namespace CalculatorTest
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldAddTwoNumbers()
        {
            var x = new Calculator().Sum(1, 2);
            Assert.Equal(3, x);
        }

        [Fact]
        public void ShouldMultiplyTwoNumbers()
        {
            var x = new Calculator().Multiply(3, 2);
            Assert.Equal(6, x);
        }
        [Fact]
        public void ShouldDivideTwoNumbers()
        {
            var x = new Calculator().Divide(10, 2);
            Assert.Equal(5, x);
        }

        [Fact]
        public void ShouldSubtractTwoNumbers()
        {
            var x = new Calculator().Subtract(5, 2);
            Assert.Equal(3, x);
        }

    }
}
