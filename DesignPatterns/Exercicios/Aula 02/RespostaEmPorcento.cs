using System;

namespace DesignPatterns.Exercicios.Aula_02
{
    class RespostaEmPorcento : Resposta
    {
        public Resposta OutraResposta { get; set; }

        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.PORCENTO)
            {
                Console.WriteLine(conta.Titular + "%" + conta.Saldo);
            }
            else if (OutraResposta != null)
            {
                OutraResposta.Responde(req, conta);
            }
            else
            {
                throw new Exception("Formato de resposta não encontrado");
            }
        }
    }
}
