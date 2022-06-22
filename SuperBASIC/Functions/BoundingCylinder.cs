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
                var listepoints = new List<Point>();
                for (int i = 0; i < ((intb - inta + 1) / 3); i++)
                {
                    var point = new Point();
                    point.x = Memory.MemoryGet((short)(inta + 3 * i));
                    point.y = Memory.MemoryGet((short)(inta + 3 * i + 1));
                    point.z = Memory.MemoryGet((short)(inta + 3 * i + 2));
                    listepoints.Add(point);
                }
                var petit = new Point();
                var grand = new Point();
                (petit, grand) = OrthogonalBBox.CalculateBox(listepoints);

                Memory.MemorySet(intd, (petit.x + grand.x) / 2);
                Memory.MemorySet((short)(intd + 1), (petit.y + grand.y) / 2);
                Memory.MemorySet((short)(intd + 2), petit.z);
                Memory.MemorySet((short)(intd + 3), (float)System.Math.Sqrt((grand.x - petit.x) * (grand.x - petit.x) / 4.0f + (grand.y - petit.y) * (grand.y - petit.y) / 4.0f));
                Memory.MemorySet((short)(intd + 4), grand.z - petit.z);

                return 0;
            }
        }
    }
}
