using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
    class Sin : IFunction
    {
        public float Apply(List<BasicNumber> arguments)
        {
            return (float)Math.Sin(arguments[0]);
        }
    }
}
