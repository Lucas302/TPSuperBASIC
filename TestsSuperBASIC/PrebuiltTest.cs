using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperBASIC;
using System.IO;
using System.Linq;

namespace TestsSuperBASIC
{
    [TestClass]
    public class PrebuiltTest
    {
        [TestMethod]
        public void TestA()
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
			Runtime r = new Runtime(lib);
			r.OpenFile(Directory.GetCurrentDirectory() + "\\CasDeTest\\PrebuiltTest-TestA.basic");
			r.Run();
			foreach(var (expected, received) in Enumerable.Range(1,10).Zip(printer.output))
            {
				Assert.AreEqual(expected, received);
            }
		}
		[TestMethod]
		public void Test_CylinderVol()
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
			lib.AddFunction(new SuperBASIC.Functions.CylinderVol(), 2, "CYLINDER_VOL");
			Runtime r = new Runtime(lib);
			r.OpenFile(@"C:\\Users\\Administrateur\\source\\repos\\TPSuperBASIC\\TestsSuperBASIC\\CasDeTest\\Test_CylinderVol.basic");
			r.Run();
			Assert.AreEqual(37.6991118f, printer.output[0], 0.001f);
		}
	}
}
