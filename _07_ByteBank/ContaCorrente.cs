using System;
using System.ComponentModel.Design;
using System.Runtime.Remoting;

//using _05_ByteBank;

namespace _07_ByteBank
{
    public class ContaCorrente
    {
        private Cliente _titular; //vai receber a instancia com todos atributos por referencia
        
        public Cliente Titular
        {
            get
            {
                return _titular;
            }
            set
            {
                _titular = value;
            }
        }

        public static int TotalDeContasCriadas { get; private set; }

      
        private int _agencia;

        public int Agencia
        {
            get
            {
                return _agencia;
            } 
            set
            {
                if (value <=0)
                {
                    return;
                }

                _agencia = value;
            }
        }

        public int Numero { get; set; }
        
  
        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    //Quando existe return num método void ele sai e volta ao fluxo do programa
                    return;
                }
                this._saldo = value;
            }
        }

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            ContaCorrente.TotalDeContasCriadas++;
        }
   
        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
                //Return quando executado finaliza o método
            }

            this._saldo -= valor;
            Console.WriteLine("Efeutado saque de: " + valor);
            return true;

        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
            Console.WriteLine("Deposito Efetuado.");
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }

            this._saldo -= valor;
            contaDestino.Depositar(valor);
            Console.WriteLine("Depositado {0} para conta de {1}", valor, contaDestino._titular);
            return true;

        }
    }
}