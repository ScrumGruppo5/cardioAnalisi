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
        [DataRow(40, "minima: 126 massima: 162")]
        [DataRow(18, "minima: 141 massima: 181")]

        public void TestMinMax(int et‡, string valoreAspettato)
        {
            string prova = DataCardio.FrequenzaConsigliata(et‡);
            Assert.AreEqual(valoreAspettato, prova);
        }
        [DataTestMethod]
        [DataRow(60, "Normale")]
        [DataRow(40, "Bradicardia")]
        [DataRow(200, "Tachicardia")]
        [DataRow(65, "Normale")]
        [DataRow(50, "Bradicardia")]
        [DataRow(110, "Tachicardia")]
        public void TestTipo(int battiti, string valoreAspettato)
        {
            string prova = DataCardio.FrequenzaCardiaca(battiti);
            Assert.AreEqual(valoreAspettato, prova);
        }
        [DataTestMethod]
        [DataRow("uomo", 20, 70, 20, 200, 425.66)]
        [DataRow("donna", 20, 67, 20, 200, 296.73)]
        [DataRow("uomo", 30, 80, 30, 190, 621.98)]
        [DataRow("donna", 30, 69, 25, 190, 347.11)]
        public void TestCalorieBruciate(string sesso, int et‡, double peso, double durata, double frequenza, double valoreAspettato)
        {
            double prova = DataCardio.CalorieBruciate(sesso, et‡, peso, durata, frequenza);
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
        [DataRow("dati.txt", 58.01)]
        public void TestMediaBattiti(string file, double valoreAspettato)
        {
            double prova = DataCardio.MediaBattiti("datiProva.txt");
            Assert.AreEqual(valoreAspettato, prova);
        }
        [DataTestMethod]
        [DataRow("dati.txt", 55)]
        public void TestBattitiRiposo(string file, int valoreAspettato)
        {
            int prova = DataCardio.BattitiRiposo("datiProva.txt");
            Assert.AreEqual(valoreAspettato, prova);
        }
        [DataTestMethod]
        [DataRow("dati.txt", 6)]
        public void TestVariabilit‡(string file, int valoreAspettato)
        {
            int prova = DataCardio.Variabilit‡Battiti("datiProva.txt");
            Assert.AreEqual(valoreAspettato, prova);
        }
        [DataTestMethod]
        [DataRow(30, 177.65)]
        [DataRow(24, 183.26)]
        [DataRow(40, 168.3)]
        public void TestSoglia(int et‡, double valoreAspettato)
        {
            double prova = DataCardio.SogliaAnaerobica(et‡);
            Assert.AreEqual(valoreAspettato, prova);
        }

    }
}
