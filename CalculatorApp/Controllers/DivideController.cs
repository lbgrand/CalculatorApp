using CalculatorApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorApp.Controllers
{
  [ApiController]
  [Route("api/{controller}")]
  public class DivideController : ControllerBase
  {
    private readonly ICalculationService _calculationService;

    public DivideController(ICalculationService calculationService)
    {
      _calculationService = calculationService;
    }

    [HttpGet("{operand1}/{operand2}")]
    public ActionResult<double> Get(double operand1, double operand2)
    {
      return _calculationService.divide(operand1, operand2);
    }
  }
}