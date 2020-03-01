using Calculator.Models;
using Calculator.Algorithms;
using Calculator.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("plus/{a}/{b}")]
        public ActionResult<CalcResult> CalcPlus(int a, int b)
        {
            double result = new Calcorithm().Calculate(a, b, "+");
            return Ok(Mapper.Map(a, b, "+", result));
        }

        [HttpGet("minus/{a}/{b}")]
        public ActionResult<CalcResult> CalcMinus(int a, int b)
        {
            double result = new Calcorithm().Calculate(a, b, "-");
            return Ok(Mapper.Map(a, b, "-", result));
        }

        [HttpGet("multiply/{a}/{b}")]
        public ActionResult<int> CalcMultiply(int a, int b)
        {
            double result = new Calcorithm().Calculate(a, b, "*");
            return Ok(Mapper.Map(a, b, "*", result));
        }

        [HttpGet("divide/{a}/{b}")]
        public ActionResult<CalcResult> CalcDivision(int a, int b)
        {
            if(!(b == 0))
            {
                double result = new Calcorithm().Calculate(a, b, "/");
                return Ok(Mapper.Map(a, b, "/", result));
            } else
            {
                return BadRequest("Unable to divide by 0");
            }
        }
    }
}
