using System;
using System.ComponentModel.Design;
//using _05_ByteBank;

namespace _05_ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numero;
        public double saldo = 100;

        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                return false;
                //Return quando executado finaliza o método
            }

            this.saldo -= valor;
            Console.WriteLine("Efeutado saque de: " + valor);
            return true;

        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
            Console.WriteLine("Deposito Efetuado.");
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }

            this.saldo -= valor;
            contaDestino.Depositar(valor);
            Console.WriteLine("Depositado {0} para conta de {1}", valor, contaDestino.titular);
            return true;

        }
    }
}