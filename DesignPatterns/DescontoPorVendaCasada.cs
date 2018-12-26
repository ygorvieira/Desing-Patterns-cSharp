using System;

namespace DesignPatterns
{
    class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }

        private bool Existe(String nomeDoItem, Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Nome.Equals(nomeDoItem))
                    return true;
            }
            return false;
        }

        public double Desconta(Orcamento orcamento)
        {
            //Implemente mais uma estratégia de 
            //    desconto: 5 % se tivermos LAPIS
            //    e CANETA na mesma compra.
            if (Existe("LAPIS", orcamento) && Existe("CANETA", orcamento))
            {
                return orcamento.Valor * 0.05;
            }
            return Proximo.Desconta(orcamento);
        }
    }
}
