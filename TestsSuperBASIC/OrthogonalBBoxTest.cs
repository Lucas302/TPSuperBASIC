using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperBASIC;
using System.IO;
using System.Linq;
using System;
using System.Collections.Generic;


namespace TestsSuperBASIC
{
	[TestClass]
	public class OrthogonalBBoxTest
    {
		[TestMethod]
		public void Test_OrthogonalBBox()
		{

			Library lib = new Library();
			var printer = new Mock.MockPrint();
			lib.AddFunction(printer, 1, "PRINT");

			lib.AddFunction(new SuperBASIC.Functions.MemoryStore(), 2, "MEMSTORE");
			lib.AddFunction(new SuperBASIC.Functions.OrthogonalBBox(), 3, "ORTHOGONAL_BBOX");
			Runtime r = new Runtime(lib);
			r.OpenFile(Directory.GetCurrentDirectory() + "\\CasDeTest\\Test_OrthogonalBBox.basic");
			r.Run();
			List<int> liste = new List<int> { 1, 2, 2, 8, 8, 6 };
			foreach (var (expected, received) in liste.Zip(printer.output))
			{
				Assert.AreEqual(expected, received);
			}
		}
	}
}
