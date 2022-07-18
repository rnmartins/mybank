using System;

namespace MyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            MyBank.ContaBanco conta1 = new ContaBanco("Renan Martins", 1200);

            Console.WriteLine($"A conta {conta1.Numero} de {conta1.DonoDaConta} foi criada com R${conta1.Saldo} de saldo!");

            try
            {
                conta1.Depositar(100, DateTime.Now, "Deposito");
                Console.WriteLine($"A conta com R${conta1.Saldo} de saldo!");

                conta1.Sacar(5000, DateTime.Now, "Saque");
                Console.WriteLine($"A conta com R${conta1.Saldo} de saldo!");

            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Operação não realizada!");
            }

            conta1.Sacar(20, DateTime.Now, "Saque");
            Console.WriteLine($"A conta com R${conta1.Saldo} de saldo!");

            conta1.Sacar(300, DateTime.Now, "Saque");
            Console.WriteLine($"A conta com R${conta1.Saldo} de saldo!");

            Console.WriteLine(conta1.PegarMovimentacao());
        }
    }
}
