using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Algorithms
{
    public class Calcorithm
    {
        public double Calculate(int a, int b, string method)
        {
            switch(method)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "*":
                    return a * b;
                case "/":
                    return a / b;
                default:
                    return 0.0;
            }
        }
    }
}
