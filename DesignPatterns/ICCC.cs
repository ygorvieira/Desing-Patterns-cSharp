namespace DesignPatterns
{
    public class ICCC : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            double valor = orcamento.Valor;

            if (valor < 1000.0)
            {
                return orcamento.Valor * 0.05;
            }
            else if (valor >= 1000.0 && 
                valor <= 3000.0)
            {
                return orcamento.Valor * 0.07;
            }
            else
            {
                return (valor * 0.08) + 30;
            }
        }
    }
}
