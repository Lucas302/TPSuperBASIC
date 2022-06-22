using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperBASIC.Functions
{
    public struct Point { public float x; public float y; public float z; }
    public class OrthogonalBBox : IFunction
    {
        static public (Point, Point) CalculateBox(List<Point> points)
        {
            Point petit;
            Point grand;

            petit = grand = points.First();

            foreach(var pt in points.Skip(1))
            {
                petit.x = Math.Min(pt.x, petit.x);
                petit.y = Math.Min(pt.y, petit.y);
                petit.z = Math.Min(pt.z, petit.z);
            }

            foreach (var pt in points.Skip(1))
            {
                grand.x = Math.Max(pt.x, grand.x);
                grand.y = Math.Max(pt.y, grand.y);
                grand.z = Math.Max(pt.z, grand.z);
            }

            return (petit, grand);
        }

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

                var (petit, grand) = CalculateBox(listepoints);

                Memory.MemorySet(intd, petit.x);
                Memory.MemorySet((short)(intd + 1), petit.y);
                Memory.MemorySet((short)(intd + 2), petit.z);
                Memory.MemorySet((short)(intd + 3), grand.x);
                Memory.MemorySet((short)(intd + 4), grand.y);
                Memory.MemorySet((short)(intd + 5), grand.z);

                /*              float minx = Memory.MemoryGet(inta);
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
                */
                return 0;
            }
        }
    }
}
