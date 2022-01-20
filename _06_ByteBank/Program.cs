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

            cliente.nome = "Guilherme";
            cliente.cpf = "455.232.546-55";
            cliente.profissao = "DevOps";
            conta.Saldo = -10;
            conta.Titular = cliente;

            Console.WriteLine(conta.Titular.nome);
            Console.WriteLine(conta.Saldo);
        }
    }
}