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
            if (r == 's' || r == 'S')
            {
                Console.Write("Entre com o valor do deposito inicial: ");
                double Di = double.Parse(Console.ReadLine());
                conta = new Conta(numero, titular, Di);
                Console.WriteLine("Conta criada: " + conta);
            }
            else
            {
                conta = new Conta(numero, titular);
                Console.WriteLine("Conta criada: " + conta);
            }


            Console.WriteLine("Deseja fazer um deposito? s/n ");
            char d = char.Parse(Console.ReadLine());
            while (d == 's' || d == 'S')
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
                if (conta.Saldo <= 0)
                {
                    Console.WriteLine("Seu saldo não é suficiente para realizar um saque!!!");
                    Console.Write("Saldo atual: " + conta.Saldo);
                }
                else
                {
                    Console.Write("\nEntre com o valor para saque: ");
                    double saque = double.Parse(Console.ReadLine());
                    conta.Saque(saque);
                    if (conta.Saldo <= 0)
                    {
                        Console.Write("Após esse saque sua conta vai ficar com saldo negativo, deseja continuar mesmo assim? s/n: ");
                        s = char.Parse(Console.ReadLine());
                        if (s == 's' || s == 'S')
                        {
                            s = 'n';
                            Console.Write("\nSaldo negativado !!");
                            Console.WriteLine("\nConta Atualizada: " + conta);
                        }
                        else
                        {
                            conta.Deposito(saque+5);
                            Console.WriteLine("\nConta Atualizada: " + conta);
                            Console.Write("Deseja sacar novamente? s/n ");
                            s = char.Parse(Console.ReadLine());

                        }
                    }
                    else
                    {
                        Console.WriteLine("\nConta Atualizada: " + conta);
                        Console.Write("\nDeseja sacar novamente? s/n ");
                        s = char.Parse(Console.ReadLine());
                    }
                }
                                
            }


            Console.WriteLine();
            Console.WriteLine("programa finalizado obrigado!! ");



        }
    }
}
