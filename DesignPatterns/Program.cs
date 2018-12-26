using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            Orcamento orcamento = new Orcamento(500.0);
            orcamento.AdicionaItem(new Item("CANETA", 500));
            orcamento.AdicionaItem(new Item("LAPIS", 250));
            orcamento.AdicionaItem(new Item("GELADEIRA", 250));
            orcamento.AdicionaItem(new Item("FOGAO", 250));
            orcamento.AdicionaItem(new Item("CELULAR", 250));
            orcamento.AdicionaItem(new Item("XBOX", 250));

            double desconto = calculador.Calcula(orcamento);
            Console.WriteLine(desconto);

        }

        private static void Strategy()
        {
            Imposto icms = new ICMS();
            Imposto iss = new ISS();

            Orcamento orcamento = new Orcamento(500);

            CalculadorDeImpostos calculador = new CalculadorDeImpostos();
            calculador.RealizaCalculo(orcamento, icms);
            calculador.RealizaCalculo(orcamento, iss);
        }
    }
}
