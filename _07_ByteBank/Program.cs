using System;
using System.Runtime.InteropServices;

namespace _07_ByteBank
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            
            
            ContaCorrente conta = new ContaCorrente(876,54342324);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            ContaCorrente contaDaGabriela = new ContaCorrente(867, 84354353);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            
            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            
        }
    }
}