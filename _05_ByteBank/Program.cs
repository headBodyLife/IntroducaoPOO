using System;

namespace _05_ByteBank
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Cliente gabriela = new Cliente();

            gabriela.nome = "Gabriela";
            gabriela.cpf = "008.843.446-43";
            gabriela.profissao = "Desenvolvedora C#";

            ContaCorrente conta = new ContaCorrente();
            conta.titular = gabriela; //referencia pegando todos atributos da classe Cliente
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 654654;

            Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome);

        }
    }
}