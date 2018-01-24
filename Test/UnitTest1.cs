using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Suma6()
        {
            long[] numerosSumar = { 1, 2, 3 };

            long resultado = Program.Sumar(numerosSumar);

            Assert.AreEqual(6, resultado);
        }
    }
}
