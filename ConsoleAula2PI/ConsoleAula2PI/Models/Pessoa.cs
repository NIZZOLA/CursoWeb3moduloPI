using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAula2PI.Models
{
    public class Pessoa
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public string Cpf { get; set; }

        public string Email { get; set; }

        public bool Valido()
        {
            if (this.Nome != "" && this.Cpf != "")
                return true;

            return false;
        }

    }
}
