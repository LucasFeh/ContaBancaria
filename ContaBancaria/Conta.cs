using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria
{
    class Conta
    {
        public int Numero { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; private set; }


        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            Saldo = 0.00;
        }
        public Conta(int numero, string titular, double saldo): this( numero, titular)
        {
            Saldo = saldo;

        }

        public void Deposito(double saldo )
        {
            Saldo += saldo;

        }
        public void Saque(double saque)
        {
            Saldo -= saque + 5;
        }

        public override string ToString()
        {
            return "Conta " + Numero + ", Titular " + Titular + " Saldo: $" + Saldo;
        }

        







    }
}
