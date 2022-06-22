using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
    class Vec3Add : IFunction
    {
        public float Apply(List<BasicNumber> arguments)
        {
            float a = arguments[0];

            float b = arguments[1];

            float d = arguments[2];

            short intd;

            if ((!Int16.TryParse(d.ToString(), out intd)))

            {

                return float.NaN;

            }

            else

            {

                Memory.MemorySet(intd, arguments[0] + arguments[1]);

                Memory.MemorySet((short)(intd + 1), arguments[0] + arguments[1] + 2);

                Memory.MemorySet((short)(intd + 2), arguments[0] + arguments[1] + 4);

                return 0;

            }
        }
    }
}
