using System;
using System.Runtime.CompilerServices;

namespace _06_ByteBank
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            //conta.saldo = -10;
            conta.DefinirSaldo(101);
            Console.WriteLine(conta.ObterSaldo());
        }
    }
}