using CalculatorAPI.Libraries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationsController : ControllerBase
    {
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
            return Operations.Divide(number1, number2);
        }
    }
}
