using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
    class Rem : IFunction

    {
        public float Apply(List<BasicNumber> arguments)
        {
            return (arguments[0].GetValue() % arguments[1].GetValue());
        }
    }
}
