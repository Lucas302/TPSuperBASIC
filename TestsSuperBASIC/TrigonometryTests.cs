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
			var expected = 0.54030230586;
			var received = printer.output[0];
			double delta = 0.001;
			Assert.AreEqual(expected, received, delta);
		}
		[TestMethod]
		public void TestACos()
		{
			Library lib = new Library();
			var printer = new Mock.MockPrint();
			lib.AddFunction(printer, 1, "PRINT");

			lib.AddFunction(new SuperBASIC.Functions.MemoryStore(), 2, "MEMSTORE");
			lib.AddFunction(new SuperBASIC.Functions.ACos(), 1, "ACOS");
			Runtime r = new Runtime(lib);
			r.OpenFile(Directory.GetCurrentDirectory() + "\\CasDeTest\\TestACos.basic");
			r.Run();
			var expected = 0;
			var received = printer.output[0];
			double delta = 0.001;
			Assert.AreEqual(expected, received, delta);
		}
		[TestMethod]
		public void TestSin()
		{
			Library lib = new Library();
			var printer = new Mock.MockPrint();
			lib.AddFunction(printer, 1, "PRINT");

			lib.AddFunction(new SuperBASIC.Functions.MemoryStore(), 2, "MEMSTORE");
			lib.AddFunction(new SuperBASIC.Functions.Sin(), 1, "SIN");
			Runtime r = new Runtime(lib);
			r.OpenFile(Directory.GetCurrentDirectory() + "\\CasDeTest\\TestSin.basic");
			r.Run();
			var expected = 0.8414709848;
			var received = printer.output[0];
			double delta = 0.001;
			Assert.AreEqual(expected, received, delta);
		}

		[TestMethod]
		public void TestAsin()
		{
			Library lib = new Library();
			var printer = new Mock.MockPrint();
			lib.AddFunction(printer, 1, "PRINT");

			lib.AddFunction(new SuperBASIC.Functions.MemoryStore(), 2, "MEMSTORE");
			lib.AddFunction(new SuperBASIC.Functions.ASin(), 1, "ASIN");
			Runtime r = new Runtime(lib);
			r.OpenFile(Directory.GetCurrentDirectory() + "\\CasDeTest\\TestAsin.basic");
			r.Run();
			var expected = 1.57079633;
			var received = printer.output[0];
			double delta = 0.001;
			Assert.AreEqual(expected, received, delta);
		}
		[TestMethod]
		public void TestTan()
		{
			Library lib = new Library();
			var printer = new Mock.MockPrint();
			lib.AddFunction(printer, 1, "PRINT");

			lib.AddFunction(new SuperBASIC.Functions.MemoryStore(), 2, "MEMSTORE");
			lib.AddFunction(new SuperBASIC.Functions.Tan(), 1, "TAN");
			Runtime r = new Runtime(lib);
			r.OpenFile(Directory.GetCurrentDirectory() + "\\CasDeTest\\TestTan.basic");
			r.Run();
			var expected = 1.55740772;
			var received = printer.output[0];
			double delta = 0.001;
			Assert.AreEqual(expected, received, delta);
		}
		[TestMethod]
		public void TestAtan()
		{
			Library lib = new Library();
			var printer = new Mock.MockPrint();
			lib.AddFunction(printer, 1, "PRINT");

			lib.AddFunction(new SuperBASIC.Functions.MemoryStore(), 2, "MEMSTORE");
			lib.AddFunction(new SuperBASIC.Functions.ATan(), 1, "ATAN");
			Runtime r = new Runtime(lib);
			r.OpenFile(Directory.GetCurrentDirectory() + "\\CasDeTest\\TestAtan.basic");
			r.Run();
			var expected = 0.78539816;
			var received = printer.output[0];
			double delta = 0.001;
			Assert.AreEqual(expected, received, delta);
		}
	}
}
