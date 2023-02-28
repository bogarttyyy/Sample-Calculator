using CalculatorAPI.Libraries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CalculatorAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class OperationsController : ControllerBase
    {
        public readonly ILogger<OperationsController> _logger;
        public OperationsController(ILogger<OperationsController> logger)
        {
            _logger = logger;
        }

        [Route("IsLive")]
        [HttpGet]
        public bool IsLive()
        {
            return true;
        }

        /// <summary>
        /// Adds the two decimal parameters
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        [Route("Add")]
        [HttpGet]
        public decimal GetByAddition([FromQuery] decimal number1, [FromQuery] decimal number2)
        {
            _logger.LogInformation($"Adding numbers {number1} and {number2}");
            return Operations.Add(number1, number2);
        }

        /// <summary>
        /// Subtracts the two decimal parameters
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        [Route("Subtract")]
        [HttpGet]
        public decimal GetBySubtraction([FromQuery] decimal number1, [FromQuery] decimal number2)
        {
            _logger.LogInformation($"Subtracting numbers {number1} and {number2}");
            return Operations.Subtract(number1, number2);
        }

        /// <summary>
        /// Multiplies the two decimal parameters
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        [Route("Multiply")]
        [HttpGet]
        public decimal GetByMultiplication([FromQuery] decimal number1, [FromQuery] decimal number2)
        {
            _logger.LogInformation($"Multiplying numbers {number1} and {number2}");
            return Operations.Multiply(number1, number2);
        }

        /// <summary>
        /// Divides the two decimal parameters
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        [Route("Divide")]
        [HttpGet]
        public decimal GetByDivision([FromQuery] decimal number1, [FromQuery] decimal number2)
        {
            _logger.LogInformation($"Dividing numbers {number1} and {number2}");
            return Operations.Divide(number1, number2);
        }
    }
}
