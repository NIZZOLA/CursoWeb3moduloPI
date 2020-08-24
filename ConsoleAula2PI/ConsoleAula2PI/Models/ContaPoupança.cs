using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAula2PI.Models
{
    public class ContaPoupança : ContaCorrente
    {

        public int DiaAniversario { get; set; }

        //sobrescrita do método da classe pai
        public override bool Sacar(decimal valor )
        {
            if (this.Saldo < valor && DateTime.Today.Day != this.DiaAniversario)
                return false;

            this.Saldo = this.Saldo - valor;
            return true;
        }



    }
}
