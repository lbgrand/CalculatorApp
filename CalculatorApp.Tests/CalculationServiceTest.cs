using Xunit;
using CalculatorApp.Services;

namespace CalculatorApp.Tests
{
  public class CalculationServiceTest
  {
    private readonly CalculationService calculationService = new CalculationService();

    [Fact]
    public void shouldSumNumbersCorrectly()
    {
      double result = calculationService.sum(43.5, 674.99);

      Assert.Equal(718.49, result);
    }

    [Fact]
    public void shouldSubtractNumbersCorrectly()
    {
      double result = calculationService.subtract(43.5, 674.99);

      Assert.Equal(-631.49, result);
    }

    [Fact]
    public void shouldMultiplyNumbersCorrectly()
    {
      double result = calculationService.multiply(43.5, 674.99);

      Assert.Equal(29362.065, result);
    }

    [Fact]
    public void shouldDivideNumbersCorrectly()
    {
      double result = calculationService.divide(43.5, 674.99);

      Assert.Equal(0.064445, result);
    }

    [Fact]
    public void shouldThrowExceptionForZeroDivision()
    {
      Assert.Throws<ArgumentException>(
        () => calculationService.divide(43.5, 0)
      );
    }
  }
}