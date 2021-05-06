using cardioLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataCardio_Test
{
    [TestClass]
    public class UnitTest
    {

        [DataTestMethod]
        [DataRow(20, 200)]
        [DataRow(35, 185)]
        public void TestMethod1(int età, int valoreAspettato)
        {
            int prova = DataCardio.Frequenzabattito(età);
            Assert.AreEqual(valoreAspettato, prova);
        }
        [DataTestMethod]
        [DataRow(200, false)]
        [DataRow(190, false)]
        public void TestMethod2(int frequenza, bool valoreAspettato)
        {
            bool prova = DataCardio.FrequenzaConsigliata(frequenza);
            Assert.AreEqual(valoreAspettato, prova);
        }
        [DataTestMethod]
        [DataRow(60,"Normale")]
        [DataRow(40 , "Bradicardia")]
        [DataRow(200, "Tachicardia")]
        public void TestMethod3(int battiti,string valoreAspettato)
        {           
            string prova = DataCardio.FrequenzaCardiaca(battiti);
            Assert.AreEqual(valoreAspettato, prova);
        }
        [DataTestMethod]
        [DataRow("uomo",20,70,20,200,-139.57)]
        [DataRow("donna", 20, 67, 20, 200,407.28)]
        public void TestMethod4(string sesso, int età, double peso, double durata, double frequenza, double valoreAspettato)
        {
            double prova = DataCardio.CalorieBruciate(sesso, età, peso, durata, frequenza);
            Assert.AreEqual(valoreAspettato, prova);
        }
        [DataTestMethod]
        [DataRow("corsa",20,70,1260)]
        [DataRow("camminata",20,70,700)]
        public void TestMethod5(string tipo, double km, double peso, double valoreAspettato)
        {
            double prova = DataCardio.SpesaEnergetica(tipo, km, peso);
            Assert.AreEqual(valoreAspettato, prova);
        }
    }
}
