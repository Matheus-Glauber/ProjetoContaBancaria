using Modulo5.Models;
using System;

namespace Modulo5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número da conta: ");
            int NumeroTitular = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string nomeTitular = Console.ReadLine();

            Console.Write("Haverá Depósito Inicial (s/n)? ");
            char deposita = char.Parse(Console.ReadLine());

            double valorDoDeposito = depositoInicial(deposita);

            Conta conta1 = new Conta(NumeroTitular, nomeTitular, valorDoDeposito);

            Console.WriteLine(conta1.ToString());

            Console.Write("Entre com o valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine());

            conta1.Deposito(deposito);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta1.ToString());

            Console.Write("Entre com o valor para saque: ");
            double saque = double.Parse(Console.ReadLine());
                        
            conta1.Saque(saque);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta1.ToString());

            double depositoInicial(char dep)
            {
                double valor;
                if (dep == 's')
                {
                    Console.Write("Entre com o valor do depósito Inicial: ");
                    valor = double.Parse(Console.ReadLine());
                }
                else
                {
                    Console.Write("Sem depósito inicial!");
                    valor = 0;
                }
                return valor;
            }
        }
    }
}
