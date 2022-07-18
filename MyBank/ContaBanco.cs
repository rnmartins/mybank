using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank
{
    public class ContaBanco
    {
        public string Numero { get; }
        public string DonoDaConta { get; set; }
        public decimal Saldo { 
            get
            {
                decimal saldo = 0;
                foreach (var item in todasTransacoes)
                {
                    saldo += item.Valor;
                }
                return saldo;
            } 
        }

        public static int numeroConta = 12345;

        private List<Transacao> todasTransacoes = new List<Transacao>();

        public ContaBanco(string nome, decimal valor)
        {
            this.DonoDaConta = nome;
            numeroConta++;
            this.Numero = numeroConta.ToString();
            Depositar(valor, DateTime.Now, "Saldo inicial");
        }

        public void Depositar(decimal valor, DateTime data, string obs)
        {
            if(valor <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(valor), "Não aceitamos depósito de valor 0 ou negativo");
            }

            Transacao transacao = new Transacao(valor, data, obs);
            todasTransacoes.Add(transacao);
        }

        public void Sacar(decimal valor, DateTime data, string obs)
        {
            if (valor <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(valor), "Não aceitamos saques de valor 0 ou negativo");
            }

            if (Saldo - valor < 0)
            {
                throw new InvalidOperationException("Essa operação não é permitida!");
            }

            Transacao transacao = new Transacao(-valor, data, obs);
            todasTransacoes.Add(transacao);
        }

        public string PegarMovimentacao()
        {
            var movimentacoes = new StringBuilder();

            movimentacoes.AppendLine("Data\t\t Valor\t Obs");

            foreach (var item in todasTransacoes)
            {
                movimentacoes.AppendLine($"{item.Data.ToShortDateString()}\t {item.Valor}\t {item.Obs}");
            }

            return movimentacoes.ToString();
        }
    }
}
