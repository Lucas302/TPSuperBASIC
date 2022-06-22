using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperBASIC;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TestsSuperBASIC
{
	[TestClass]
	public class StalinTest
	{
		[TestMethod]
		public void Test_Stalin()
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
			lib.AddFunction(new SuperBASIC.Functions.StalinSort(), 2, "STALIN_SORT");
			Runtime r = new Runtime(lib);
			r.OpenFile(Directory.GetCurrentDirectory() + "\\CasDeTest\\TestStalin.basic");
			r.Run();
			List<float> expectedList = new List<float>{ 3, float.NaN,4,float.NaN,5};
			Assert.AreEqual(expectedList[0], printer.output[0]);
			Assert.AreEqual(expectedList[1], printer.output[1]);
			Assert.AreEqual(expectedList[2], printer.output[2]);
			Assert.AreEqual(expectedList[3], printer.output[3]);
			Assert.AreEqual(expectedList[4], printer.output[4]);
		}

	}
}
