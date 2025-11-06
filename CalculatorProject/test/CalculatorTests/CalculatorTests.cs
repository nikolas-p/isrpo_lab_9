using CalculatorLib;
using Xunit;

namespace CalculatorTests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            var calc = new Calculator();
            double result = calc.Add(5, 3);
            Assert.Equal(8, result);
        }

        [Fact]
        public void Divide_ByZero_ShouldThrowException()
        {
            var calc = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calc.Divide(5, 0));
        }
    }
}