using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoNoticiasMVCEtec.Models
{
    [Table("Noticias")]
    public class NoticiaModel
    {
        [Key]
        public int NoticiaId { get; set; }

        [MaxLength(100)]
        public string Titulo { get; set; }

        public DateTime DataDaInclusao { get; set; }

        public string Descricao { get; set; }

        public string NomeDaImagem { get; set; }

    }
}
