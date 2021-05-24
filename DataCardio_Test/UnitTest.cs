using cardioLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataCardio_Test
{
    [TestClass]
    public class UnitTest
    {
        [DataTestMethod]
        [DataRow(20, "minima: 140 massima: 180")]
        [DataRow(33, "minima: 130 massima: 168")]

        public void TestMinMax(int età, string valoreAspettato)
        {
            string prova = DataCardio.FrequenzaConsigliata(età);
            Assert.AreEqual(valoreAspettato, prova);
        }
        [DataTestMethod]
        [DataRow(60, "Normale")]
        [DataRow(40, "Bradicardia")]
        [DataRow(200, "Tachicardia")]
        public void TestTipo(int battiti, string valoreAspettato)
        {
            string prova = DataCardio.FrequenzaCardiaca(battiti);
            Assert.AreEqual(valoreAspettato, prova);
        }
        [DataTestMethod]
        [DataRow("uomo", 20, 70, 20, 200, 425.66)]
        [DataRow("donna", 20, 67, 20, 200, 296.73)]
        public void TestCalorieBruciate(string sesso, int età, double peso, double durata, double frequenza, double valoreAspettato)
        {
            double prova = DataCardio.CalorieBruciate(sesso, età, peso, durata, frequenza);
            Assert.AreEqual(valoreAspettato, prova);
        }
        [DataTestMethod]
        [DataRow("corsa", 20, 70, "1260")]
        [DataRow("camminata", 20, 70, "700")]
        [DataRow("ciao", 20, 70, "Input Errato")]
        public void TestSpesaEnergetica(string tipo, double km, double peso, string valoreAspettato)
        {
            string prova = DataCardio.SpesaEnergetica(tipo, km, peso);
            Assert.AreEqual(valoreAspettato, prova);
        }
        [DataTestMethod]
        [DataRow(30, 177.65)]
        [DataRow(24, 183.26)]
        [DataRow(40, 168.3)]
        public void TestSoglia(int età, double valoreAspettato)
        {
            double prova = DataCardio.SogliaAnaerobica(età);
            Assert.AreEqual(valoreAspettato, prova);
        }

    }
}
