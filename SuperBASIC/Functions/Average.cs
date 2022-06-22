using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
	public class Average : IFunction
	{
		float IFunction.Apply(List<BasicNumber> arguments)
		{
			float count = arguments[1] - arguments[0] + 1;
			float total = Accumulate.Execute((int)arguments[0], (int)arguments[1]);
			float average = total / count;

			return average;
		}
	}
}