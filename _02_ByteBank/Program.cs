using System;

namespace _02_ByteBank
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.titular = "Gabriela";
            conta.saldo = 200;
            
            Console.WriteLine(conta.titular);
            Console.WriteLine(conta.saldo);
            Console.WriteLine(conta.agencia);
            Console.WriteLine(conta.numero);
        }
    }
}