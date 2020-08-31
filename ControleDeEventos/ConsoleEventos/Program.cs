using ConsoleEventos.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleEventos
{
    class Program
    {
        static void Main(string[] args)
        {
            ArvoreGenealogica();




            /*
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
            */
        }

        public static void ArvoreGenealogica()
        {
            Console.WriteLine("CADASTRAR PESSOAS");

            List<PessoaModel> listaPessoas = new List<PessoaModel>();

            string continua = "S";

            do
            {
                var pes = new PessoaModel();
                Console.WriteLine("Digite o nome da pessoa");
                pes.Nome = Console.ReadLine();
                // receber outros atributos da pessoa (receber apenas o campo Sexo)
                listaPessoas.Add(pes);

                Console.WriteLine("Deseja receber mais pessoas (S/N) ?");
                continua = Console.ReadLine();

            } while (continua.ToUpper() == "S");


            Console.Clear();
            foreach (var item in listaPessoas.OrderBy(a => a.Nome) )
            {
                // exibir qual é o sexo
                Console.WriteLine($"Nome: {item.Nome}  \n ");
            }



        }



    }
}
