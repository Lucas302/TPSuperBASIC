using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperBASIC;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TestsSuperBASIC
{
	[TestClass]
	public class PartitionTest
	{
		[TestMethod]
		public void Partition()
		{

			Library lib = new Library();
			var printer = new Mock.MockPrint();
			lib.AddFunction(printer, 1, "PRINT");

			lib.AddFunction(new SuperBASIC.Functions.MemoryLoad(), 1, "MEMLOAD");
			lib.AddFunction(new SuperBASIC.Functions.MemoryStore(), 2, "MEMSTORE");
			lib.AddFunction(new SuperBASIC.Functions.Partition(), 2, "PARTITION");

			Runtime r = new Runtime(lib);
			r.OpenFile(Directory.GetCurrentDirectory() + "\\CasDeTest\\PartitionTests.basic");
			r.Run();
			Assert.AreEqual(0, printer.output[0]);
			Assert.AreEqual(3, printer.output[1]);
			Assert.AreEqual(4, printer.output[2]);
			Assert.AreEqual(0, printer.output[3]);


		}

	}
}
