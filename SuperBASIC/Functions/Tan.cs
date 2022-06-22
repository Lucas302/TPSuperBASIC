using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
    public class Tan : IFunction
    {
        public float Apply(List<BasicNumber> arguments)
        {
            return (float)Math.Tan(arguments[0].GetValue());
        }
    }
}
