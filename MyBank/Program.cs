using System;

namespace MyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            MyBank.ContaBanco conta1 = new ContaBanco("Renan Martins", 1200);

            Console.WriteLine($"A conta {conta1.Numero} de {conta1.DonoDaConta} foi criada com R${conta1.Saldo} de saldo!");
        }
    }
}
