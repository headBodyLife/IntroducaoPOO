using System;

namespace _04_ByteBank
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();
            Console.WriteLine(contaDoBruno.saldo);
            bool resultadoSaque = contaDoBruno.Sacar(45);
            Console.WriteLine(resultadoSaque);
            Console.WriteLine(contaDoBruno.saldo);
        }
    }
}