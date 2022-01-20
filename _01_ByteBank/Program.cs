using System;

namespace _01_ByteBank
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 856146;
            contaDaGabriela.saldo = 100;
            Console.WriteLine(contaDaGabriela.titular);
            Console.WriteLine("Agência: "+contaDaGabriela.agencia);
            Console.WriteLine("Número :"+contaDaGabriela.numero);
            Console.WriteLine("Saldo :"+contaDaGabriela.saldo);

            contaDaGabriela.saldo += 200;
            Console.WriteLine("Saldo :"+contaDaGabriela.saldo);

        }
    }
}