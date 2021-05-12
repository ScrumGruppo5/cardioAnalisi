using cardioLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataCardio_Test
{
    [TestClass]
    public class UnitTest
    {


        [DataTestMethod]
        [DataRow(20,"battiti minimi: 140 battiti massimi: 180" )]
        
        public void TestMethod2(int età, string valoreAspettato)
        {
            string prova = DataCardio.FrequenzaConsigliata(età);
            Assert.AreEqual(valoreAspettato, prova);
        }
        [DataTestMethod]
        [DataRow(60, "Normale")]
        [DataRow(40, "Bradicardia")]
        [DataRow(200, "Tachicardia")]
        public void TestMethod3(int battiti, string valoreAspettato)
        {
            string prova = DataCardio.FrequenzaCardiaca(battiti);
            Assert.AreEqual(valoreAspettato, prova);
        }
        [DataTestMethod]
        [DataRow("uomo", 20, 70, 20, 200, 425.66)]
        [DataRow("donna", 20, 67, 20, 200, 296.73)]
        public void TestMethod4(string sesso, int età, double peso, double durata, double frequenza, double valoreAspettato)
        {
            double prova = DataCardio.CalorieBruciate(sesso, età, peso, durata, frequenza);
            Assert.AreEqual(valoreAspettato, prova);
        }
        [DataTestMethod]
        [DataRow("corsa", 20, 70, 1260)]
        [DataRow("camminata", 20, 70, 700)]
        public void TestMethod5(string tipo, double km, double peso, double valoreAspettato)
        {
            double prova = DataCardio.SpesaEnergetica(tipo, km, peso);
            Assert.AreEqual(valoreAspettato, prova);
        }
        [DataTestMethod]
        [DataRow("dati.txt", 58.01)]
        public void TestMethod6(string file, double valoreAspettato)
        {
            double prova = DataCardio.MediaBattiti(file);
            Assert.AreEqual(valoreAspettato, prova);
        }
    }
}
