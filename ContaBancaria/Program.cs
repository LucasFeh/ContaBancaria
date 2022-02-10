using System;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta;

            Console.Write("Entre com o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Deseja iniciar com deposito inicial? s/n? ");
            char r = char.Parse(Console.ReadLine());
            if (r == 's'|| r =='S')
            {
                Console.Write("Entre com o valor do deposito inicial: ");
                double Di = double.Parse(Console.ReadLine());
                conta = new Conta(numero, titular,Di);
                Console.WriteLine("Conta criada: " + conta);
            }
            else
            {
                conta = new Conta(numero, titular);
                Console.WriteLine("Conta criada: "+conta);
            }


            Console.WriteLine("Deseja fazer um deposito? s/n ");
            char d = char.Parse(Console.ReadLine());
            while(d == 's'|| d == 'S' )
            {
                Console.WriteLine();
                Console.Write("Entre com o valor do deposito: ");
                double saldo = double.Parse(Console.ReadLine());
                conta.Deposito(saldo);
                Console.WriteLine();
                Console.WriteLine("Conta Atualizada: " + conta);
                Console.WriteLine();
                Console.Write("Deseja depositar novamente? s/n ");
                d = char.Parse(Console.ReadLine());
            }

            Console.WriteLine("Dseja fazer um saque? s/n ");
            char s = char.Parse(Console.ReadLine());
            while (s == 's' || s == 'S')
            {
                Console.Write("Entre com o valor para saque: ");
                double saque = double.Parse(Console.ReadLine());
                conta.Saque(saque);
                Console.WriteLine();
                Console.WriteLine("Conta Atualizada: " + conta);
                Console.WriteLine();
                Console.Write("Deseja sacar novamente? s/n ");
                s = char.Parse(Console.ReadLine());

            }
            Console.WriteLine();
            Console.WriteLine("programa finalizado obrigado!! ");









        }
    }
}
