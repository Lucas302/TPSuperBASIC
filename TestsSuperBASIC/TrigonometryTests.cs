using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperBASIC;
using System.IO;
using System.Linq;

namespace TestsSuperBASIC
{
	[TestClass]
	public class TrigoTests
	{
		[TestMethod]
		public void TestCos()
		{
			Library lib = new Library();
			var printer = new Mock.MockPrint();
			lib.AddFunction(printer, 1, "PRINT");

			lib.AddFunction(new SuperBASIC.Functions.MemoryStore(), 2, "MEMSTORE");
			lib.AddFunction(new SuperBASIC.Functions.Cos(), 1, "COS");
			Runtime r = new Runtime(lib);
			r.OpenFile(Directory.GetCurrentDirectory() + "\\CasDeTest\\TestCos.basic");
			r.Run();
			var expected = 0.8414709848;
			var received = printer.output[0];
			double delta = 0.001;
			Assert.AreEqual(expected, received, delta);
		}
	}
}
