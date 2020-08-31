using ConsoleEventos.Models;
using System;
using System.Collections.Generic;

namespace ConsoleEventos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            PessoaModel pesJose = new PessoaModel() { PessoaId = 1, Nome = "JOSE", Sexo = SexoEnum.Masculino };
            PessoaModel pesMaria = new PessoaModel() { PessoaId = 1, Nome = "MARIA", Sexo = SexoEnum.Feminino };
            PessoaModel pes2 = new PessoaModel() { PessoaId = 1, Nome = "JESUS", Sexo = SexoEnum.Masculino, Pai = pesJose, Mae = pesMaria };
            


            AssociadoModel assoc = new AssociadoModel();
            


            List<TipoDeEventoModel> tipos = new List<TipoDeEventoModel>();
            tipos.Add(new TipoDeEventoModel() { TipoDeEventoId = 1, Descricao = "Meetup" });
            tipos.Add(new TipoDeEventoModel() { TipoDeEventoId = 2, Descricao = "Live" });
            tipos.Add(new TipoDeEventoModel() { TipoDeEventoId = 3, Descricao = "Artigo" });
            tipos.Add(new TipoDeEventoModel() { TipoDeEventoId = 4, Descricao = "Oficina" });


            PalestranteModel palestrante1 = new PalestranteModel()
            {
                PessoaId = 1,
                Nome = "NIZZOLA",
                DataDaInscricao = DateTime.Parse("01/01/2020"),
                Especialidade = "C#,AZURE,PHP,SQL,....",
                Sexo = SexoEnum.Masculino
            };


            var evento1 = new EventoModel()
            {
                Data = DateTime.Now,
                Descricao = "Live da aula do dia 31/08/2020",
                Link = "xxxxx",
                EventoId = 1,
                NomeImagem = "",
                Texto = "apenas para teste",
                TipoDeEventoId = 1
                
            };

            evento1.Palestrantes.Add(palestrante1);

        }
    }
}
