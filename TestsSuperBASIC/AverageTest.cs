using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperBASIC;
using System.IO;
using System.Linq;

namespace TestsSuperBASIC
{
	[TestClass]
	public class AverageTest
	{
		[TestMethod]
		public void Average()
		{

			Library lib = new Library();
			var printer = new Mock.MockPrint();
			lib.AddFunction(printer, 1, "PRINT");
			lib.AddFunction(new SuperBASIC.Functions.MemoryLoad(), 1, "MEMLOAD");
			lib.AddFunction(new SuperBASIC.Functions.MemoryStore(), 2, "MEMSTORE");
			lib.AddFunction(new SuperBASIC.Functions.Multiply(), 2, "MULTIPLY");
			lib.AddFunction(new SuperBASIC.Functions.Add(), 2, "ADD");
			lib.AddFunction(new SuperBASIC.Functions.Compare(), 2, "COMPARE");
			lib.AddFunction(new SuperBASIC.Functions.JumpZero(), 2, "JZ");
			lib.AddFunction(new SuperBASIC.Functions.Goto(), 1, "GOTO");
			lib.AddFunction(new SuperBASIC.Functions.Pi(), 0, "PI");
			lib.AddFunction(new SuperBASIC.Functions.Euler(), 0, "EULER");
			lib.AddFunction(new SuperBASIC.Functions.Accumulate(), 2, "ACCUMULATE");
			lib.AddFunction(new SuperBASIC.Functions.Average(), 2, "AVERAGE");

			Runtime r = new Runtime(lib);
			r.OpenFile(Directory.GetCurrentDirectory() + "\\CasDeTest\\AverageTest.basic");
			r.Run();
			Assert.AreEqual(5, printer.output[0]);
		}

	}
}
