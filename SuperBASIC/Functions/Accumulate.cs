using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
	public class Accumulate : IFunction
	{
		static public float Execute(int start, int end)
		{
			float total = 0;
			for (int i = start; i <= end; i++)
			{
				total += Memory.MemoryGet((short)i);
			}
			return total;
		}

		float IFunction.Apply(List<BasicNumber> arguments)
		{
			return Execute((int)arguments[0], (int)arguments[1]);
		}
	}
}