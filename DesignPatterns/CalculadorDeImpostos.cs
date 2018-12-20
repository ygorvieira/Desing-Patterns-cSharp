namespace DesignPatterns
{
    public class CalculadorDeImpostos
    {
        public double RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {
            double calculador = imposto.Calcula(orcamento);
            return calculador;
        }
    }
}
