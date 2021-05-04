using cardioLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataCardio_Test
{
    [TestClass]
    public class UnitTest
    {

            [TestMethod]
            public void TestMethod1()
            {
                int et� = 20;
                double valoreaspettato = 200;
                double prova = DataCardio.Frequenzabattito(et�);
                Assert.AreEqual(valoreaspettato, prova);
            }
            [TestMethod]
            public void TestMethod2()
            {
                int f = 200;
                bool valoreaspettato = false;
                bool prova = DataCardio.FrequenzaConsigliata(f);
                Assert.AreEqual(valoreaspettato, prova);
            }
        }
    }
}
