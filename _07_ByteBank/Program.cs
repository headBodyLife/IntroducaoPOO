using System;

namespace _07_ByteBank
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(876,54342324);
            
            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);
        }
    }
}