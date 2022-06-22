using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
    public class ACos : IFunction
    {
        public float Apply(List<BasicNumber> arguments)
        {
            return (float)Math.Acos(arguments[0].GetValue());
        }
    }
}
