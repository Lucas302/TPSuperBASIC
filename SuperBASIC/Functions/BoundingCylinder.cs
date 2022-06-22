using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
    public class BoundingCylinder : IFunction
    {
        float IFunction.Apply(List<BasicNumber> arguments)
        {
            float a = arguments[0];
            float b = arguments[1];
            float d = arguments[2];
            short inta;
            short intb;
            short intd;
            if ((!Int16.TryParse(a.ToString(), out inta)) || (!Int16.TryParse(b.ToString(), out intb))
                || (!Int16.TryParse(d.ToString(), out intd)) || (b < (a + 2)) || ((b - a + 1) % 3 != 0))
            {
                return float.NaN;
            }
            else
            {
                var obb = new OrthogonalBBox();
                
                
                
                
/*                float minx = Memory.MemoryGet(inta);
                float miny = Memory.MemoryGet((short)(inta + 1));
                float minz = Memory.MemoryGet((short)(inta + 2));
                float maxx = Memory.MemoryGet(inta);
                float maxy = Memory.MemoryGet((short)(inta + 1));
                float maxz = Memory.MemoryGet((short)(inta + 2));
                for (int i = 1; i < ((intb - inta + 1) / 3); i++)
                {
                    if (Memory.MemoryGet((short)(inta + 3 * i)) < minx) { minx = Memory.MemoryGet((short)(inta + 3 * i)); }
                    if (Memory.MemoryGet((short)(inta + 3 * i + 1)) < miny) { miny = Memory.MemoryGet((short)(inta + 3 * i + 1)); }
                    if (Memory.MemoryGet((short)(inta + 3 * i + 2)) < minz) { minz = Memory.MemoryGet((short)(inta + 3 * i + 2)); }
                    if (Memory.MemoryGet((short)(inta + 3 * i)) > maxx) { maxx = Memory.MemoryGet((short)(inta + 3 * i)); }
                    if (Memory.MemoryGet((short)(inta + 3 * i + 1)) > maxy) { maxy = Memory.MemoryGet((short)(inta + 3 * i + 1)); }
                    if (Memory.MemoryGet((short)(inta + 3 * i + 2)) > maxz) { maxz = Memory.MemoryGet((short)(inta + 3 * i + 2)); }
                }
                Memory.MemorySet(intd, minx);
                Memory.MemorySet((short)(intd + 1), miny);
                Memory.MemorySet((short)(intd + 2), minz);
                Memory.MemorySet((short)(intd + 3), maxx);
                Memory.MemorySet((short)(intd + 4), maxy);
                Memory.MemorySet((short)(intd + 5), maxz);
*/                return 0;
            }
        }
    }
}
