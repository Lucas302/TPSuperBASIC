using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
    class CylinderVol : IFunction
    {
		float IFunction.Apply(List<BasicNumber> arguments)
		{
			return (float)(Math.PI * arguments[0] * arguments[0] * arguments[1]);
		}
	}
}
