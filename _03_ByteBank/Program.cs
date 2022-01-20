using System;

namespace _03_ByteBank
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Tipo por referência não é o mesmo objeto na memória
            // new cria um objeto na memoria do computador, guardando o endereço do obj.
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 836146;
            
            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 836146;

            Console.WriteLine("Igualdade de tipo de referência: "+(contaDaGabriela == contaDaGabrielaCosta));
            
            //Tipos primitivos guardam valores
            int idade = 27;
            int idade2 = 27;

            Console.WriteLine("Igualdade de tipo de valor: "+(idade == idade2));

            contaDaGabriela = contaDaGabrielaCosta;
            Console.WriteLine("Apontando para o mesmo objeto na memória: "+(contaDaGabriela==contaDaGabrielaCosta));

            contaDaGabriela.saldo = 300;
            Console.WriteLine(contaDaGabriela.saldo);
            Console.WriteLine(contaDaGabrielaCosta.saldo);
        }
    }
}