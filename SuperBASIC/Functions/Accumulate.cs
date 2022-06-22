using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
    class Accumulate : IFunction
    {
        float a, b;
        float sum = 0;
        public float Apply(List<BasicNumber> arguments)
        {

            a = Memory.MemoryGet((short)arguments[0].GetValue());
            b = Memory.MemoryGet((short)arguments[1].GetValue());

            if (a < b)
            {
                for (var i = a; i < b+1; i++)
                {
                    sum = sum + i;
                }
            } else
            {
                return float.NaN;
            }
            return sum;
        }
    }
}
