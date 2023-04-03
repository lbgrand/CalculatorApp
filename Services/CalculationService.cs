using System;

namespace CalculatorApp.Services
{
  public class CalculationService : ICalculationService
  {
    public double sum(double operand1, double operand2)
    {
      return Math.Round(operand1 + operand2, 6);
    }

    public double subtract(double operand1, double operand2)
    {
      return Math.Round(operand1 - operand2, 6);
    }

    public double multiply(double operand1, double operand2)
    {
      return Math.Round(operand1 * operand2, 6);
    }

    public double divide(double operand1, double operand2)
    {
      if (operand2 == 0.0)
      {
        throw new ArgumentException("Zero division is not possible!");
      }

      return Math.Round(operand1 / operand2, 6);
    }
  }
}