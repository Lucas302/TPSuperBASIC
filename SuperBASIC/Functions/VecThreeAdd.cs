using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
    class VecThreeAdd : IFunction
    {
        public float Apply(List<BasicNumber> arguments)
        {
            float value = arguments[2].GetValue();          

            for (var i = 0; i < 3; i++)
            {
               Memory.MemorySet((short)value, ((arguments[0].GetValue() + i) + (arguments[1].GetValue + i)));
               value++;
            }
            return 0;
        }
    }
}
