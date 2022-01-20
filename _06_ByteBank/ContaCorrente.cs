using System;
using System.ComponentModel.Design;
//using _05_ByteBank;

namespace _06_ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular; //vai receber a instancia com todos atributos por referencia
        public int agencia;
        public int numero;
        private double saldo = 100;

        public void DefinirSaldo(double saldo)
        {
            if (saldo < 0)
            {
                //Quando existe return num método void ele sai e volta ao fluxo do programa
                return;
            }
            
            this.saldo = saldo;
        }
        public double ObterSaldo()
        {
            //Não existindo saldo no parametro do método ele refere-se ao atributo da classe
            return saldo;
        }
        
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