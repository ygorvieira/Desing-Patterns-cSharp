namespace DesignPatterns
{
    public class InvestidorConservador : Investimento
    {
        public double Calcula(Conta conta)
        {
            return conta.Saldo * 0.008;
        }
    }
}
