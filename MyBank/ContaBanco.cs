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
            this.Saldo = valor;
            numeroConta++;
            this.Numero = numeroConta.ToString();
        }

        public void Depositar()
        {

        }

        public void Sacar()
        {

        }
    }
}
