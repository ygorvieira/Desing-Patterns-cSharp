﻿using System;

namespace DesignPatterns
{
    public class InvestidorModerado : Investimento
    {
        private Random random;
        public InvestidorModerado()
        {
            random = new Random();
        }
        public double Calcula(Conta conta)
        {
            if (random.Next(2) == 0)
            {
                return conta.Saldo * 0.025;
            }
            else
	        {
                return conta.Saldo * 0.007;
            }
        }
    }
}
