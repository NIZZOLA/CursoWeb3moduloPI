using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEventos.Models
{
    public class PessoaModel
    {
        public int PessoaId { get; set; }
        public string Nome { get; set; }
        public SexoEnum Sexo { get; set; }

        public PessoaModel Pai { get; set; }
        public PessoaModel Mae { get; set; }
    }
}
