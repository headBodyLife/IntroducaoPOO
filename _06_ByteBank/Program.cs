using System;
using System.Runtime.CompilerServices;

namespace _06_ByteBank
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Guilherme";
            cliente.Cpf = "455.232.546-55";
            cliente.Profissao = "DevOps";
            
            conta.Saldo = -10;
            conta.Titular = cliente;

            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Saldo);
        }
    }
}