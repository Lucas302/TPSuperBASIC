using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
	public class Compare : IFunction
	{
		float IFunction.Apply(List<BasicNumber> arguments)
		{
			return arguments[0].GetValue() == arguments[1].GetValue() ? 1 : 0;
		}
	}
}
