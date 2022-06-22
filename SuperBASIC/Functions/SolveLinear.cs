using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
    public class SolveLinear : IFunction
    {
        float IFunction.Apply(List<BasicNumber> arguments)
        {
            float b = arguments[1].GetValue() - arguments[2].GetValue();
            float a = arguments[0].GetValue();
            float solution = float.NaN;

            if (a != 0)
            {
                solution = (-b / a);
            }
            else if (a == b)
            {
                Console.WriteLine("a = b = 0 => infinité de solutions");
            }
            else
            {
                Console.WriteLine("division par 0");
                solution = float.NaN;
            }
            return solution;
        }
    }
}