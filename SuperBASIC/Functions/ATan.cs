using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
    public class ATan : IFunction
    {
        public float Apply(List<BasicNumber> arguments)
        {
            return (float)Math.Atan(arguments[0].GetValue());
        }
    }
}
