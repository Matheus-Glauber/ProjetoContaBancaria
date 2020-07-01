using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Modulo5.Models
{
    class Conta
    {
        public int NumeroConta { get; private set; }
        public string NomeTitular { get; set; }
        private double Saldo;

        private static double Taxa = 5;

        public Conta(int numeroConta, string nomeTitular, double saldo)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            Saldo = saldo;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia; 
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + Taxa;
        }

        public override string ToString()
        {
            return $"Conta: {NumeroConta}, Titular: {NomeTitular}, Saldo R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
