using System;

namespace _05_ByteBank
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Termo correto:
            //gabriela não é um objeto, é uma referência para o objeto do tipo cliente.
            //Cliente gabriela = new Cliente();

            //gabriela.nome = "Gabriela";
            //gabriela.cpf = "008.843.446-43";
            //gabriela.profissao = "Desenvolvedora C#";

            ContaCorrente conta = new ContaCorrente();
            //outra forma de referenciar
            //conta.titular = gabriela; //referencia pegando todos atributos da classe Cliente
            conta.titular = new Cliente();
            conta.titular.nome = "Gabriela Costa";
            conta.titular.cpf = "454.323.434-44";
            conta.titular.profissao = "Desenvolvedora C#";
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 654654;

         

            //Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(conta.titular.cpf);
            Console.WriteLine(conta.titular.profissao);

        }
    }
}