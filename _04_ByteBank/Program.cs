using System;

namespace _04_ByteBank
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();
            contaDoBruno.titular = "Bruno";
            Console.WriteLine(contaDoBruno.titular);
            Console.WriteLine("Saldo do Bruno: "+contaDoBruno.saldo);
            bool resultadoSaque = contaDoBruno.Sacar(45);
            Console.WriteLine("Efetuado Saque de Bruno: "+resultadoSaque);
            Console.WriteLine("Saldo do Bruno: "+contaDoBruno.saldo);
            
            contaDoBruno.Depositar(500);
            Console.WriteLine("Saldo conta do Bruno: "+contaDoBruno.saldo);
            Console.WriteLine("------------------------------------");

            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            Console.WriteLine(contaDaGabriela.titular);
            Console.WriteLine("Saldo da Gabriela: "+contaDaGabriela.saldo);
            contaDoBruno.Transferir(200, contaDaGabriela);
            Console.WriteLine("Saldo do Bruno: "+contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: "+contaDaGabriela.saldo);
        }
    }
}