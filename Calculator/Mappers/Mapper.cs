using Calculator.Models;

namespace Calculator.Mappers
{
    public class Mapper
    {
        public static CalcResult Map(int nOne, int nTwo, string method, double res)
        {
            CalcResult result = new CalcResult
            {
                NumberOne = nOne,
                NumberTwo = nTwo,
                Method = method,
                Result = res
            };
            return result;
        }
    }
}
