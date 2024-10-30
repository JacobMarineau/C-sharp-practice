using CalculatorLibrary;
using Microsoft.AspNetCore.Mvc;

namespace MyWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly Calculator _calculator;

        public CalculatorController()
        {
            _calculator = new Calculator();
        }

        [HttpGet("add")]
        public IActionResult Add(double a, double b)
        {
            Console.WriteLine($"Adding {a} + {b}");
            var result = _calculator.PerformOperation(a, b, '+');
            return Ok(result);
        }

        [HttpGet("subtract")]
        public IActionResult Subtract(double a, double b)
        {
            var result = _calculator.PerformOperation(a, b, '-');
            return Ok(result);
        }

        [HttpGet("multiply")]
        public IActionResult Multiply(double a, double b)
        {
            var result = _calculator.PerformOperation(a, b, '*');
            return Ok(result);
        }

        [HttpGet("divide")]
        public IActionResult Divide(double a, double b)
        {
            try
            {
                var result = _calculator.PerformOperation(a, b, '/');
                return Ok(result);
            }
            catch (DivideByZeroException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("sqrt")]
        public IActionResult SquareRoot(double a)
        {
            try
            {
                var result = _calculator.PerformSquareRoot(a);
                return Ok(result);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
