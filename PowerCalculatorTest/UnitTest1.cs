using Xunit;
using PowerFunction;

namespace PowerCalculatorTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestPowerOf2To3()
        {
            double baseNumber = 2;
            double exponent = 3;
            double expected = 8;

            double actual = PowerCalculator.CalculatePower(baseNumber, exponent);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestPowerOf2To3To4()
        {
            double baseNumber = 2;
            double exponent1 = 3;
            double exponent2 = 4;
            double expected = 4096;

            double actual = PowerCalculator.CalculatePower(baseNumber, exponent1, exponent2);

            Assert.Equal(expected, actual);
        }
    }
}
