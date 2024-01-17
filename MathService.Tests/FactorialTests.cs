using Xunit;
namespace MathService.Tests;

public class FactorialTests
{
    [Fact]
        public void CalculateFactorial_ReturnsOneForZero()
        {
            var factorialService = new FactorialService();

            int result = factorialService.CalculateFactorial(0);

            Assert.Equal(1, result);
        }

        [Fact]
        public void CalculateFactorial_ReturnsOneForOne()
        {
            var factorialService = new FactorialService();

            int result = factorialService.CalculateFactorial(1);

            Assert.Equal(1, result);
        }

        [Fact]
        public void CalculateFactorial_ReturnsCorrectResultForPositiveInput()
        {
            var factorialService = new FactorialService();

            int result = factorialService.CalculateFactorial(5);

            Assert.Equal(120, result);
        }

        [Fact]
        public void CalculateFactorial_ThrowsExceptionForNegativeInput()
        {
            var factorialService = new FactorialService();

            Assert.Throws<ArgumentException>(() => factorialService.CalculateFactorial(-1));
        }

        [Fact]
        public void CalculateFactorial_ThrowsExceptionForNegativeInput_FailureTest()
        {
            var factorialService = new FactorialService();

            Assert.Throws<ArgumentException>(() => factorialService.CalculateFactorial(-5));
        }
}