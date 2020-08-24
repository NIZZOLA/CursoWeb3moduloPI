using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAula2PI.Models
{
    public class ContaCorrente
    {
        public ContaCorrente()
        {
            this.Correntista = new Pessoa();
            this.Historico = new List<Movimentacao>();
        }

        #region Atributos
        public int Agencia { get; set; }

        public int Conta { get; set; }

        // se for private (somente na classe pai)
        // internal na pai e filho
        internal decimal Saldo { get; set; }

        public Pessoa Correntista { get; set; }

        public List<Movimentacao> Historico { get; set; }

        #endregion

        #region Métodos

        public void Depositar( decimal valor )
        {
            this.Saldo = this.Saldo + valor;
            var movimento = new Movimentacao() { Valor = valor, DataDaTransacao = DateTime.Now, Operacao = "+" };
            this.Historico.Add(movimento);
        }

        // virtual permite que se faça a sobrescrita do método
        public virtual bool Sacar( decimal valor )
        {
            if (this.Saldo < valor)
                return false;

            this.Saldo = this.Saldo - valor;
            var movimento = new Movimentacao() { Valor = valor, DataDaTransacao = DateTime.Now, Operacao = "-" };
            this.Historico.Add(movimento);
            return true;
        }

        public decimal VerSaldo()
        {
            return this.Saldo;
        }


        #endregion
    }
}
