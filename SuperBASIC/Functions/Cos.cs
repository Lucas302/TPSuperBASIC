using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
	public class Cos : IFunction
	{
		float IFunction.Apply(List<BasicNumber> arguments)
		{
			return (float)Math.Sin(arguments[0]);
		}
	}
}
