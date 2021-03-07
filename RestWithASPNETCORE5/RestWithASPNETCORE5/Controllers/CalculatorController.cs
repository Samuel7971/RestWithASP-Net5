using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using RestWithASPNETCORE5.ValidatorNumber;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETCORE5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;
        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {
            
            if (Validator.IsNumeric(firstNumber) && Validator.IsNumeric(secondNumber))
            {
                var sum = Validator.ConvertToDecimal(firstNumber) + Validator.ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("subtraction/{firstNumber}/{secondNumber}")]
        public IActionResult Subtraction(string firstNumber, string secondNumber)
        {
            if (Validator.IsNumeric(firstNumber) && Validator.IsNumeric(secondNumber))
            {
                var sub = Validator.ConvertToDecimal(firstNumber) - Validator.ConvertToDecimal(secondNumber);
                return Ok(sub.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("multiplication/{firstNumber}/{secondNumber}")]
        public IActionResult Multiplication(string firstNumber, string secondNumber)
        {
            if (Validator.IsNumeric(firstNumber) && Validator.IsNumeric(secondNumber))
            {
                var mult = Validator.ConvertToDecimal(firstNumber) * Validator.ConvertToDecimal(secondNumber);
                return Ok(mult.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("mean/{firstNumber}/{secondNumber}")]
        public IActionResult Mean(string firstNumber, string secondNumber)
        {
            if (Validator.IsNumeric(firstNumber) && Validator.IsNumeric(secondNumber))
            {
                var mean = (Validator.ConvertToDecimal(firstNumber) + Validator.ConvertToDecimal(secondNumber)) / 2;
                return Ok(mean.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("division/{firstNumber}/{secondNumber}")]
        public IActionResult Division(string firstNumber, string secondNumber)
        {
            if (Validator.IsNumeric(firstNumber) && Validator.IsNumeric(secondNumber))
            {
                var div = Validator.ConvertToDecimal(firstNumber) / Validator.ConvertToDecimal(secondNumber);
                return Ok(div.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("Square-root/{firstNumber}")]
        public IActionResult SquareRoot(string firstNumber)
        {
            if (Validator.IsNumeric(firstNumber))
            {
                var squareRoot = Math.Sqrt((double)Validator.ConvertToDecimal(firstNumber));
                return Ok(squareRoot.ToString());
            }
            return BadRequest("Invalid Input");
        }
       

        
    }
}
