using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEventos.Models
{
    public class AssociadoModel : PessoaModel
    {
        public DateTime DataDaInscricao {get;set;}

        public string Senha { get; set; }
    }
}
