using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEventos.Models
{
    public class EventoModel
    {
        public EventoModel()
        {
            Palestrantes = new List<PalestranteModel>();
        }
        public int EventoId { get; set; }
        public string Descricao { get; set; }
        public string Link { get; set; }
        public string Texto { get; set; }
        public string NomeImagem { get; set; }
        public DateTime Data { get; set; }
        public int TipoDeEventoId { get; set; }

        public List<PalestranteModel> Palestrantes { get; set; }

    }
}
