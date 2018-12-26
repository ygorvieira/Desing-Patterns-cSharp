using System;

namespace DesignPatterns.Exercicios.Aula_02
class Conta
{
    public String Titular { get; private set; }
    public double Saldo { get; private set; }

    public Conta(String titular, double saldo)
    {
        this.Titular = titular;
        this.Saldo = saldo;
    }
}