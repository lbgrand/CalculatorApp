namespace CalculatorApp.Services { 
  public interface ICalculationService {
    public double sum(double operand1, double operand2);

    public double subtract(double operand1, double operand2);

    public double multiply(double operand1, double operand2);

    public double divide(double operand1, double operand2);
  }
}