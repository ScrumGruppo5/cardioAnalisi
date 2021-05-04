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
            int età = 20;
            double valoreaspettato = 200;
            double prova = DataCardio.Frequenzabattito(età);
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
        [TestMethod]
        public void TestMethod3()
        {
            int battiti = 60;
            string valoreAspettato = "Normale";
            string prova = DataCardio.FrequenzaCardiaca(battiti);
            Assert.AreEqual(valoreAspettato, prova);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int età = 20;
            string sesso = "Uomo";
            double peso = 70, durata = 10, frequenza = 200;
            double valoreAspettato = 0;
            double prova = DataCardio.CalorieBruciate(sesso, età, peso, durata, frequenza);
            Assert.AreEqual(valoreAspettato, prova);
        }
    }
}
