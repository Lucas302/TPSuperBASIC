using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperBASIC;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TestsSuperBASIC
{
	[TestClass]
	public class SolveLinear
	{
		[TestMethod]
		public void Solve_Linear()
		{

			Library lib = new Library();
			var printer = new Mock.MockPrint();
			lib.AddFunction(printer, 1, "PRINT");

			lib.AddFunction(new SuperBASIC.Functions.MemoryLoad(), 1, "MEMLOAD");
			lib.AddFunction(new SuperBASIC.Functions.MemoryStore(), 2, "MEMSTORE");
			lib.AddFunction(new SuperBASIC.Functions.SolveLinear(), 3, "SOLVE_LINEAR");

			Runtime r = new Runtime(lib);
			r.OpenFile(Directory.GetCurrentDirectory() + "\\CasDeTest\\SolveLinearTest.basic");
			r.Run();

			Assert.AreEqual(-2, printer.output[0]);
		}

	}
}
