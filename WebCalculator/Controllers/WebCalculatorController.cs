using CalculatorProgram;
using Microsoft.AspNetCore.Mvc;

namespace WebCalculator.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class CalculatorController : ControllerBase
    {
        [HttpGet, Route(nameof(Sum))]
        public decimal Sum(decimal x, decimal y)
        {
            return new Calculator().Sum(x, y);
        }
    }
}