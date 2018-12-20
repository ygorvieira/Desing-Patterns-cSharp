using System;

namespace DesignPatterns
{
    public class RealizadorDeInvestimentos
    {
        public double RealizaInvestimento(Conta conta, Investimento investimento)
        {
            double calculador = investimento.Calcula(conta);
            return calculador;
        }
    }
}
