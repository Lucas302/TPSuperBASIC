using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
	public class Partition2 : IFunction
	{
		static public float Execute(int start, int end)
		{
			int a = start;
			int b = end;
			float pivot = Memory.MemoryGet((short)((b + a)/2));
			Console.WriteLine("pivot:" + pivot);

			while (true)
			{
				while (Memory.MemoryGet((short)a) < pivot)
					a++;

				while (Memory.MemoryGet((short)b) > pivot)
					b--;
				if (a >= b)
				{
					return b; 
				}
				if (Memory.MemoryGet((short)a) == Memory.MemoryGet((short)b))
					return b;
				var temp = Memory.MemoryGet((short)a);
				Memory.MemorySet((short)a, (float)Memory.MemoryGet((short)b));
				Memory.MemorySet((short)b, temp);
			}
		}

		float IFunction.Apply(List<BasicNumber> arguments)
		{
			return Execute((int)arguments[0], (int)arguments[1]);
		}
	}
}