using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns
{
    [TestClass]
    public class DescontoTest
    {
        private CalculadorDeDescontos calculador;

        [TestInitialize]
        public void CriaDesconto()
        {
            calculador = new CalculadorDeDescontos();
        }

        [TestMethod]
        public void DeveRetornar5PorcentoDeDescontoSeComprarLapisECaneta()
        {
            Orcamento orcamento = new Orcamento(100.0);
            orcamento.AdicionaItem(new Item("CANETA", 10));
            orcamento.AdicionaItem(new Item("LAPIS", 10));
            double desconto = calculador.Calcula(orcamento);
            Assert.AreEqual(5, desconto, 0.0001);
        }

        [TestMethod]
        public void NaoDeveDarDescontoSeNaoTiverVendaCasada()
        {
            Orcamento orcamento = new Orcamento(100.0);
            orcamento.AdicionaItem(new Item("XBOX", 10));
            orcamento.AdicionaItem(new Item("CARTEIRA", 10));
            double desconto = calculador.Calcula(orcamento);
            Assert.AreEqual(0, desconto, 0.0001);
        }
    }
}
