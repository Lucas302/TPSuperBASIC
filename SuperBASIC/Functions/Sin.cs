using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
    public class Sin : IFunction
    {
        public float Apply(List<BasicNumber> arguments)
        {
            return (float)Math.Sin(arguments[0].GetValue());
        }
    }
}
