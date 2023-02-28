using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationsController : ControllerBase
    {
        [Route("Add")]
        [HttpGet]
        public decimal GetByAddition([FromQuery] decimal number1, [FromQuery] decimal number2)
        {
            return number1 + number2;
        }

        [Route("Subtract")]
        [HttpGet]
        public decimal GetBySubtraction([FromQuery] decimal number1, [FromQuery] decimal number2)
        {
            return number1 - number2;
        }

        [Route("Multiply")]
        [HttpGet]
        public decimal GetByMultiplication([FromQuery] decimal number1, [FromQuery] decimal number2)
        {
            return number1 * number2;
        }

        [Route("Divide")]
        [HttpGet]
        public decimal GetByDivision([FromQuery] decimal number1, [FromQuery] decimal number2)
        {
            return number1 / number2;
        }
    }
}
