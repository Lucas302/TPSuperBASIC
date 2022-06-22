using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
    public class StalinSort : IFunction
    {
        float IFunction.Apply(List<BasicNumber> arguments)
        {
            float temp = Memory.memory[(int)arguments[0]];
            for (int i = (int)arguments[0].GetValue(); i <= arguments[1].GetValue(); i++)
            {
                if (Memory.MemoryGet((short)i) < temp)
                    Memory.MemorySet((short)i, float.NaN);
                else
                    temp = Memory.MemoryGet((short)i);
            }
            return 0;
        }
    }
}
