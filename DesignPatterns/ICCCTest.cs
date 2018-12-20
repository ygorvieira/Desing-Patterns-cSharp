using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns
{
    [TestClass]
    public class ICCCTest
    {
        private ICCC iccc;
        private CalculadorDeImpostos calculador;

        [TestInitialize]
        public void CriaImposto()
        {
            iccc = new ICCC();
            calculador = new CalculadorDeImpostos();
        }

        [TestMethod]
        public void DeveRetornar5PorcentoSeOrcamentoMenorQue1000()
        {
            Orcamento orcamento = new Orcamento(500);
            Assert.AreEqual(25, calculador.RealizaCalculo(orcamento, iccc), 0.0001);
        }

        [TestMethod]
        public void DeveRetornar7PorCentoSeOrcamentoForEntre1000E3000()
        {
            Orcamento orcamento = new Orcamento(2000);
            Assert.AreEqual(140, calculador.RealizaCalculo(orcamento, iccc), 0.0001);
        }

        [TestMethod]
        public void DeveRetornar8PorcentoMais30ReaisSeOrcamentoForAcimaDe3000()
        {
            Orcamento orcamento = new Orcamento(4000);
            Assert.AreEqual(350, calculador.RealizaCalculo(orcamento, iccc), 0.0001);
        }
    }
}
