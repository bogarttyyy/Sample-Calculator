using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CalculatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddController : ControllerBase
    {
        // GET api/<AddController>/5/10
        [HttpGet]
        public decimal Get([FromQuery]decimal number1, [FromQuery]decimal number2)
        {
            return number1 + number2;
        }
    }
}
