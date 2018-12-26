namespace DesignPatterns.Exercicios.Aula_02
{
    interface Resposta
    {
        void Responde(Requisicao req, Conta conta);
        Resposta OutraResposta { get; set; }
    }
}
